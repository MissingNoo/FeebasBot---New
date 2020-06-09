﻿using FeebasBot.Classes.Funcoes;
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
            Thread.Sleep(500);
            bool pescou = false;
            if (Setting.PlayerOnScreen == true) { Thread.CurrentThread.Abort(); }
            win32.LeftClick(0, 0);
            win32.LeftClick(Setting.RodX, Setting.RodY);//clicar na vara
            win32.LeftClick(Setting.WaterX, Setting.WaterY);//clicar na agua
            string startcolor = Verificacoes.FishColor();
            string colornow = Verificacoes.FishColor();
            while (colornow == startcolor)
            {
                colornow = Verificacoes.FishColor();
                Thread.Sleep(300);
            }
            win32.LeftClick(Setting.FishX, Setting.FishY);
            win32.MoveMouse(0, 0);
            pescou = true;
            return pescou;
        }
    }
}