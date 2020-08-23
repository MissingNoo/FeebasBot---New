using FeebasBot.Classes;
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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            X.Text = "X: " + Setting.charx;
            Y.Text = "Y: " + Setting.chary;
            PokeHP.Text = "PokeHP: " + Setting.PokeHP;
            CharHP.Text = "CharHP: " + Setting.CharHP;
        }
    }
}
