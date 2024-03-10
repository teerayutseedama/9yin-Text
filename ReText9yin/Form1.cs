using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace ReText9yin
{

    public partial class Form1 : Form
    {
        public List<TextClass> FainalText = new List<TextClass>();
        public List<TextClass> FistText = new List<TextClass>();
        public List<TextClass> LastText = new List<TextClass>();
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void loadFile()
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(openFileDialog1.FileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;

                while ((line = streamReader.ReadLine()) != null)
                {

                    string[] str = line.Split("=");
                    TextClass text = new TextClass();
                    if (line != "" && line != "//")
                    {
                        if (str.Length > 1)
                        {
                            text.Neme = str[0];
                            text.Value = str[1];
                        }
                        else if (str.Length > 2)
                        {
                            text.Neme = str[0];
                            text.Value = str[1] + "=" + str[2];
                        }
                        else
                        {
                            text.Neme = str[0];
                        }

                        FistText.Add(text);
                    }
                    // progressBar1.Maximum = FistText.Count;

                }

            }

            using (var fileStream = File.OpenRead(openFileDialog2.FileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;

                while ((line = streamReader.ReadLine()) != null)
                {

                    string[] str = line.Split("=");
                    TextClass text = new TextClass();

                    if (str.Length > 1)
                    {
                        text.Neme = str[0];
                        text.Value = str[1];
                    }
                    else if (str.Length > 2)
                    {
                        text.Neme = str[0];
                        text.Value = str[1] + "=" + str[2];
                    }
                    else
                    {
                        text.Neme = str[0];
                    }
                    LastText.Add(text);

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        private void PopulateDataGridView()
        {
            MapText();
            // สร้าง DataTable เพื่อเก็บข้อมูล
            DataTable dt = new DataTable();

            // เพิ่มคอลัมน์ใน DataTable
            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            dt.Columns.Add("NewName");
            dt.Columns.Add("NewValue");
            // เพิ่มคอลัมน์ตามจำนวนคอลัมน์ใน DataList

            // เพิ่มข้อมูลจาก DataList ลงใน DataTable
            foreach (var item in FainalText)
            {
                DataRow row = dt.NewRow();
                row["Name"] = item.Neme; // ชื่อ Control และคอลัมน์ของข้อมูลที่ต้องการแสดง
                row["Value"] = item.Value; // ชื่อ Control และคอลัมน์ของข้อมูลที่ต้องการแสดง
                row["NewName"] = item.NewNeme; // ชื่อ Control และคอลัมน์ของข้อมูลที่ต้องการแสดง
                row["NewValue"] = item.NewValue;
                dt.Rows.Add(row);
            }

            // กำหนด DataTable ให้กับ DataGridView เพื่อแสดงข้อมูล
            // dataGridView1.DataSource = dt;
        }

        private void MapText()
        {
            int count = 0;
            foreach (var item in FistText)
            {
                var map = LastText.Find(x => x.Neme == item.Neme);
                if (map != null)
                {
                    TextClass text = new TextClass();
                    text.Value = item.Value;
                    text.Neme = item.Neme;
                    text.NewValue = map.Value;
                    text.NewNeme = map.Neme;
                    FainalText.Add(text);
                }
                count++;
                // progressBar1.Value = count;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadFile();
            PopulateDataGridView();
        }

        private void TestReText()
        {
            // เปิดไฟล์เพื่ออ่านข้อมูล
            using (StreamReader reader = new StreamReader("ชื่อไฟล์.txt"))
            {
                string line;
                string newText = "";

                // อ่านและค้นหาข้อความที่ต้องการแทนที่
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("ข้อความที่ต้องการค้นหา"))
                    {
                        // ทำการแทนที่ข้อความ
                        line = line.Replace("ข้อความที่ต้องการค้นหา", "ข้อความที่ต้องการแทนที่");
                    }
                    newText += line + Environment.NewLine;
                }

                // เปิดไฟล์เพื่อเขียนข้อมูลที่แก้ไขแล้ว
                using (StreamWriter writer = new StreamWriter("ชื่อไฟล์.txt"))
                {
                    writer.Write(newText);
                }
            }

            Console.WriteLine("เสร็จสิ้นการแก้ไขไฟล์");
        }

        private void จดการขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data newMDIChild = new data();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }
    }

    public class TextClass
    {
        public string Neme { get; set; }
        public string Value { get; set; }
        public string NewNeme { get; set; }
        public string NewValue { get; set; }
    }
}