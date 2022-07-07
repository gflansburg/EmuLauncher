
namespace EmuLauncher
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMinimizeOnLaunch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLauncherName = new System.Windows.Forms.TextBox();
            this.cbStartMinimized = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbMinimizeToSystemTray
            // 
            this.cbMinimizeToSystemTray.AutoSize = true;
            this.cbMinimizeToSystemTray.Location = new System.Drawing.Point(13, 13);
            this.cbMinimizeToSystemTray.Name = "cbMinimizeToSystemTray";
            this.cbMinimizeToSystemTray.Size = new System.Drawing.Size(139, 17);
            this.cbMinimizeToSystemTray.TabIndex = 0;
            this.cbMinimizeToSystemTray.Text = "&Minimize to System Tray";
            this.cbMinimizeToSystemTray.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(234, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(153, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMinimizeOnLaunch
            // 
            this.cbMinimizeOnLaunch.AutoSize = true;
            this.cbMinimizeOnLaunch.Location = new System.Drawing.Point(13, 36);
            this.cbMinimizeOnLaunch.Name = "cbMinimizeOnLaunch";
            this.cbMinimizeOnLaunch.Size = new System.Drawing.Size(120, 17);
            this.cbMinimizeOnLaunch.TabIndex = 3;
            this.cbMinimizeOnLaunch.Text = "Minimize on &Launch";
            this.cbMinimizeOnLaunch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Launcher Name:";
            // 
            // tbLauncherName
            // 
            this.tbLauncherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLauncherName.Location = new System.Drawing.Point(106, 105);
            this.tbLauncherName.Name = "tbLauncherName";
            this.tbLauncherName.Size = new System.Drawing.Size(203, 20);
            this.tbLauncherName.TabIndex = 5;
            // 
            // cbStartMinimized
            // 
            this.cbStartMinimized.AutoSize = true;
            this.cbStartMinimized.Location = new System.Drawing.Point(13, 59);
            this.cbStartMinimized.Name = "cbStartMinimized";
            this.cbStartMinimized.Size = new System.Drawing.Size(97, 17);
            this.cbStartMinimized.TabIndex = 6;
            this.cbStartMinimized.Text = "&Start Minimized";
            this.cbStartMinimized.UseVisualStyleBackColor = true;
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(13, 82);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(120, 17);
            this.cbStartWithWindows.TabIndex = 7;
            this.cbStartWithWindows.Text = "Start With &Windows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.cbStartWithWindows);
            this.Controls.Add(this.cbStartMinimized);
            this.Controls.Add(this.tbLauncherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMinimizeOnLaunch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbMinimizeToSystemTray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMinimizeToSystemTray;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbMinimizeOnLaunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLauncherName;
        private System.Windows.Forms.CheckBox cbStartMinimized;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
    }
}