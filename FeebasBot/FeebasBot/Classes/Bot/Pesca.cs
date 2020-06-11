using FeebasBot.Classes.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Pesca
    {
        public static bool Pescar()
        {
            int time = 0;
            Thread.Sleep(500);
            bool pescou = false;
            if (Setting.PlayerOnScreen == true || Setting.Kill) { Thread.CurrentThread.Abort(); }
            Setting.clicklock = true;
            win32.LeftClickLocked(0, 0);
            win32.LeftClickLocked(Setting.RodX, Setting.RodY);//clicar na vara
            Thread.Sleep(200);
            win32.LeftClickLocked(Setting.WaterX, Setting.WaterY);//clicar na agua
            Thread.Sleep(200);
            win32.LeftClickLocked(0, 0);
            Setting.clicklock = false;
            string startcolor = Verificacoes.FishColor();
            string colornow = Verificacoes.FishColor();
            while (colornow == startcolor)
            {
                if (Setting.PlayerOnScreen == true || Setting.Kill) { Thread.CurrentThread.Abort(); }
                Thread.Sleep(500);
                if (time < 20)
                {
                    //colornow = Convert.ToString(getpixel.GetPixel(getpixel.GetWindowDC(getpixel.GetDesktopWindow()), Setting.FishX, Setting.FishY));
                    colornow = Verificacoes.FishColor();
                    time++;
                }
                else
                {
                    colornow = "0";
                }
            }
            if (Setting.PlayerOnScreen == true || Setting.Kill) { Thread.CurrentThread.Abort(); }
            win32.LeftClick(Setting.FishX, Setting.FishY);
            win32.MoveMouse(0, 0);
            pescou = true;
            return pescou;
        }
    }
}
