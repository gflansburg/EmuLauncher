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
    public partial class EmulatorForm : Form
    {
        public Point? EmulatorLocation { get; set; }

        public EmulatorForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            if (!string.IsNullOrEmpty(tbPath.Text) && System.IO.File.Exists(tbPath.Text))
            {
                openFileDialog1.FileName = tbPath.Text;
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(tbPath.Text);
            }
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.gif;*.bmp|Jpeg Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            if (!string.IsNullOrEmpty(tbIcon.Text) && System.IO.File.Exists(tbIcon.Text))
            {
                openFileDialog1.FileName = tbIcon.Text;
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(tbIcon.Text);
            }
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbIcon.Text = openFileDialog1.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            EmuItem.Name = tbName.Text;
            EmuItem.Path = tbPath.Text;
            EmuItem.Icon = tbIcon.Text;
            EmuItem.Args = tbArgs.Text;
            EmulatorLocation = this.Location;
            this.Close();
        }

        public EmuItem EmuItem { get; set; }

        private void Emulator_Load(object sender, EventArgs e)
        {
            if (EmulatorLocation.HasValue && EmuLauncherForm.IsLocationVisible(EmulatorLocation.Value))
            {
                this.Location = EmulatorLocation.Value;
            }
            tbName.Text = EmuItem.Name;
            tbPath.Text = EmuItem.Path;
            tbIcon.Text = EmuItem.Icon;
            tbArgs.Text = EmuItem.Args;
        }
    }
}
