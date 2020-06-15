using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Catch
    {
        static int position = (Setting.SQMBY - Setting.PlayerY);
        public static void JogarBall()
        {
            if (Setting.PodeCapturar == 1 && Setting.catchpoke == 1)
            {
                Setting.clicklock = true;
                win32.LeftClickLocked(0, 0);
                win32.RightClickLocked(Setting.pokeballX, Setting.pokeballY);
                Thread.Sleep(200);
                win32.LeftClickLocked(Setting.SQMBX, Setting.SQMBY);
                Thread.Sleep(1000);
                win32.RightClickLocked(Setting.pokeballX, Setting.pokeballY);
                Thread.Sleep(200);
                win32.LeftClickLocked(Setting.SQMBX - position, Setting.SQMBY);
                Thread.Sleep(1000);
                win32.RightClickLocked(Setting.pokeballX, Setting.pokeballY);
                Thread.Sleep(200);
                win32.LeftClickLocked(Setting.SQMBX + position, Setting.SQMBY);
                if (Setting.Lootear == 0)
                {
                    Thread.Sleep(300);
                    win32.LeftClickLocked(Setting.OrderX, Setting.OrderY);
                    Thread.Sleep(200);
                    win32.LeftClickLocked(Setting.SQMBX, Setting.SQMBY);
                    Thread.Sleep(300);
                }
                //if (Setting.PescarSemParar == 0) Posicionar();
                Setting.clicklock = false;
            }
        }
    }
}
