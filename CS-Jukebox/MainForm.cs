using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CSGSI;
using CSGSI.Events;
using System.Runtime.InteropServices;

namespace CS_Jukebox
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private GameStateListener gsl;

        public MainForm()
        {
            InitializeComponent();
            AllocConsole(); //Enable console

            Properties.Load();

            if (Properties.GameDir == null)
            {
                Form dirPopup = new GamePathForm();
                dirPopup.Show(this);
            }
        }

        void StartGameListener()
        {
            gsl = new GameStateListener(5001);
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
            Console.WriteLine("New Game State: ");
            Console.WriteLine(gs.ToString());
        }

        void OnRoundBegin(RoundBeginEventArgs e)
        {
            Console.WriteLine("Round begun.");
        }

        void OnBombPlanted(BombPlantedEventArgs e)
        {
            Console.WriteLine("Bomb has been planted.");
        }
    }
}
