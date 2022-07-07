using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmuLauncher
{
    public partial class OptionsForm : Form
    {
        public bool MinimizeToSystemTray { get; set; }
        public bool MinimizeOnLaunch { get; set; }
        public bool StartMinimized { get; set; }
        public bool StartWithWindows { get; set; }
        public string LauncherName { get; set; }
        public Point? OptionsLocation { get; set; }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (OptionsLocation.HasValue && EmuLauncherForm.IsLocationVisible(OptionsLocation.Value))
            {
                this.Location = OptionsLocation.Value;
            }
            cbMinimizeToSystemTray.Checked = MinimizeToSystemTray;
            cbMinimizeOnLaunch.Checked = MinimizeOnLaunch;
            cbStartMinimized.Checked = StartMinimized;
            cbStartWithWindows.Checked = StartWithWindows;
            tbLauncherName.Text = LauncherName ?? "Emu Launcher";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MinimizeToSystemTray = cbMinimizeToSystemTray.Checked;
            MinimizeOnLaunch = cbMinimizeOnLaunch.Checked;
            StartMinimized = cbStartMinimized.Checked;
            StartWithWindows = cbStartWithWindows.Checked;
            LauncherName = tbLauncherName.Text;
            OptionsLocation = this.Location;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
