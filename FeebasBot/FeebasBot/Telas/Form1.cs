using FeebasBot.Classes;
using FeebasBot.Classes.Bot;
using FeebasBot.Classes.Funcoes;
using FeebasBot.Forms;
using FeebasBot.Telas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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
            IntPtr otpHandle = win32.FindWindow(null, Setting.GameName);
            win32.SetWindowText(otpHandle, "otPokemon");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setting.click = false;
            Setting.clicklock = false;
            if (Setting.login != "") Login();
            Setting.GameName = "otPokemon";
            IntPtr bothandle = win32.FindWindow(null, Setting.GameName + "Bot");
            if (bothandle != IntPtr.Zero) { MessageBox.Show("Renomeie o Client Anteior antes de abrir mais um bot!"); Application.Exit(); }
            this.Text = Setting.GameName + "Bot";
            IntPtr otphandle = win32.FindWindow(null, Setting.GameName);
            if (otphandle == IntPtr.Zero) { MessageBox.Show("otPokemon não está aberto!"); Application.Exit(); }
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
                if (Setting.PodeUsarCaveBot == 1)
                {
                    cavebot.Show();
                }
                else { MessageBox.Show("Função Bloqueada!"); }
            }
        }
        #region Login
        String firstMacAddress = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void Login()
        {
            string mac = "";
            string my = "Server=sql10.freemysqlhosting.net;Database=sql10336993;user=sql10336993;Pwd=8JsRa57ub3;SslMode=none";
            con = new MySqlConnection(my);
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where User='" + Setting.login + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                mac = Convert.ToString(dr.GetValue(2));
                Setting.PodeUsarCaveBot = Convert.ToInt32(dr.GetValue(1));
                Setting.PodeUsarLooting = Convert.ToInt32(dr.GetValue(3));
                Setting.PodeUsarTrocaDePokemon = Convert.ToInt32(dr.GetValue(7));
                Setting.PodeCapturar = Convert.ToInt32(dr.GetValue(6));
            }
            con.Close();
            //MessageBox.Show(Convert.ToString(mac) + "\n" + Convert.ToString(firstMacAddress));
            if (mac == firstMacAddress)
            {
                Setting.LoggedIn = true;
                //MessageBox.Show("Logado com sucesso!");
            }
            else if (mac == "0")
            {
                con.Open();
                cmd.CommandText = "UPDATE users SET MAC='" + firstMacAddress + "' WHERE User='" + Setting.login + "'";
                cmd.ExecuteNonQuery();
                Setting.LoggedIn = true;
                //MessageBox.Show("Logado com sucesso!");
            }
            else if (mac != firstMacAddress && mac != "0" && mac != "")
            {
                MessageBox.Show("Computador diferente do cadastrado no sistema\nComunicar o Desenvolvedor!", "Informação", MessageBoxButtons.OK);
            }
            con.Close();
        }
        #endregion
        #endregion
        #endregion
        #region Variaveis
        bool Pescando = false;
        bool Pescou = false;

        #endregion
        private void bStart_Click(object sender, EventArgs e)
        {
            Setting.Kill = false;
            Pescando = false;
            Pescou = false;
            bStart.BackColor = Color.Green;
            Setting.PlayerOnScreen = false;
            Setting.Running = true;
            Run.Start();
        }
        void pescar()
        {
            Pesca.Pescar();
            Pescando = false;
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            Setting.Kill = true;
            Run.Stop();
            bStart.BackColor = Color.Red;
        }
        void start()
        {
            if (Setting.PescarSemParar == 1) { Setting.triestotal = 20; }
            else { Setting.triestotal = 7; }
            if (Setting.PlayerOnScreen == false)
            {
                if (Setting.Atacar == 1)
                {
                    Ataque.Atacar();
                }
                if (Setting.Pescar == 1 && Setting.PescarSemParar == 0)
                {
                    if (Setting.Lootear == 1) Looting.AbrirCorpos();
                    Pesca.Pescar();
                }
                Setting.tries = 0;
                if (Setting.Atacar == 1)
                {
                    Ataque.Atacar();
                }
                Setting.Running = true;
            }
        }

        

        private void Run_Tick(object sender, EventArgs e)
        {
            if (Setting.Pescar == 1 && Setting.PescarSemParar == 1)
            {
                Thread thread2 = new Thread(pescar);
                if (Pescando == false) thread2.Start();
                Pescando = true;
            }
            Thread thread = new Thread(start);
            if (Setting.Running)
            {
                Setting.Running = false; 
                thread.Start();
            }
            if (Setting.PlayerOnScreen == true) { Run.Stop(); bStart.BackColor = Color.Red; FormsV.playSound("alarm.wav"); }
            //Thread.Sleep(200);
        }

        private void Open_Tick(object sender, EventArgs e)
        {
            this.Text = Setting.GameName + "Bot";
            if (Setting.GameName != "otPokemon") { label1.Text = Setting.GameName; }
            nIcon.Text = "Clique duas vezes para abrir a janela do bot!\nChar: " + Setting.GameName;
        }
    }
}
