using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossword
{
    public partial class Form1 : Form
    {
        public string configuration = "380 380, 0 0 3 V, 0 1 7 H, 6 0 3 V, 3 1 5 V, 0 5 3 V, 0 5 7 H, 6 5 3 V";
        public Form1()
        {
            string[] fields = configuration.Split(',');
            string[] parameters = fields[0].Split(' ');

            InitializeComponent();
            this.Width = Convert.ToInt32(parameters[0]) + 20;
            this.Height = Convert.ToInt32(parameters[1]) + 40;

            for (int i = 1; i < fields.Length; i++)
            {
                int j = 0;
                parameters = fields[i].Split(' ');
                if (parameters[0] == "") j++;
                FieldCreator(Convert.ToInt32(parameters[j]), Convert.ToInt32(parameters[j+1]), Convert.ToInt32(parameters[j+2]), Convert.ToChar(parameters[j+3]));
            }
        }
        public void FieldCreator(int x,int y,int l,char o)
        {
            x = x * 35;
            y = y * 35;
            x += 10;y += 10;
            for (int i = 0; i < l; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Font = new Font("Arial Black", 12F, FontStyle.Bold);
                textBox.Location = new Point(x, y);
                textBox.Margin = new Padding(2, 3, 2, 3);
                textBox.MaxLength = 1;
                textBox.RightToLeft = RightToLeft.Yes;
                textBox.Size = new Size(30, 30);
                textBox.TabIndex = 0;
                textBox.TextAlign = HorizontalAlignment.Center;
                this.Controls.Add(textBox);
                if (o == 'H')
                    x += 35;
                else if (o == 'V')
                    y += 35;
            }
        }
    }
}
