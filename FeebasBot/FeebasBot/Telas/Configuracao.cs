using FeebasBot.Classes;
using FeebasBot.Classes.Bot;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Telas
{
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        private void basescreen_Load(object sender, EventArgs e)
        {
            if (Setting.attacktime < 100) Setting.attacktime = 100;
            if (Setting.PodeUsarLooting == 0) cLoot.Enabled = false;
            numericUpDown1.Value = Setting.attacktime;
            gName.Text = Setting.GameName;
            if (Setting.login == "" || Setting.login == null) { panel7.Visible = true; }
            if (Setting.PodeUsarLooting == 1) { lLooting.ForeColor = Color.Green; } else { lLooting.ForeColor = Color.Red; }
            if (Setting.PodeUsarTrocaDePokemon== 1) { cTrocaDePoke.Enabled = true; lTroca.ForeColor = Color.Green; } else { cTrocaDePoke.Enabled = false; lTroca.ForeColor = Color.Red; }
            if (Setting.PodeCapturar == 1) { lCatch.ForeColor = Color.Green; } else { lCatch.ForeColor = Color.Red; }
            if (Setting.PodeUsarCaveBot == 1) { lCave.ForeColor = Color.Green; } else { lCave.ForeColor = Color.Red; }
            label10.Text = Setting.login;
            if (Setting.Pescar == 1) { cPescar.Checked = true; cNoStop.Enabled = true; cRandom.Enabled = true; } else { cNoStop.Enabled = false; cRandom.Enabled = false; }
            if (Setting.random == 1) { cRandom.Checked = true; } else { cRandom.Checked = false; }
            if (Setting.PescarSemParar == 1) cNoStop.Checked = true;
            if (Setting.Atacar == 1) { cAtacar.Checked = true; cSemTarget.Enabled = true; } else { cSemTarget.Enabled = false; }
            if (Setting.AtacarSemTarget == 1) cSemTarget.Checked = true;
            if (Setting.Lootear == 1) cLoot.Checked = true;
            if (Setting.m1 == 1) cm1.Checked = true;
            if (Setting.m2 == 1) cm2.Checked = true;
            if (Setting.m3 == 1) cm3.Checked = true;
            if (Setting.m4 == 1) cm4.Checked = true;
            if (Setting.m5 == 1) cm5.Checked = true;
            if (Setting.m6 == 1) cm6.Checked = true;
            if (Setting.m7 == 1) cm7.Checked = true;
            if (Setting.m8 == 1) cm8.Checked = true;
            if (Setting.m9 == 1) cm9.Checked = true;
            if (Setting.m10 == 1) cm10.Checked = true;
            if (Setting.p1 == 1) p1.Checked = true;
            if (Setting.p2 == 1) p2.Checked = true;
            if (Setting.p3 == 1) p3.Checked = true;
            if (Setting.p4 == 1) p4.Checked = true;
            if (Setting.p5 == 1) p5.Checked = true;
            if (Setting.p6 == 1) p6.Checked = true;
            if (Setting.p7 == 1) p7.Checked = true;
            if (Setting.p8 == 1) p8.Checked = true;
        }

        private void basescreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                win32.ReleaseCapture();
                win32.SendMessage(Handle, win32.WM_NCLBUTTONDOWN, win32.HT_CAPTION, 0);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {

        }
        private void btnVara_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição da Vara?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.RodX = xn;
                Setting.RodY = yn;
                MessageBox.Show("Posição da Vara salva!");
            }
        }

        private void btnVara_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
        }

        private void btnAgua_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição da Agua?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.WaterX = xn;
                Setting.WaterY = yn;
                MessageBox.Show("Posição da Agua salva!");
            }
        }

        private void btnPeixe_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Peixe?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.FishX = xn;
                Setting.FishY = yn;
                MessageBox.Show("Posição do Peixe salva!");
            }
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja Configurar a posição da Batalha??", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Ataque.ConfigurarAtaque(xn, yn);

            }
            
        }
        #region ManualConfig
        private void cManualConfig1_CheckedChanged(object sender, EventArgs e)
        {
            cManualConfig2.Checked = false;
            ManualConfig.Start();
        }

        private void cManualConfig2_CheckedChanged(object sender, EventArgs e)
        {
            cManualConfig1.Checked = false;
            ManualConfig.Start();
        }
        
        private void ManualConfig_Tick(object sender, EventArgs e)
        {
            win32.MoveMouse(Setting.BattleX, Setting.BattleY);
            win32.MoveMouse(Setting.BattleX+1, Setting.BattleY);
            if (cManualConfig1.Checked)
            {
                //pixelmiddle
                uint pixel = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX, Setting.TargetY));
                Color colormiddle = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
                ManualMiddle.BackColor = colormiddle;
                //pixelleft
                uint pixelleft = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX - 1, Setting.TargetY));
                Color colorleft = Color.FromArgb((int)(pixelleft & 0x000000FF), (int)(pixelleft & 0x0000FF00) >> 8, (int)(pixelleft & 0x00FF0000) >> 16);
                ManualLeft.BackColor = colorleft;
                //pixelright
                uint pixelright = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX + 1, Setting.TargetY));
                Color colorright = Color.FromArgb((int)(pixelright & 0x000000FF), (int)(pixelright & 0x0000FF00) >> 8, (int)(pixelright & 0x00FF0000) >> 16);
                ManualRight.BackColor = colorright;
                //pixelup
                uint pixelup = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX, Setting.TargetY - 1));
                Color colorup = Color.FromArgb((int)(pixelup & 0x000000FF), (int)(pixelup & 0x0000FF00) >> 8, (int)(pixelup & 0x00FF0000) >> 16);
                ManualUp.BackColor = colorup;
                //pixeldown
                uint pixeldown = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX, Setting.TargetY + 1));
                Color colordown = Color.FromArgb((int)(pixeldown & 0x000000FF), (int)(pixeldown & 0x0000FF00) >> 8, (int)(pixeldown & 0x00FF0000) >> 16);
                ManualDown.BackColor = colordown;
            }
            if (cManualConfig2.Checked)
            {
                //pixelmiddle
                uint pixel = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX2, Setting.TargetY2));
                Color colormiddle = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
                ManualMiddle.BackColor = colormiddle;
                //pixelleft
                uint pixelleft = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX2 - 1, Setting.TargetY2));
                Color colorleft = Color.FromArgb((int)(pixelleft & 0x000000FF), (int)(pixelleft & 0x0000FF00) >> 8, (int)(pixelleft & 0x00FF0000) >> 16);
                ManualLeft.BackColor = colorleft;
                //pixelright
                uint pixelright = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX2 + 1, Setting.TargetY2));
                Color colorright = Color.FromArgb((int)(pixelright & 0x000000FF), (int)(pixelright & 0x0000FF00) >> 8, (int)(pixelright & 0x00FF0000) >> 16);
                ManualRight.BackColor = colorright;
                //pixelup
                uint pixelup = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX2, Setting.TargetY2 - 1));
                Color colorup = Color.FromArgb((int)(pixelup & 0x000000FF), (int)(pixelup & 0x0000FF00) >> 8, (int)(pixelup & 0x00FF0000) >> 16);
                ManualUp.BackColor = colorup;
                //pixeldown
                uint pixeldown = Convert.ToUInt32(getpixel.GrabPixel(Setting.TargetX2, Setting.TargetY2 + 1));
                Color colordown = Color.FromArgb((int)(pixeldown & 0x000000FF), (int)(pixeldown & 0x0000FF00) >> 8, (int)(pixeldown & 0x00FF0000) >> 16);
                ManualDown.BackColor = colordown;
            }
            if (!cManualConfig1.Checked && !cManualConfig2.Checked)
            {
                ManualMiddle.BackColor = Color.Black;
                ManualRight.BackColor = Color.Black;
                ManualLeft.BackColor = Color.Black;
                ManualUp.BackColor = Color.Black;
                ManualDown.BackColor = Color.Black;
                ManualConfig.Stop();
            }
            
        }

        private void ManualLeft_Click(object sender, EventArgs e)
        {
            if(cManualConfig1.Checked)//configurando px1 
            {
                Setting.TargetX--;
            }
            if (cManualConfig2.Checked)//configurando px1 
            {
                Setting.TargetX2--;
            }
        }

        private void ManualRight_Click(object sender, EventArgs e)
        {
            if (cManualConfig1.Checked)//configurando px1 
            {
                Setting.TargetX++;
            }
            if (cManualConfig2.Checked)//configurando px1 
            {
                Setting.TargetX2++;
            }
        }

        private void ManualDown_Click(object sender, EventArgs e)
        {
            if (cManualConfig1.Checked)//configurando px1 
            {
                Setting.TargetY++;
            }
            if (cManualConfig2.Checked)//configurando px1 
            {
                Setting.TargetY2++;
            }
        }

        private void ManualUp_Click(object sender, EventArgs e)
        {
            if (cManualConfig1.Checked)//configurando px1 
            {
                Setting.TargetY--;
            }
            if (cManualConfig2.Checked)//configurando px1 
            {
                Setting.TargetY2--;
            }
        }
        #endregion
        #region Moves
        private void cm1_CheckedChanged(object sender, EventArgs e)
        {
            if (cm1.Checked == true)
            {
                Setting.m1 = 1;
            }
            else
            {
                Setting.m1 = 0;
            }
        }

        private void cm2_CheckedChanged(object sender, EventArgs e)
        {
            if (cm2.Checked == true)
            {
                Setting.m2 = 1;
            }
            else
            {
                Setting.m2 = 0;
            }
        }

        private void cm3_CheckedChanged(object sender, EventArgs e)
        {
            if (cm3.Checked == true)
            {
                Setting.m3 = 1;
            }
            else
            {
                Setting.m3 = 0;
            }
        }

        private void cm4_CheckedChanged(object sender, EventArgs e)
        {
            if (cm4.Checked == true)
            {
                Setting.m4 = 1;
            }
            else
            {
                Setting.m4 = 0;
            }
        }

        private void cm5_CheckedChanged(object sender, EventArgs e)
        {
            if (cm5.Checked == true)
            {
                Setting.m5 = 1;
            }
            else
            {
                Setting.m5 = 0;
            }
        }

        private void cm6_CheckedChanged(object sender, EventArgs e)
        {
            if (cm6.Checked == true)
            {
                Setting.m6 = 1;
            }
            else
            {
                Setting.m6 = 0;
            }
        }

        private void cm7_CheckedChanged(object sender, EventArgs e)
        {
            if (cm7.Checked == true)
            {
                Setting.m7 = 1;
            }
            else
            {
                Setting.m7 = 0;
            }
        }

        private void cm8_CheckedChanged(object sender, EventArgs e)
        {
            if (cm8.Checked == true)
            {
                Setting.m8 = 1;
            }
            else
            {
                Setting.m8 = 0;
            }
        }

        private void cm9_CheckedChanged(object sender, EventArgs e)
        {
            if (cm9.Checked == true)
            {
                Setting.m9 = 1;
            }
            else
            {
                Setting.m9 = 0;
            }
        }

        private void cm10_CheckedChanged(object sender, EventArgs e)
        {
            if (cm10.Checked == true)
            {
                Setting.m10 = 1;
            }
            else
            {
                Setting.m10 = 0;
            }
        }

        #endregion

        private void cPescar_CheckedChanged(object sender, EventArgs e)
        {
            if (cPescar.Checked == true) { Setting.Pescar = 1; cNoStop.Enabled = true; cRandom.Enabled = true; }
            else { Setting.Pescar = 0; cNoStop.Enabled = false;cRandom.Enabled = false; }
        }

        private void cAtacar_CheckedChanged(object sender, EventArgs e)
        {
            if (cAtacar.Checked == true) { Setting.Atacar = 1; cSemTarget.Enabled = true; }
            else { Setting.Atacar = 0; cSemTarget.Enabled = false; cSemTarget.Checked = false; }
        }

        private void tabFunction_Click(object sender, EventArgs e)
        {

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
        private void bLogin_Click(object sender, EventArgs e)
        {
            int puc = 0, pul = 0, put = 0, pc = 0;
            Setting.login = txtLogin.Text;
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
                puc = Convert.ToInt32(dr.GetValue(1));
                pul = Convert.ToInt32(dr.GetValue(3));
                put = Convert.ToInt32(dr.GetValue(7));
                pc = Convert.ToInt32(dr.GetValue(6));
            }
            con.Close();
            //MessageBox.Show(Convert.ToString(mac) + "\n" + Convert.ToString(firstMacAddress));
            if (mac == firstMacAddress)
            {
                Setting.LoggedIn = true;
                Setting.PodeUsarCaveBot = puc;
                Setting.PodeUsarLooting = pul;
                Setting.PodeUsarTrocaDePokemon = put;
                Setting.PodeCapturar = pc;
                MessageBox.Show("Logado com sucesso!");
            }
            else if (mac == "0")
            {
                con.Open();
                cmd.CommandText = "UPDATE users SET MAC='" + firstMacAddress + "' WHERE User='" + Setting.login + "'";
                cmd.ExecuteNonQuery();
                Setting.LoggedIn = true;
                MessageBox.Show("Logado com sucesso!");
            }
            else if (mac != firstMacAddress && mac != "0" && mac != "")
            {
                MessageBox.Show("Computador diferente do cadastrado no sistema\nComunicar o Desenvolvedor!", "Informação", MessageBoxButtons.OK);
            }
            con.Close();
            this.Close();
        }
        #endregion

        private void tabLogin_Click(object sender, EventArgs e)
        {

        }

        private void gName_TextChanged(object sender, EventArgs e)
        {
            if (gName.Text != "")
            {
                IntPtr otpHandle = win32.FindWindow(null, Setting.GameName);
                Setting.GameName = gName.Text;
                win32.SetWindowText(otpHandle, Setting.GameName);
            }
        }

        private void tabAtk_Click(object sender, EventArgs e)
        {

        }

        private void cNoStop_CheckedChanged(object sender, EventArgs e)
        {
            if (cNoStop.Checked == true) { Setting.PescarSemParar = 1; }
            else { Setting.PescarSemParar = 0; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string pixel = getpixel.GrabPixel(Setting.TargetX, Setting.TargetY);
            if (pixel == "16777215") { cManualConfig1.ForeColor = Color.Green; } else { cManualConfig1.ForeColor = Color.Black; }
            string pixel2 = getpixel.GrabPixel(Setting.TargetX, Setting.TargetY);
            if (pixel2 == "16777215") { cManualConfig2.ForeColor = Color.Green; timer1.Stop(); } else { cManualConfig2.ForeColor = Color.Black; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Setting.attacktime = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Battlemanual_CheckedChanged(object sender, EventArgs e)
        {
            if (Battlemanual.Checked)
            { panel4.Visible = true; }
            else { panel4.Visible = false; }
        }

        private void cLoot_CheckedChanged(object sender, EventArgs e)
        {
            if (cLoot.Checked == true) { Setting.Lootear = 1; }
            else { Setting.Lootear = 0; }
        }

        private void cShowLoot_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(DrawLooting);
            thread.Start();
        }
        public void DrawLooting()
        {
            int position = (Setting.SQMY - Setting.PlayerY);
            while (cShowLoot.Checked == true)
            {
                IntPtr desktopPtr = win32.GetDC(IntPtr.Zero);
                Graphics g = Graphics.FromHdc(desktopPtr);
                SolidBrush b = new SolidBrush(Color.Red);
                SolidBrush rec = new SolidBrush(Color.Purple);
                g.FillRectangle(b, Setting.PlayerX - 16, Setting.PlayerY - 16, 32, 32);
                // /\ <
                if (Setting.p1 == 1) { g.FillRectangle(rec, Setting.SQMX - position - 16, Setting.SQMY - position * 2 - 16, 32, 32); }
                if (Setting.p2 == 1) { g.FillRectangle(rec, Setting.SQMX - 16, Setting.SQMY - position * 2 - 16, 32, 32); }
                if (Setting.p3 == 1) { g.FillRectangle(rec, Setting.SQMX + position - 16, Setting.SQMY - position * 2 - 16, 32, 32); }
                if (Setting.p4 == 1) { g.FillRectangle(rec, Setting.SQMX - position - 16, Setting.SQMY - position - 16, 32, 32); }
                if (Setting.p5 == 1) { g.FillRectangle(rec, Setting.SQMX + position - 16, Setting.SQMY - position - 16, 32, 32); }
                if (Setting.p6 == 1) { g.FillRectangle(rec, Setting.SQMX - position - 16, Setting.SQMY - 16, 32, 32); }
                if (Setting.p7 == 1) { g.FillRectangle(rec, Setting.SQMX - 16, Setting.SQMY - 16, 32, 32); }
                if (Setting.p8 == 1) { g.FillRectangle(rec, Setting.SQMX + position - 16, Setting.SQMY - 16, 32, 32); }
                g.Dispose();
                win32.ReleaseDC(IntPtr.Zero, desktopPtr);
            }
        }

        private void DrawPositions_Tick(object sender, EventArgs e)
        {
            
        }

        private void bPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Player?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.PlayerX = xn;
                Setting.PlayerY = yn;
                MessageBox.Show("Posição do Player salva!");
            }
        }

        private void bSquare_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Quadrado?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.SQMX = xn;
                Setting.SQMY = yn;
                MessageBox.Show("Posição do Quadrado salva!");
            }
        }

        private void Configuracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            cShowLoot.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Looting.AbrirCorpos();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (p1.Checked == true) { Setting.p1 = 1; } else { Setting.p1 = 0; }
            if (p2.Checked == true) { Setting.p2 = 1; } else { Setting.p2 = 0; }
            if (p3.Checked == true) { Setting.p3 = 1; } else { Setting.p3 = 0; }
            if (p4.Checked == true) { Setting.p4 = 1; } else { Setting.p4 = 0; }
            if (p5.Checked == true) { Setting.p5 = 1; } else { Setting.p5 = 0; }
            if (p6.Checked == true) { Setting.p6 = 1; } else { Setting.p6 = 0; }
            if (p7.Checked == true) { Setting.p7 = 1; } else { Setting.p7 = 0; }
            if (p8.Checked == true) { Setting.p8 = 1; } else { Setting.p8 = 0; }
            Setting.SaveSettings();
        }

        private void bCloseLoot_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição de Fechar Loot?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.CloseX = xn;
                Setting.CloseY = yn;
                MessageBox.Show("Posição de Fechar Loot salva!");
            }
        }

        private void bSlot_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Slot?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.SlotX = xn;
                Setting.SlotY = yn;
                MessageBox.Show("Posição do Slot salva!");
            }
        }

        private void bOrder_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Order?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.OrderX = xn;
                Setting.OrderY = yn;
                MessageBox.Show("Posição do Order salva!");
            }
        }

        private void cSemTarget_CheckedChanged(object sender, EventArgs e)
        {
            if (cSemTarget.Checked == true) { Setting.AtacarSemTarget = 1; } else { Setting.AtacarSemTarget = 0; }
        }

        private void cRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cRandom.Enabled == true) { Setting.random = 1; } else { Setting.random = 0; }
        }

        private void cTrocaDePoke_CheckedChanged(object sender, EventArgs e)
        {
            if (cTrocaDePoke.Enabled == true) { Setting.TrocarDePokemon = 1; } else { Setting.TrocarDePokemon = 0; }
        }

        private void bPoke1_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke1X = xn;
                Setting.Poke1Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPoke2_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke2X = xn;
                Setting.Poke2Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPoke3_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke3X = xn;
                Setting.Poke3Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPoke4_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke4X = xn;
                Setting.Poke4Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPoke5_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke5X = xn;
                Setting.Poke5Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPoke6_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Pokemon?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.Poke6X = xn;
                Setting.Poke6Y = yn;
                MessageBox.Show("Posição do Pokemon salva!");
            }
        }

        private void bPortrait_MouseUp(object sender, MouseEventArgs e)
        {
            int xn = MousePosition.X;
            int yn = MousePosition.Y;
            DialogResult dialogResult = MessageBox.Show("Deseja salvar a posição do Portrait?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Setting.PortraitX = xn;
                Setting.PortraitY = yn;
                Setting.portraitdead = getpixel.GrabPixel(xn, yn);
                MessageBox.Show("Posição do Portrait salva!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(TrocaDePoke.VerificarMorto);
            thread.Start();
        }
    }
}
