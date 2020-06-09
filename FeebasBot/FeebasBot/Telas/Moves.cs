using FeebasBot.Classes;
using System;
using System.Windows.Forms;

namespace FeebasBot.Forms
{
    public partial class Moves : Form
    {
        public Moves()
        {
            InitializeComponent();
        }

        private void Moves_Load(object sender, EventArgs e)
        {
            if (Setting.m1 == 1) { cm1.Checked = true; }
            if (Setting.m2 == 1) { cm2.Checked = true; }
            if (Setting.m3 == 1) { cm3.Checked = true; }
            if (Setting.m4 == 1) { cm4.Checked = true; }
            if (Setting.m5 == 1) { cm5.Checked = true; }
            if (Setting.m6 == 1) { cm6.Checked = true; }
            if (Setting.m7 == 1) { cm7.Checked = true; }
            if (Setting.m8 == 1) { cm8.Checked = true; }
            if (Setting.m9 == 1) { cm9.Checked = true; }
            if (Setting.m10 == 1) { cm10.Checked = true; }
        }

        private void Moves_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                win32.ReleaseCapture();
                win32.SendMessage(Handle, win32.WM_NCLBUTTONDOWN, win32.HT_CAPTION, 0);
            }
        }

        private void Moves_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
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

        private void Moves_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Moves_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
