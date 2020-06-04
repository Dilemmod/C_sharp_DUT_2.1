using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        Button plusMinus = new Button();
        Button clear = new Button();
        TextBox textBox1 = new TextBox();
        string example;
        string operations;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(240, 300);
            int x = -10;
            int y = 50;
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            textBox1.ForeColor = Color.GhostWhite;
            textBox1.Location = new Point(x + 40, y - 40);
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 30);
            textBox1.TextAlign = HorizontalAlignment.Right;
            this.Controls.Add(textBox1);

            int num = 9;
            string[] oper = new string[5] { "Nul", "/", "*", "-", "+" };
            string[] other = new string[4] { "NuL", "=", ",", "0" };
            string[] delete = new string[4] { "<-", "C", "+-", "V" };
            //Вертикаль
            for (int i = 0; i < 5; i++)
            {
                //Горизонталь
                for (int j = 4; j > 0; j--)
                {
                    Button b = new Button();
                    b.Visible = true;
                    b.Size = new Size(40, 30);
                    b.Location = new Point(x + j * 40, y + 40 * i);
                    b.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
                    b.MouseClick += Button_MouseClick;
                    //Стирание и корень
                    if (i == 0)
                    {
                        b.Text = delete[j - 1];
                    }
                    //Операции
                    else if (j == 4)
                    {
                        b.Text = oper[i];
                    }
                    else if (i == 4)
                    {
                        b.Text = other[j];
                    }
                    else
                    {
                        b.Text = (num--).ToString();
                    }
                    this.Controls.Add(b);

                }
            }
        }


        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            Button b;
            b = (sender as Button);

            if (textBox1.Text != "")
            {
                switch (b.Text)
                {
                    case "=":
                        example += textBox1.Text + " ";
                        if (operations != null)
                            Equals();
                        break;
                    case "*":
                        example += textBox1.Text + " ";
                        operations += "* ";
                        textBox1.Text = "";
                        break;
                    case "/":
                        example += textBox1.Text + " ";
                        operations += "/ ";
                        textBox1.Text = "";
                        break;
                    case "-":
                        example += textBox1.Text + " ";
                        operations += "- ";
                        textBox1.Text = "";
                        break;
                    case "+":
                        example += textBox1.Text + " ";
                        operations += "+ ";
                        textBox1.Text = "";
                        break;
                    case "V":
                        if (Convert.ToDouble(textBox1.Text) > 0)
                            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
                        break;
                    case "+-":
                        textBox1.Text = (Convert.ToDouble(textBox1.Text) * -1).ToString();
                        break;
                    case "<-":
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        break;
                    case "C":
                        textBox1.Text = "";
                        break;
                    case ",":
                        if (textBox1.Text.IndexOf(",") == -1)
                            textBox1.Text += ",";
                        break;
                    default:
                        textBox1.Text += b.Text;
                        break;
                }
            }
            else
            {
                switch (b.Text)
                {
                    case "V":
                    case "+-":
                    case "=":
                    case "*":
                    case "/":
                    case "-":
                    case "+":
                    case "<-":
                    case "C":
                        break;
                    case ",":
                        if (textBox1.Text.IndexOf(",") == -1)
                            textBox1.Text = "0,";
                        break;
                    default:
                        textBox1.Text += b.Text;
                        break;
                }
            }
        }

        private void Equals()
        {
            string[] exampleArrey = example.Split(' ');
            string[] operationsArrey = operations.Split(' ');
            double result = 0;
            for (int i = 0; i < exampleArrey.Length - 1; i++)
            {
                if (i == 0)
                    result = Convert.ToDouble(exampleArrey[i]);
                switch (operationsArrey[i])
                {
                    case "+":
                        result = (result + Convert.ToDouble(exampleArrey[i + 1]));
                        break;
                    case "-":
                        result = (result - Convert.ToDouble(exampleArrey[i + 1]));
                        break;
                    case "/":
                        result = (result / Convert.ToDouble(exampleArrey[i + 1]));
                        break;
                    case "*":
                        result = (result * Convert.ToDouble(exampleArrey[i + 1]));
                        break;

                }
            }
            textBox1.Text = result.ToString();
            example = "";
            operations = "";
        }
    }
}
