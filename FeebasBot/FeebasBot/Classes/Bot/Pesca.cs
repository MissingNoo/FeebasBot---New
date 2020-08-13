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
            int dir = 8;
            #region random
            Random rnd = new Random();
            if (Setting.randomfish == 1)
            {
                dir = rnd.Next(0, 8);
            }
            else
            {
                dir = 8;
            }

            int wx = Setting.WaterX, wy = Setting.WaterY;
            switch (dir)
            {
                case 0:
                    wx = wx + 64; //direita
                    break;
                case 1:
                    wx = wx - 64; //esquerda
                    break;
                case 2:
                    wy = wy + 64; // baixo
                    break;
                case 3:
                    wy = wy - 64; //cima
                    break;
                case 4:
                    wx = wx + 64; //direita
                    wy = wy + 64; // baixo
                    break;
                case 5:
                    wx = wx - 64; //esquerda
                    wy = wy + 64; // baixo
                    break;
                case 6:
                    wx = wx + 64; //direita
                    wy = wy - 64; //cima
                    break;
                case 7:
                    wx = wx - 64; //esquerda
                    wy = wy - 64; //cima
                    break;
                case 8:
                    break;
            }
#endregion
            int time = 0;
            Chat.CheckChat();
            Thread.Sleep(500);
            bool pescou = false;
            if (Setting.PlayerOnScreen == true || Setting.Kill) { Thread.CurrentThread.Abort(); }
            Setting.clicklock = true;
            win32.LeftClickLocked(0, 0);
            win32.LeftClickOld(win32.FindWindow(null, Setting.GameName), Setting.RodX, Setting.RodY);//clicar na vara
            Thread.Sleep(200);
            win32.LeftClickOld(win32.FindWindow(null, Setting.GameName), wx, wy);//clicar na agua
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
            Chat.CheckChat();
            if (Setting.PlayerOnScreen == true || Setting.Kill) { Thread.CurrentThread.Abort(); }
            win32.LeftClick(Setting.FishX, Setting.FishY);
            win32.MoveMouse(0, 0);
            if (Setting.AtacarSemTarget == 1)
            { Ataque.MovesSemTarget(); }
            pescou = true;
            return pescou;
        }
    }
}
