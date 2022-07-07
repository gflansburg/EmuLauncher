using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmuLauncher
{
    public class EmuSettings
    {
        public EmuSettings()
        {
            Emulators = new List<EmuItem>();
        }

        public Size? Size { get; set; }
        
        public Point? Location { get; set; }

        public Point? AboutLocation { get; set; }

        public Point? OptionsLocation { get; set; }

        public Point? EmulatorLocation { get; set; }

        public bool StartWithWindows { get; set; }

        public bool StartMinimized { get; set; }

        public bool MinimizeToSystemTray { get; set; }

        public bool MinimizeOnLaunch { get; set; }

        public bool IsMaximized { get; set; }

        public string LauncherName { get; set; }

        public List<EmuItem> Emulators { get; set; }
    }
}
