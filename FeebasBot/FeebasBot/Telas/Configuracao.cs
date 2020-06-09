using FeebasBot.Classes;
using FeebasBot.Classes.Bot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (Setting.Pescar == 1) cPescar.Checked = true;
            if (Setting.Atacar == 1) cAtacar.Checked = true;
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
            Ataque.ConfigurarAtaque(MousePosition.X, MousePosition.Y) ;
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
            if (cPescar.Checked == true) { Setting.Pescar = 1; }
            else { Setting.Pescar = 0; }
        }

        private void cAtacar_CheckedChanged(object sender, EventArgs e)
        {
            if (cAtacar.Checked == true) { Setting.Atacar = 1; }
            else { Setting.Atacar = 0; }
        }

        private void tabFunction_Click(object sender, EventArgs e)
        {

        }
    }
}
