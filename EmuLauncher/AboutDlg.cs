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
    public partial class AboutDlg : Form
    {
        public Point? AboutLocation { get; set; }

        public AboutDlg()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            AboutLocation = this.Location;
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            if (AboutLocation.HasValue && EmuLauncherForm.IsLocationVisible(AboutLocation.Value))
            {
                this.Location = AboutLocation.Value;
            }
        }
    }
}
