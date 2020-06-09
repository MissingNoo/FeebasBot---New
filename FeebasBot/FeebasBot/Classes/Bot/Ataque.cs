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
            bool vivo = Verificacoes.PokeVivo();
            while (vivo)
            {
                bool targeting = Verificacoes.Targetando();
                if (!targeting)
                {
                    win32.LeftClick(Setting.BattleX, Setting.BattleY);
                }
                Thread.Sleep(300);
                if (targeting)
                {
                    Moves();
                }
                vivo = Verificacoes.PokeVivo();
            }
        }
        static void Moves()
        {
            while (true)
            {
                Setting.attacktime = 350;
                if (Verificacoes.PokeVivo() == false) { break; }
                if (Setting.m1 == 1) { win32.SendKeys(Keys.F1); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m2 == 1) { win32.SendKeys(Keys.F2); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m3 == 1) { win32.SendKeys(Keys.F3); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m4 == 1) { win32.SendKeys(Keys.F4); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m5 == 1) { win32.SendKeys(Keys.F5); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m6 == 1) { win32.SendKeys(Keys.F6); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m7 == 1) { win32.SendKeys(Keys.F7); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m8 == 1) { win32.SendKeys(Keys.F8); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m9 == 1) { win32.SendKeys(Keys.F9); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
                if (Setting.m10 == 1) { win32.SendKeys(Keys.F10); }
                if (Verificacoes.PokeVivo() == false) { break; }
                Thread.Sleep(Setting.attacktime);
            }
        }
    }
}
