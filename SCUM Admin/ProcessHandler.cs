using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace SCUM_Admin
{
    class ProcessHandler
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public bool setForground()
        {
            Process[] procs = Process.GetProcessesByName("SCUM");

            if (procs.Length > 0)
            {
                if (procs[0].MainWindowHandle != IntPtr.Zero)
                {
                    SetForegroundWindow(procs[0].MainWindowHandle);
                    return true;
                }
                return false;
            }
            else
            {
                MessageBox.Show("Process not found. Please start SCUM.", "Nononononono!");
                return false;
            }
        }

        public void SpawnItem(string item, int amount)
        {
            SendKeys.SendWait("t");
            Thread.Sleep(50);
            SendKeys.SendWait("#spawnitem " + item + " " + amount);
            Thread.Sleep(50);
            SendKeys.SendWait("{enter}{escape}");
        }

        public void SpawnNpc(string npc, int amount)
        {
            SendKeys.SendWait("t");
            Thread.Sleep(50);
            SendKeys.SendWait("#spawncharacter " + npc + " " + amount);
            Thread.Sleep(50);
            SendKeys.SendWait("{enter}{escape}");
        }

        public void Teleport(string steamID, string x, string y, string z)
        {
            SendKeys.SendWait("t");
            Thread.Sleep(50);
            SendKeys.SendWait("#teleport " + steamID + " " + x + " " + y + " " + z);
            Thread.Sleep(50);
            SendKeys.SendWait("{enter}{escape}");
        }
    }
}
