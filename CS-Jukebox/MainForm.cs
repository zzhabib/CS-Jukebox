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
using CSGSI.Nodes;
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
            
            //If game directory is not set, create
            //popup so that user can browse to it.
            if (Properties.GameDir == null)
            {
                Form dirPopup = new GamePathForm(StartGameListener); //Pass method to start game listener
                dirPopup.Show(this);
            }
            else
            {
                StartGameListener();
            }
        }

        void StartGameListener()
        {
            Properties.CreateConfig();

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
            Console.WriteLine("Round phase: " + gs.Round.Phase.ToString());
            Console.WriteLine("Bomb Status: " + gs.Round.Bomb.ToString());
        }

        void OnRoundBegin()
        {
            Console.WriteLine("Round begun.");
        }

        void OnBombPlanted()
        {
            Console.WriteLine("Bomb has been planted.");
        }
    }
}
