using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGSI;
using CSGSI.Nodes;

namespace CS_Jukebox
{
    class GameLogic
    {
        private GameStateListener gsl;
        private MusicState musicState = MusicState.None;
        private Jukebox jukebox;

        public GameLogic()
        {
            jukebox = new Jukebox();
            StartGameListener();
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
                Console.WriteLine("Main Menu");
            }

            if (gs.Round.Phase == RoundPhase.FreezeTime && musicState != MusicState.FreezeTime)
            {
                musicState = MusicState.FreezeTime;
                jukebox.PlaySong(Properties.SelectedKit.freezeSong);
                Console.WriteLine("FreezeTime Begun");
            }

            if (musicState == MusicState.Menu) return;

            if (gs.Round.Phase == RoundPhase.Live && musicState != MusicState.Live && musicState != MusicState.BombPlanted)
            {
                musicState = MusicState.Live;
                jukebox.PlaySong(Properties.SelectedKit.startSong);
                Console.WriteLine("Round Begun");
            }

            if (gs.Round.Phase == RoundPhase.Over && musicState != MusicState.Over)
            {
                musicState = MusicState.Over;

                if (gs.Round.WinTeam == RoundWinTeam.T && gs.Player.Team == PlayerTeam.T)
                {
                    //win
                    jukebox.PlaySong(Properties.SelectedKit.winSong);
                }
                else if (gs.Round.WinTeam == RoundWinTeam.CT && gs.Player.Team == PlayerTeam.CT)
                {
                    //win
                    jukebox.PlaySong(Properties.SelectedKit.winSong);
                }
                else
                {
                    //lose
                    jukebox.PlaySong(Properties.SelectedKit.loseSong);
                }
            }

            if (gs.Round.Bomb == BombState.Planted && musicState != MusicState.BombPlanted)
            {
                musicState = MusicState.BombPlanted;
                jukebox.PlaySong(Properties.SelectedKit.bombSong);
                Console.WriteLine("Bomb Planted");
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
