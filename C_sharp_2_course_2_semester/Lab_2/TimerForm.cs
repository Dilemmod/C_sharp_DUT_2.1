using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_Task_4
{
    public partial class TimerForm : Form
    {
        int w = 75;
        int h = 41;
        int counter = 0;
        Timer timer = new Timer();
        int i = 0;
        public TimerForm()
        {
            InitializeComponent();
            Text = " ";
            this.MouseMove += TimerForm_MouseMove;
            this.btn_Ok.MouseEnter += Btn_Ok_MouseEnter;

            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
            else
            {
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
        }

        private void Btn_Ok_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = this.btn_Ok.Location.X;
            int y = this.btn_Ok.Location.Y;
            int delta = rand.Next(50,100);
            x = (x < this.Size.Width/2 ? x -= delta : x += delta);
            y = (y < this.Size.Height / 2 ? y -= delta : y += delta);

            this.btn_Ok.Location = new System.Drawing.Point(x, y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (Text == " ")
            {
                Text = "Натисніть кнопку “Ок”!!!";
            }
            else if (Text == "Натисніть кнопку “Ок”!!!")
            {
                Text = " ";
            }
            if (i == 15)
            {
                timer.Stop();
            }

        }
        private void TimerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(btn_Ok.Size.Width<1|| btn_Ok.Size.Height <1)
                this.Text = "Кнопка “Ок” не може бути натиснута";
            float foreSize = btn_Ok.Font.Size;
            int bX = btn_Ok.Location.X;
            int bY = btn_Ok.Location.Y;
            int delta = 30;
            int speed = 2;
            bool b = false;
         
            bool XLimit = e.X > bX - delta && e.X < bX;
            bool YLimit = e.Y > bY - delta && e.Y < bY;
            bool XLimitPlusSize = e.X > bX - delta+100&& e.X < bX + 100;
            bool YLimitPlusSize = e.Y > bY - delta+50 && e.Y < bY + 50;
            bool XRev = e.X > bX && e.X < bX -delta +100;
            bool YRev = e.Y > bY && e.Y < bY -delta +50;
            if (XLimit&&YLimit)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX + speed, bY + speed);
                b = true;  counter++;
            }
            else if(XLimitPlusSize&&YLimitPlusSize)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX - speed, bY - speed);
                b = true; counter++;
            }
            else if(XLimit&&YLimitPlusSize)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX + speed, bY - speed);
                b = true; counter++;
            }
            else if(XLimitPlusSize&& YLimit)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX - speed, bY + speed);
                b = true; counter++;
            }
            else if(XRev&& YLimit)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX, bY + speed);
                b = true; counter++;
            }
            else if (XRev && YLimitPlusSize)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX, bY - speed);
                b = true; counter++;
            }
            else if (XLimitPlusSize && YRev)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX - speed, bY );
                b = true; counter++;
            }
            else if (XLimit && YRev)
            {
                this.btn_Ok.Location = new System.Drawing.Point(bX + speed, bY);
                b = true; counter++;
            }

            int x = this.btn_Ok.Location.X;
            int y = this.btn_Ok.Location.Y;
            //Кнопка біля краю форми
            delta = 150;
            if (btn_Ok.Location.X > this.Size.Width - 80)
                x -= delta;
            else if (btn_Ok.Location.Y > this.Size.Height - 80)
                y -= delta;
            else if (btn_Ok.Location.Y < 0)
                y += delta;
            else if (btn_Ok.Location.X < 0)
                x += delta;
            this.btn_Ok.Location = new System.Drawing.Point(x, y);
            //Зменшння розміру кнопки
            if (b&&counter%10==0)
            {
                if(btn_Ok.Size.Width > 10 || btn_Ok.Size.Height > 10)
                    this.btn_Ok.Font = new Font(btn_Ok.Font.FontFamily, foreSize -= (float)0.7);
                w -= 2;
                this.btn_Ok.Size = new System.Drawing.Size(w, --h);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
