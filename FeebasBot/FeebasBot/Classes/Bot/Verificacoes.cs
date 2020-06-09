using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(color == "0")
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
            string px = getpixel.GrabPixel(Setting.TargetX, Setting.TargetY);
            string px2 = getpixel.GrabPixel(Setting.TargetX2, Setting.TargetY2);
            if (px == "8947967" || px == "255")
            {
                found = true;
            }
            if (px2 == "8947967" || px2 == "255")
            {
                found = true;
            }
            return found;
        }
    }
}
