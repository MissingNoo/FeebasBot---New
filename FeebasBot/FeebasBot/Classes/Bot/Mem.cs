using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeebasBot.Classes.Bot
{
    class Mem
    {
        public static void Memory()
        {
            Process[] processes = Process.GetProcessesByName("otpdx");
            if (processes.Length > 0)
            {
                IntPtr BaseAddress = IntPtr.Zero;
                Process MYProc = processes[0];
                foreach (ProcessModule module in MYProc.Modules)
                {
                    if (module.ModuleName.Contains("otpdx"))
                    {
                        BaseAddress = module.BaseAddress;
                        //MessageBox.Show(BaseAddres.ToString());
                    }
                }

                if (BaseAddress != IntPtr.Zero)
                {
                    VAMemory memory = new VAMemory("otpdx");
                    //x-y
                    int finalAddress = memory.ReadInt32((IntPtr)BaseAddress + + 0x00384810);
                    Setting.chary = memory.ReadInt32((IntPtr)finalAddress + 0x84C);
                    Setting.charx = memory.ReadInt32((IntPtr)finalAddress + 0x848);
                    ////pokehp
                    //int PokeAddr = memory.ReadInt32((IntPtr)BaseAddress + +0x00384810);
                    //Setting.chary = memory.ReadInt32((IntPtr)PokeAddr + 0x84C);
                    //Setting.charx = memory.ReadInt32((IntPtr)PokeAddr + 0x848);
                    ////charhp
                    //int CharAddr= memory.ReadInt32((IntPtr)BaseAddress + +0x00384810);
                    //Setting.chary = memory.ReadInt32((IntPtr)CharAddr + 0x84C);
                    //Setting.charx = memory.ReadInt32((IntPtr)CharAddr + 0x848);
                }
            }
        }
    }
}
