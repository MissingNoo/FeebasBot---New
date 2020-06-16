using FeebasBot.Classes.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Chat
    {
        static bool show = false;
        public static void ChatCoords(int x, int y)
        {            
            #region left
            string color = getpixel.GrabPixel(x, y);
            int xn = x;
            int yn = y;
            int maxdiff = 100;
            while (true)
            {
                xn--;
                color = getpixel.GrabPixel(xn, yn);
                if (xn == xn - maxdiff) { MessageBox.Show("Cor não encontrada!"); break; }
                if (color == "5003617") break;
                if (color == "5922662") break;
            }
            Setting.ChatEsquerdaX = xn;
            #endregion

            #region right
            xn = x;
            yn = y;
            maxdiff = 100;
            while (true)
            {
                xn++;
                color = getpixel.GrabPixel(xn, yn);
                if (xn == xn + maxdiff) { MessageBox.Show("Cor não encontrada!"); break; }
                if (color == "5003617") break;
                if (color == "5922662") break;
            }
            Setting.ChatDireitaX = xn;
            #endregion
        }
        public static void CheckChat()
        {
            show = false;
            for (int i = Setting.ChatEsquerdaX; i < Setting.ChatDireitaX; i++)
            {
                string color = getpixel.GrabPixel(i, Setting.ChatY);
                if (color == "5592575" && show == false)
                {
                    FormsV.playSound("chat.wav");
                    show = true;
                }
            }
            if (show == true && Setting.ChatStop == 1)
            {
                Setting.Kill = true;
            }
        }
    }
}
