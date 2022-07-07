using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmuLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] runningProcesses = Process.GetProcessesByName("EmuLauncher");
            if (runningProcesses != null)
            {
                foreach (Process process in runningProcesses)
                {
                    if (process.Id != Process.GetCurrentProcess().Id)
                    {
                        //MessageBox.Show("Emu Launcher is already running.", "Emu Launcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        IntPtr windowHandle = process.MainWindowHandle;
                        if (windowHandle == (IntPtr)0)
                        {
                            EmuSettings settings = EmuLauncherForm.LoadSettings();
                            foreach (ProcessThread thread in Process.GetProcessById(process.Id).Threads)
                            {
                                NativeMethods.EnumThreadWindows(thread.Id, (hWnd, lParam) =>
                                {
                                    string title = NativeMethods.GetWindowText(hWnd);
                                    if (title.Equals(settings.LauncherName ?? "Emu Launcher"))
                                    {
                                        windowHandle = hWnd;
                                        return false;
                                    }
                                    return true;
                                }, IntPtr.Zero);
                            }
                        }
                        if (windowHandle != (IntPtr)0)
                        {
                            WINDOWPLACEMENT windowState = new WINDOWPLACEMENT();
                            NativeMethods.GetWindowPlacement(windowHandle, ref windowState);
                            if (windowState.showCmd == ShowWindowCommands.Hide || windowState.showCmd == ShowWindowCommands.Minimized)
                            {
                                NativeMethods.ShowWindowAsync(windowHandle, ShowWindowFlags.SW_RESTORE);
                            }
                            NativeMethods.ShowWindowAsync(windowHandle, ShowWindowFlags.SW_SHOW);
                            NativeMethods.SetForegroundWindow(windowHandle);
                            NativeMethods.SetFocus(windowHandle);
                            return;
                        }
                    }
                }
            }
            Application.Run(new EmuLauncherForm());
        }
    }
}
