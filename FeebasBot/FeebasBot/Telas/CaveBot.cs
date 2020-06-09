using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using csharp_Sqlite;
using System.Threading;
using MySqlX.XDevAPI.Relational;
using FeebasBot.Classes;
using System.Runtime.InteropServices;

namespace FeebasBot.Forms
{
    public partial class CaveBot : Form
    {
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;
        public void SendKeysA(Keys vk_key)
        {
            PostMessage(otpHandle, WM_KEYDOWN, (IntPtr)vk_key, IntPtr.Zero);
            PostMessage(otpHandle, WM_KEYUP, (IntPtr)vk_key, IntPtr.Zero);
        }
        int z = 1;
        string colorrod = "0";
        string[] names = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        int[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        int ab = 0;
        int current = 0;
        bool stop = false;
        bool trueif = false;
        int iexec = 0;
        int idatual = 0;
        IntPtr otpHandle = win32.FindWindow(null, Setting.GameName);
        public CaveBot()
        {
            InitializeComponent();
        }
        public void exec()
        {
            if (stop == true) 
            {
                Thread.CurrentThread.Abort();
            }
            int time = 300;
            view.Rows[iexec].Selected = true;
            string now = view.Rows[iexec].Cells[1].Value.ToString();
            switch (now)
            {
                default:
                    break;
                case "Left":
                    win32.SetForegroundWindow(otpHandle);
                    //SendKeysA(Keys.Left);
                    SendKeys.SendWait("{Left}");
                    Thread.Sleep(time);
                    break;
                case "Right":
                    win32.SetForegroundWindow(otpHandle);
                    //SendKeysA(Keys.Right);
                    SendKeys.SendWait("{Right}");
                    Thread.Sleep(time);
                    break;
                case "Up":
                    win32.SetForegroundWindow(otpHandle);
                    //SendKeysA(Keys.Up);
                    SendKeys.SendWait("{Up}");
                    Thread.Sleep(time);
                    break;
                case "Down":
                    win32.SetForegroundWindow(otpHandle);
                    //SendKeysA(Keys.Down);
                    SendKeys.SendWait("{Down}");
                    Thread.Sleep(time);
                    break;
                case "Wait":
                    //win32.SetForegroundWindow(otpHandle);
                    Thread.Sleep(Convert.ToInt32(view.Rows[iexec].Cells[4].Value)*1000);
                    break;
                case "LClick":
                    //win32.SetForegroundWindow(otpHandle);
                    win32.LeftClick(Convert.ToInt32(view.Rows[iexec].Cells[2].Value), Convert.ToInt32(view.Rows[iexec].Cells[3].Value));
                    Thread.Sleep(200);
                    break;
                case "RClick":
                    //win32.SetForegroundWindow(otpHandle);
                    win32.RightClick(Convert.ToInt32(view.Rows[iexec].Cells[2].Value), Convert.ToInt32(view.Rows[iexec].Cells[3].Value));
                    Thread.Sleep(200);
                    break;
                case "Message":
                    //win32.SetForegroundWindow(otpHandle);
                    MessageBox.Show(Convert.ToString(view.Rows[iexec].Cells[4].Value));
                    Thread.Sleep(200);
                    break;
                case "Goto Label":
                    string labeltogo = view.Rows[iexec].Cells[4].Value.ToString();
                    for (int a = 0; a < view.RowCount; a++)
                    {
                        if (view.Rows[a].Cells[1].Value.ToString() == "Label" && view.Rows[a].Cells[4].Value.ToString() == labeltogo)
                        {
                            iexec = a;
                            break;
                        }
                    }
                    break;
                case "If Color":
                    //win32.SetForegroundWindow(otpHandle);
                    int x = Convert.ToInt32(view.Rows[iexec].Cells[2].Value);
                    int y = Convert.ToInt32(view.Rows[iexec].Cells[3].Value);
                    //MessageBox.Show(GrabPixel(x, y));
                    if (GrabPixel(x, y) == view.Rows[iexec].Cells[4].Value.ToString())
                    {
                        trueif = true;
                        //MessageBox.Show(Convert.ToString(trueif));
                        //iexec++;
                    }
                    else
                    {
                        trueif = false;
                        for (int b = iexec; b < view.RowCount; b++)
                        {
                            if (view.Rows[b].Cells[1].Value.ToString() == "Else")
                            {
                                iexec = b;
                                break;
                            }
                            else if (view.Rows[b].Cells[1].Value.ToString() == "End")
                            {
                                iexec = b;
                                break;
                            }
                            if (b == view.RowCount)
                            {
                                MessageBox.Show("End não encontrado!\nParando CaveBot!");
                                iexec = view.RowCount;
                                break;
                            }
                        }
                    }
                    break;
                case "Else":
                    for (int c = iexec; c < view.RowCount; c++)
                    {
                        if (view.Rows[c].Cells[1].Value.ToString() == "End")
                        {
                            //MessageBox.Show("f");
                            if (trueif == true)
                            { iexec = c; trueif = false; }
                            break;
                        }
                        if (c == view.RowCount)
                        {
                            MessageBox.Show("End não encontrado!\nParando CaveBot!");
                            iexec = view.RowCount;
                            break;
                        }
                    }
                    break;
                case "SAY":
                    String s = Convert.ToString(view.Rows[iexec].Cells[4].Value);
                    var chars = s.ToCharArray();
                    for (int ctr = 0; ctr < chars.Length; ctr++)                        //Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
                    {
                        win32.SetForegroundWindow(otpHandle);
                        if (Convert.ToString(chars[ctr]) == " ")
                        {
                            SendKeys.SendWait(" ");
                        }
                        else
                        {
                            SendKeys.SendWait("{" + chars[ctr] + "}");
                        }
                        //MessageBox.Show("{" + chars[ctr] + "}"); 
                    }
                    SendKeys.SendWait("{Enter}");
                    break;
                case "Pokemon":
                    //win32.SetForegroundWindow(otpHandle);
                    int diff = Setting.Poke2Y - Setting.Poke1Y;
                    int pokechange = Convert.ToInt32(view.Rows[iexec].Cells[4].Value);
                    if (pokechange == 1)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke1X, Setting.Poke1Y); }
                    if (pokechange == 2)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke2X, Setting.Poke2Y); }
                    if (pokechange == 3)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke2X, Setting.Poke2Y + diff); }
                    if (pokechange == 4)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke2X, Setting.Poke2Y + diff + diff); }
                    if (pokechange == 5)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke2X, Setting.Poke2Y + diff + diff + diff); }
                    if (pokechange == 6)
                    { Thread.Sleep(500); win32.LeftClick(Setting.Poke2X, Setting.Poke2Y + diff + diff + diff + diff); }
                    Thread.Sleep(3000);
                    break;
                case "Teleport":
                    string tp = "!teleport Saffron";
                    var charstp = tp.ToCharArray();
                    for (int ctr = 0; ctr < charstp.Length; ctr++)                        //Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
                    {
                        win32.SetForegroundWindow(otpHandle);
                        if (Convert.ToString(charstp[ctr]) == " ")
                        {
                            SendKeys.SendWait(" ");
                        }
                        else
                        {
                            SendKeys.SendWait("{" + charstp[ctr] + "}");
                        }
                        //MessageBox.Show("{" + chars[ctr] + "}"); 
                    }
                    SendKeys.SendWait("{Enter}");
                    Thread.Sleep(1000);
                    break;
                case "Logout":
                    while (z == 1)
                    {
                        string colornow = GrabPixel(Setting.RodX, Setting.RodY);
                        Thread.Sleep(1000);
                        win32.SetForegroundWindow(otpHandle);
                        SendKeys.SendWait("^{q}");
                        if (colornow != colorrod)
                        {
                            z = 0;
                            break;
                        }
                    }
                    break;
            }
            if (iexec < view.RowCount)
            { iexec++; }
            if (iexec >= view.RowCount)
            { iexec = 0; stop = true; }
            if (stop == false)
            {
                exec();
            }

        }
        public string GrabPixel(int x, int y)
        {
            //string px = Convert.ToString(getpixel.GetPixel(getpixel.GetWindowDC(getpixel.GetDesktopWindow()), x, y));
            string px = Convert.ToString(getpixel.GetColorAt(otpHandle, x, y));

            return px;
        }

        private void CaveBot_Load(object sender, EventArgs e)
        {
            otpHandle = win32.FindWindow(null, Setting.GameName);
            view.DataSource = DalHelper.GetClientes();
            if (view.RowCount > 0)
            {
                view.Rows[0].Selected = true;
                view.CurrentCell = view[1, 0];
            }
            for (int i = 0; i < view.RowCount; i++)
            {
                idatual = Convert.ToInt32(view.Rows[i].Cells[0].Value)+1;
            }
            view.Columns["id"].Visible = false;
        }
        public void update()
        {
            view.DataSource = DalHelper.GetClientes();
            //alinhar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Test", 100, 200, "");
            idatual++;
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int current = 0;
            int anterior = 0;
            if (view.CurrentRow != null)
            {
                current = view.Rows[view.CurrentRow.Index].Index;
                DalHelper.Delete(Convert.ToInt32(view.Rows[view.CurrentRow.Index].Cells[0].Value));
            }
            update();
            if (current > 0 && view.Rows[current - 1].Cells[0].Value != null)
            {
                view.Rows[current - 1].Selected = true;
                view.CurrentCell = view[1, current - 1];
            }
            else if (current > 0)
            {
                view.Rows[0].Selected = true;
                view.CurrentCell = view[1, 0];
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Left", 0, 0, "");
            win32.SetForegroundWindow(otpHandle);
            SendKeys.SendWait("{Left}");
            //SendKeysA(Keys.Up);
            idatual++;
            update();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Down", 0, 0, "");
            win32.SetForegroundWindow(otpHandle);
            SendKeys.SendWait("{Down}");
            idatual++;
            update();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Up", 0, 0, "");
            win32.SetForegroundWindow(otpHandle);
            SendKeys.SendWait("{Up}");
            idatual++;
            update();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Right", 0, 0, "");
            win32.SetForegroundWindow(otpHandle);
            SendKeys.SendWait("{Right}");
            idatual++;
            update();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            otpHandle = win32.FindWindow(null, Setting.GameName);
            z = 1;
            colorrod = GrabPixel(Setting.RodX, Setting.RodY);
            stop = false;
            iexec = 0;
            //for (iexec = 0; iexec < view.RowCount; iexec++)
            //{
            Thread thread = new Thread(exec);
            thread.Start();
            //}
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            exec();
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Wait", 0, 0, waittime.Text);
            idatual++;
            update();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            DalHelper.Add(idatual, "LClick", MousePosition.X + 8, MousePosition.Y, "");
            idatual++;
            update();
        }
        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            DalHelper.Add(idatual, "RClick", MousePosition.X + 8, MousePosition.Y, "");
            idatual++;
            update();
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Label", 0, 0, txtLabel.Text);
            idatual++;
            update();
        }

        private void btnGotoLabel_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Goto Label", 0, 0, txtLabel.Text);
            idatual++;
            update();
        }

        private void btnColor_MouseUp(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X+8;
            int y = MousePosition.Y;
            DalHelper.Add(idatual, "If Color", x, y, GrabPixel(x, y));
            idatual++;
            update();
        }

        private void btnElse_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Else", 0, 0, "");
            idatual++;
            update();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "End", 0, 0, "");
            idatual++;
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "SAY", 0, 0, txtLabel.Text);
            idatual++;
            update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stop = true;
        }
        public void alinhar()
        {
            DalHelper.UpdateID(Convert.ToInt32(view.Rows[0].Cells[0].Value), 0);
            update();
            int bkpstart = 99;
            int bkp = bkpstart;
            for (int i = 1; i < view.RowCount; i++)
            {
                MessageBox.Show("trocando id:" + Convert.ToString(Convert.ToInt32(view.Rows[i].Cells[0].Value)) + "\nPor:" + Convert.ToString(Convert.ToInt32(view.Rows[i - 1].Cells[0].Value) + 1));
                for (int a = i; a < view.RowCount; a++)
                {
                    if (Convert.ToInt32(view.Rows[a].Cells[0].Value) == Convert.ToInt32(view.Rows[i - 1].Cells[0].Value) + 1)
                    {
                        DalHelper.UpdateID(Convert.ToInt32(view.Rows[a].Cells[0].Value), bkp);
                        bkp++;
                    }
                }
                DalHelper.UpdateID(Convert.ToInt32(view.Rows[i].Cells[0].Value), Convert.ToInt32(view.Rows[i - 1].Cells[0].Value) + 1);
                update();
            }
            /*
            int a = 0;
            while (a < view.RowCount)
            {
                MessageBox.Show(a + ":" + view.RowCount);
                MessageBox.Show("inici");
                MessageBox.Show("pegar ids");
                int idnow = Convert.ToInt32(view.Rows[a].Cells[0].Value);
                int idnext = Convert.ToInt32(view.Rows[a + 1].Cells[0].Value);
                MessageBox.Show("IdAtual:" + idnow + "\nIdProximo:" + idnext); 
                if (idnow==idnext-1)
                {
                    MessageBox.Show("id correto");
                    if (a < view.RowCount)
                    {
                        MessageBox.Show("a++");
                        a++;
                    }                    
                }
                else
                {
                    MessageBox.Show("atualizando id atual (prox-1)");
                    DalHelper.UpdateID(idnow, idnext-1);
                }
                update();
            }
            /*
            while (ab < view.RowCount)
            {
                MessageBox.Show(Convert.ToString(ab));
                int valuei = Convert.ToInt32(view.Rows[ab].Cells[0].Value);
                int valuenext = Convert.ToInt32(view.Rows[ab+1].Cells[0].Value);
                string Comando = Convert.ToString(view.Rows[ab+1].Cells[1].Value);
                int X = Convert.ToInt32(view.Rows[ab+1].Cells[2].Value);
                int Y = Convert.ToInt32(view.Rows[ab+1].Cells[3].Value);
                string Option = Convert.ToString(view.Rows[ab+1].Cells[4].Value);
                if (valuenext == valuei + 1)
                {
                    
                    ab++;
                }
                else
                {
                    MessageBox.Show(Convert.ToString("i:" + valuei + "\nn:" + valuenext + "\ndevia ser:" + valuei + 1));
                    DalHelper.Delete(valuenext);
                    DalHelper.Add(valuei+1, Comando, X, Y, Option);
                    if (ab>0)
                    {
                        ab--;
                    }
                                     
                }
                update();
            }
            */
        }
        private void btnMvUp_Click(object sender, EventArgs e)
        {
            int current = view.CurrentRow.Index;
            if (current > 0)
            {
                //view.Rows[0].Selected = true;
                //view.CurrentCell = view[1, 0];
                //atual
                int id = Convert.ToInt32(view.Rows[current].Cells[0].Value);
                string Comando = Convert.ToString(view.Rows[current].Cells[1].Value);
                int X = Convert.ToInt32(view.Rows[current].Cells[2].Value);
                int Y = Convert.ToInt32(view.Rows[current].Cells[3].Value);
                string Option = Convert.ToString(view.Rows[current].Cells[4].Value);
                //anterior
                int idanterior = Convert.ToInt32(view.Rows[current - 1].Cells[0].Value);
                string Canterior = Convert.ToString(view.Rows[current - 1].Cells[1].Value);
                int Xanterior = Convert.ToInt32(view.Rows[current - 1].Cells[2].Value);
                int Yanterior = Convert.ToInt32(view.Rows[current - 1].Cells[3].Value);
                string Oanterior = Convert.ToString(view.Rows[current - 1].Cells[4].Value);
                //
                DalHelper.Update(idanterior, Comando, X, Y, Option);
                DalHelper.Update(id, Canterior, Xanterior, Yanterior, Oanterior);
                update();
                //view.Rows[idanterior].Selected = true;
                //view.CurrentCell = view[1, idanterior];            
            }
        }

        private void btnMvDown_Click(object sender, EventArgs e)
        {
            current = view.CurrentRow.Index;
            if (current < view.RowCount)
            {
                //view.Rows[0].Selected = true;
                //view.CurrentCell = view[1, 0];
                //atual
                int id = Convert.ToInt32(view.Rows[current].Cells[0].Value);
                string Comando = Convert.ToString(view.Rows[current].Cells[1].Value);
                int X = Convert.ToInt32(view.Rows[current].Cells[2].Value);
                int Y = Convert.ToInt32(view.Rows[current].Cells[3].Value);
                string Option = Convert.ToString(view.Rows[current].Cells[4].Value);
                //anterior
                int idproximo = Convert.ToInt32(view.Rows[current + 1].Cells[0].Value);
                string Cproximo = Convert.ToString(view.Rows[current + 1].Cells[1].Value);
                int Xproximo = Convert.ToInt32(view.Rows[current + 1].Cells[2].Value);
                int Yproximo = Convert.ToInt32(view.Rows[current + 1].Cells[3].Value);
                string Oproximo = Convert.ToString(view.Rows[current + 1].Cells[4].Value);
                //             
                DalHelper.Update(id, Cproximo, Xproximo, Yproximo, Oproximo);
                DalHelper.Update(idproximo, Comando, X, Y, Option);
                update();
                //view.Rows[idproximo].Selected = true;
                //view.CurrentCell = view[1, idproximo];
            }
        }
        private void CaveBot_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Teleport", 0, 0, "Saffron");
            idatual++;
            update();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Logout", 0, 0, "");
            idatual++;
            update();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DalHelper.Add(idatual, "Pokemon", 0, 0, waittime.Text);
            idatual++;
            update();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
