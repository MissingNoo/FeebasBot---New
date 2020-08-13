using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Funcoes
{
    class Verificacoes
    {
        public static string FishColor()
        {
            return getpixel.GrabPixel(Setting.FishX, Setting.FishY);
        }
        public static string BattleColor()
        {
            return getpixel.GrabPixel(Setting.BattleX, Setting.BattleY);
        }
        public static bool PokeVivo()
        {
            string color = BattleColor();
            if (color == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Targetando()
        {
            bool found = false;
            for (int a = Setting.TargetY2; a <= Setting.TargetY; a++)
            {
                string px = getpixel.GrabPixel(Setting.TargetX, a);
                if (px == "8947967" || px == "255")
                {
                    Setting.IsTargeting = 1;
                    found = true;
                    break;
                }
            }
            if (found == false) { Setting.IsTargeting = 0; }
            return found;
        }
        public static void Targetar()
        {
            bool target = Targetando();
            bool vivo = PokeVivo();
            if (target == false && vivo == true && Setting.clicklock == false)
            {
                win32.LeftClick(Setting.BattleX, Setting.BattleY);
                if (Setting.tries < Setting.triestotal)
                {
                    if (Setting.Pescar == 1)
                    {
                        Setting.tries++;
                    }
                }
                else { Setting.PlayerOnScreen = true; }
            }
        }
    }
}
