using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_1_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                if (ReadSettings() == false)
                {
                    MessageBox.Show("У файлі немає інформації...");
                }
                else
                {
                    MessageBox.Show("Інформація успішно завантажена з файлу ...");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Виникла проблема при завантаженні даних з файлу :\n" + e.Message);
            }
        }

        private bool ReadSettings()
        {
            if (File.Exists(@"Settings.txt"))
            {
                FileStream file = File.Open(@"Settings.txt", FileMode.Open);
                BinaryReader reader = new BinaryReader(file);
                this.Location = new Point(reader.ReadInt32(), reader.ReadInt32());
                this.Height = reader.ReadInt32();
                this.Width = reader.ReadInt32();
                this.checkBox1.Checked = reader.ReadBoolean();
                this.checkBox2.Checked = reader.ReadBoolean();
                this.textBox1.Text = reader.ReadString();
                reader.Close();
                return true;
            }
            return false;
        }
        void SaveSettings()
        {
            FileStream file = File.Create(@"Settings.txt");
            var writer = new BinaryWriter(file);
            writer.Write(this.Location.X);
            writer.Write(this.Location.Y);
            writer.Write(this.Height);
            writer.Write(this.Width);
            writer.Write(this.checkBox1.Checked);
            writer.Write(this.checkBox2.Checked);
            writer.Write(this.textBox1.Text);
            writer.Close();
        }
    }
}
