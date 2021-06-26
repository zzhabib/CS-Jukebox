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

        bool dirSelected = false;

        private GameStateListener gsl;

        public MainForm()
        {
            InitializeComponent();
            AllocConsole(); //Enable console

            if (!dirSelected)
            {
                Form dirPopup = new GamePathForm();
                dirPopup.Show(this);
            }

            gsl = new GameStateListener(1337);
            gsl.NewGameState += OnNewGameState;
            gsl.RoundBegin += OnRoundBegin;
            gsl.BombPlanted += OnBombPlanted;

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
