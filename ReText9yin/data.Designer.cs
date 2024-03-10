namespace ReText9yin
{
    partial class data
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
            dataGridView1 = new DataGridView();
            selectFile = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            selectFile.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 191);
            dataGridView1.TabIndex = 8;
            // 
            // selectFile
            // 
            selectFile.Controls.Add(button1);
            selectFile.Controls.Add(button2);
            selectFile.Location = new Point(7, 31);
            selectFile.Name = "selectFile";
            selectFile.Size = new Size(781, 69);
            selectFile.TabIndex = 7;
            selectFile.TabStop = false;
            selectFile.Text = "เลือกไฟล์ที่ต้องการแทนที่ข้อความ";
            // 
            // button1
            // 
            button1.Location = new Point(704, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ไฟล์ปลายทาง";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(704, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "ไฟล์ต้นทาง";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(7, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 234);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการข้อมูล";
            // 
            // button3
            // 
            button3.Location = new Point(702, 374);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "คำนวน";
            button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(7, 374);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(683, 23);
            progressBar1.TabIndex = 10;
            // 
            // data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(selectFile);
            Name = "data";
            Text = "data";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            selectFile.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox selectFile;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private ProgressBar progressBar1;
    }
}