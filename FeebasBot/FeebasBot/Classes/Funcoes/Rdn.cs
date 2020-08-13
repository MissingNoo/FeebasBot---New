using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeebasBot.Classes.Funcoes
{
    class Rdn
    {
        public static int Radn()
        {
            int dir=0;
            Random rnd = new Random();
            dir = rnd.Next(0, 2);
            return dir;
        }
    }
}