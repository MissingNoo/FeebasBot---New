using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Looting
    {
        static string lootcolor = null;
        static string lootcolornow = null;
        static int position = (Setting.SQMY - Setting.PlayerY);
        public static void AbrirCorpos()
        {
            if (Setting.PodeUsarLooting == 1 && Setting.Lootear == 1)
            {
                lootcolor = getpixel.GrabPixel(Setting.SlotX, Setting.SlotY);                
                Setting.clicklock = true;
                if (Setting.p1 == 1) { win32.RightClickLocked(Setting.SQMX - position - 16, Setting.SQMY - position * 2); VerificarLoot(); }
                if (Setting.p2 == 1) { win32.RightClickLocked(Setting.SQMX - 16, Setting.SQMY - position * 2); VerificarLoot(); }
                if (Setting.p3 == 1) { win32.RightClickLocked(Setting.SQMX + position - 16, Setting.SQMY - position * 2); VerificarLoot(); }
                if (Setting.p4 == 1) { win32.RightClickLocked(Setting.SQMX - position - 16, Setting.SQMY - position); VerificarLoot(); }
                if (Setting.p5 == 1) { win32.RightClickLocked(Setting.SQMX + position - 16, Setting.SQMY - position); VerificarLoot(); }
                if (Setting.p6 == 1) { win32.RightClickLocked(Setting.SQMX - position - 16, Setting.SQMY); VerificarLoot(); }
                if (Setting.p7 == 1) { win32.RightClickLocked(Setting.SQMX - 16, Setting.SQMY); VerificarLoot(); }
                if (Setting.p8 == 1) { win32.RightClickLocked(Setting.SQMX + position - 16, Setting.SQMY); VerificarLoot(); }
                if (Setting.PescarSemParar == 0 && Setting.UseHk == false) Posicionar();
                Setting.clicklock = false;
            }
        }
        public static void VerificarLoot()
        {
            Thread.Sleep(200);
            lootcolornow = getpixel.GrabPixel(Setting.SlotX, Setting.SlotY);
            if (lootcolornow != lootcolor)
            { PegarLoot(); }
        }
        public static void PegarLoot()
        {
            Thread.Sleep(100);
            win32.LeftClickLocked(Setting.SlotX, Setting.SlotY);
            Thread.Sleep(100);
            win32.LeftClickLocked(Setting.SlotX, Setting.SlotY);
            Thread.Sleep(100);
            win32.LeftClickLocked(Setting.SlotX, Setting.SlotY);
            win32.LeftClickLocked(Setting.CloseX, Setting.CloseY);
        }
        public static void Posicionar()
        {
            win32.LeftClickLocked(0,0);
            Thread.Sleep(100);
            win32.LeftClickLocked(Setting.OrderX, Setting.OrderY);
            Thread.Sleep(100);
            win32.LeftClickLocked(Setting.SQMX, Setting.SQMY - position * 2);
        }
    }
}
