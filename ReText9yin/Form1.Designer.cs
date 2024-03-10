namespace ReText9yin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            process1 = new System.Diagnostics.Process();
            menuStrip1 = new MenuStrip();
            สงออกขอมลToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            process1.Exited += process1_Exited;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { สงออกขอมลToolStripMenuItem, จดการขอมลToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // สงออกขอมลToolStripMenuItem
            // 
            สงออกขอมลToolStripMenuItem.Name = "สงออกขอมลToolStripMenuItem";
            สงออกขอมลToolStripMenuItem.Size = new Size(75, 20);
            สงออกขอมลToolStripMenuItem.Text = "ส่งออกข้อมูล";
            // 
            // จดการขอมลToolStripMenuItem
            // 
            จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            จดการขอมลToolStripMenuItem.Size = new Size(75, 20);
            จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            จดการขอมลToolStripMenuItem.Click += จดการขอมลToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private System.Diagnostics.Process process1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem สงออกขอมลToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลToolStripMenuItem;
    }
}