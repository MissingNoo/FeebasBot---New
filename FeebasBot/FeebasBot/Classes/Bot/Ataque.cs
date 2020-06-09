using FeebasBot.Classes.Funcoes;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Ataque
    {
        public static bool ConfigurarAtaque(int x, int y)
        {
            int maxy = y + 100;
            bool stop = false;
            bool found = false;
            string color = getpixel.GrabPixel(x, y);
            while (color != "0")
            {
                if (y >= maxy)
                {
                    stop = true;
                    break;
                }
                else
                {
                    y++;
                }
                color = getpixel.GrabPixel(x, y);
                if (color == "0")
                {
                    found = true; 
                    break; 
                }
            }
            while (color == "0")
            {
                if (stop)
                {
                    found = true;
                    break;
                }
                x--;
                color = getpixel.GrabPixel(x, y);
                if (color != "0")
                {
                    break;
                }
            }
            x++;
            if (stop == false)
            {                
                Setting.BattleX = x;
                Setting.BattleY = y;
                Setting.TargetX = x;
                Setting.TargetY = y;
                Setting.TargetX2 = x;
                Setting.TargetY2 = y;
            }
            else
            {
                MessageBox.Show("Barra de HP não encontrada!");
            }
            return found;
        }
        public static void Atacar()
        {
            while (true)
            {
                if (Setting.PlayerOnScreen == true) { Thread.CurrentThread.Abort(); }
                bool targeting = Verificacoes.Targetando();
                if (targeting == false)
                {
                    win32.LeftClick(Setting.BattleX, Setting.BattleY);
                    if (Setting.tries < 7)
                    {
                        if (Setting.Pescar == 1)
                        {
                            Setting.tries++;
                        }                        
                    }
                    else { Setting.PlayerOnScreen = true; }
                    
                }
                Thread.Sleep(300);
                if (targeting == true)
                {
                    Setting.tries = 0;
                    Moves();
                }
                if (Verificacoes.PokeVivo() == false) break;
            }
        }
        static void Moves()
        {
            while (true)
            {
                if (Setting.PlayerOnScreen == true) { Thread.CurrentThread.Abort(); }
                Setting.attacktime = 350;
                Verificacoes.Targetar();
                if (Verificacoes.PokeVivo() == false) { break; }
                if (Setting.m1 == 1) { win32.SendKeys(Keys.F1); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m2 == 1) { win32.SendKeys(Keys.F2); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m3 == 1) { win32.SendKeys(Keys.F3); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m4 == 1) { win32.SendKeys(Keys.F4); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m5 == 1) { win32.SendKeys(Keys.F5); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m6 == 1) { win32.SendKeys(Keys.F6); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m7 == 1) { win32.SendKeys(Keys.F7); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m8 == 1) { win32.SendKeys(Keys.F8); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m9 == 1) { win32.SendKeys(Keys.F9); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                Verificacoes.Targetar();
                if (Setting.m10 == 1) { win32.SendKeys(Keys.F10); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
            }
        }
    }
}
