using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
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
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey(@"Software\Settings");
            if (subKey == null) return false;
            try
            {
                // Читаем данные и конвертируем в нужный формат.
                this.Location = new Point(Convert.ToInt32(subKey.GetValue("Location.X")), Convert.ToInt32(subKey.GetValue("Location.Y")));
                this.Height = Convert.ToInt32(subKey.GetValue("Height"));
                this.Width = Convert.ToInt32(subKey.GetValue("Width"));
                this.checkBox1.Checked = Convert.ToBoolean(subKey.GetValue("checkBox1.Checked"));
                this.checkBox2.Checked = Convert.ToBoolean(subKey.GetValue("checkBox2.Checked"));
                this.textBox1.Text = subKey.GetValue("textBox1.Text") as string;
                subKey.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        private void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey("Software", true);
            //Создает новый подраздел или открывает существующий для доступа на запись.
            RegistryKey subSubKey = subKey.CreateSubKey(@"Settings");

            // Совершаем запись в реестр.
            subSubKey.SetValue("Location.X", this.Location.X);
            subSubKey.SetValue("Location.Y", this.Location.Y);
            subSubKey.SetValue("Height", this.Height);
            subSubKey.SetValue("Width", this.Width);
            subSubKey.SetValue("checkBox1.Checked", this.checkBox1.Checked);
            subSubKey.SetValue("checkBox2.Checked", this.checkBox2.Checked);
            subSubKey.SetValue("textBox1.Text", this.textBox1.Text);

            subKey.Close();
            subSubKey.Close();
        }
    }
}
