using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSGSI;
using CSGSI.Nodes;

namespace CS_Jukebox
{
    class GameLogic
    {
        public Jukebox jukebox;

        private GameStateListener gsl;
        private MusicState musicState = MusicState.None;
        private int playerMVPs = 0;
        private int roundTime = 115;
        private int bombTime = 45;
        private int currentRoundTime = 0;
        private int currentBombTime = 0;

        public GameLogic()
        {
            jukebox = new Jukebox();
            StartGameListener();
            SetupTimer();
        }

        void StartGameListener()
        {
            gsl = new GameStateListener(3000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);

            if (!gsl.Start())
            {
                Console.WriteLine("Game State Listener failed to start.");
            }
            else
            {
                Console.WriteLine("Listening...");
            }
        }

        void OnNewGameState(GameState gs)
        {
            if (Properties.SelectedKit == null) return;

            if (gs.Map.JSON.Equals("{}") && musicState != MusicState.Menu)
            {
                musicState = MusicState.Menu;
                playerMVPs = 0;
                jukebox.PlaySong(Properties.SelectedKit.mainMenuSong, true);
                Console.WriteLine("Main Menu");
            }

            if (gs.Round.Phase == RoundPhase.FreezeTime && musicState != MusicState.FreezeTime)
            {
                if (musicState == MusicState.Menu)
                {
                    JoinedGame(gs);
                }

                musicState = MusicState.FreezeTime;
                jukebox.PlaySong(Properties.SelectedKit.freezeSong, false);
                currentRoundTime = 0;
                currentBombTime = 0;
                Console.WriteLine("FreezeTime Begun");
            }

            if (musicState == MusicState.Menu)
            {
                if (gs.Round.Phase == RoundPhase.Live)
                {
                    //Fade out main menu song
                    Console.WriteLine("Stopping main menu song");
                    jukebox.Stop();
                }
                return;
            }

            if (gs.Round.Phase == RoundPhase.Live && musicState != MusicState.Live && musicState != MusicState.BombPlanted)
            {
                musicState = MusicState.Live;
                jukebox.PlaySong(Properties.SelectedKit.startSong, false, 8);
                Console.WriteLine("Round Begun");
            }

            if (gs.Round.Phase == RoundPhase.Over && musicState != MusicState.Over)
            {
                musicState = MusicState.Over;

                if (gs.Round.WinTeam == RoundWinTeam.T && gs.Player.Team == PlayerTeam.T)
                {
                    RoundWin(gs);
                }
                else if (gs.Round.WinTeam == RoundWinTeam.CT && gs.Player.Team == PlayerTeam.CT)
                {
                    RoundWin(gs);
                }
                else
                {
                    //lose
                    jukebox.PlaySong(Properties.SelectedKit.loseSong, false);
                }
            }

            if (gs.Round.Bomb == BombState.Planted && musicState != MusicState.BombPlanted)
            {
                musicState = MusicState.BombPlanted;
                jukebox.PlaySong(Properties.SelectedKit.bombSong, false);
                Console.WriteLine("Bomb Planted");
            }
        }

        private void JoinedGame(GameState gs)
        {
            switch (gs.Map.Mode)
            {
                case MapMode.Casual:
                    roundTime = 120;
                    bombTime = 45;
                    break;
                case MapMode.Competitive:
                    roundTime = 115;
                    bombTime = 40;
                    break;
                default:
                    roundTime = 120;
                    bombTime = 45;
                    break;
            }
        }

        private void RoundWin(GameState gs)
        {
            //Check if player was MVP of the round
            if (gs.Player.MatchStats.MVPs > playerMVPs)
            {
                jukebox.PlaySong(Properties.SelectedKit.MVPSong, false);
                playerMVPs = gs.Player.MatchStats.MVPs;
            }
            else
            {
                jukebox.PlaySong(Properties.SelectedKit.winSong, false);
            }
        }

        private void SetupTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (musicState == MusicState.Live)
            {
                currentRoundTime++;

                if (roundTime - currentRoundTime == 10)
                {
                    Console.WriteLine("Ten Seconds left on round");
                    jukebox.PlaySong(Properties.SelectedKit.roundTenSecSong, false);
                }
            }
            else if (musicState == MusicState.BombPlanted)
            {
                currentBombTime++;

                if (bombTime - currentBombTime == 10)
                {
                    Console.WriteLine("Ten Seconds left on bomb");
                    jukebox.PlaySong(Properties.SelectedKit.bombTenSecSong, false);
                }
            }
        }
    }

    public enum MusicState
    {
        None,
        Menu,
        FreezeTime,
        Live,
        BombPlanted,
        Over
    }
}
