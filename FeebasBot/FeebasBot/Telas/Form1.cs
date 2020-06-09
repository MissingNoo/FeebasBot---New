using FeebasBot.Classes;
using FeebasBot.Classes.Bot;
using FeebasBot.Classes.Funcoes;
using FeebasBot.Forms;
using FeebasBot.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot
{
    public partial class Form1 : Form
    {
        #region Form
        #region Form Functions
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setting.GameName = "otPokemon";
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                win32.ReleaseCapture();
                win32.SendMessage(Handle, win32.WM_NCLBUTTONDOWN, win32.HT_CAPTION, 0);
            }
        }
        #endregion
        #region Buttons
        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void nIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        private void bConfig_Click(object sender, EventArgs e)
        {
            Configuracao configuracao = new Configuracao();
            if (FormsV.CheckOpened("Configuracao"))
            {
                configuracao.Close();
            }
            else
            {
                configuracao.Show();
            }
        }
        private void bCave_Click(object sender, EventArgs e)
        {
            CaveBot cavebot = new CaveBot();
            if (FormsV.CheckOpened("CaveBot"))
            {
                cavebot.Close();
            }
            else
            {
                cavebot.Show();
            }
        }
        #endregion
        #endregion
        #region Variaveis
        bool Pescando = false;
        bool Pescou = false;

        #endregion
        private void bStart_Click(object sender, EventArgs e)
        {
            Run.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            Setting.Running = true;
            Run.Stop();
        }
        void start()
        {
            if (Setting.Pescar == 1 && Pescou == false)
            {
                Pescou = Pesca.Pescar();
            }
            if (Setting.Atacar == 1)
            {
                Ataque.Atacar();
            }
            Pescou = false;
            Setting.Running = true;
        }

        

        private void Run_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(start);
            if (Setting.Running)
            {
                Setting.Running = false; 
                thread.Start();
            }
        }
    }
}
