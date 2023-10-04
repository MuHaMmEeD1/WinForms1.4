using System;
using System.Drawing.Drawing2D;

// GraphicsPath path = new GraphicsPath();
//path.AddEllipse(0, 0, button1.Width, button1.Height);
//button1.Region = new Region(path);

namespace WinForms_C__LESSON_1._4
{
    public partial class Form1 : Form
    {
        private Thread colorChangingThread;

        private Random random;

        int sra = 0;


        bool y1 = true;
        bool y2 = false;
        bool y3 = false;
        bool y4 = false;
        bool y5 = false;
        bool y6 = false;
        bool y7 = false;
        bool y8 = false;
        bool y9 = false;







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            random = new Random();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            button1.Text = "";

            colorChangingThread = new Thread(ChangeBackgroundColorContinuously);
            colorChangingThread.Start();


        }

        private void ChangeBackgroundColorContinuously()
        {
            

            while (true)
            {

                button1.Invoke((Action)(() =>
                {
                    button1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b2.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b3.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b4.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b5.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b6.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b7.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b8.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    b9.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                    if (b1.Location.Y < 500 && y1) { b1.Visible = true; b1.Location = new Point(b1.Location.X, b1.Location.Y + 20); }else { b1.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b2.Location.Y < 500 && y2) { b2.Visible = true; b2.Location = new Point(b2.Location.X, b2.Location.Y + 20); }else { b2.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b3.Location.Y < 500 && y3) { b3.Visible = true; b3.Location = new Point(b3.Location.X, b3.Location.Y + 20); }else { b3.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b4.Location.Y < 500 && y4) { b4.Visible = true; b4.Location = new Point(b4.Location.X, b4.Location.Y + 20); }else { b4.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b5.Location.Y < 500 && y5) { b5.Visible = true; b5.Location = new Point(b5.Location.X, b5.Location.Y + 20); }else { b5.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b6.Location.Y < 500 && y6) { b6.Visible = true; b6.Location = new Point(b6.Location.X, b6.Location.Y + 20); }else { b6.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b7.Location.Y < 500 && y7) { b7.Visible = true; b7.Location = new Point(b7.Location.X, b7.Location.Y + 20); }else { b7.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b8.Location.Y < 500 && y8) { b8.Visible = true; b8.Location = new Point(b8.Location.X, b8.Location.Y + 20); }else { b8.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }
                    if (b9.Location.Y < 500 && y9) { b9.Visible = true; b9.Location = new Point(b9.Location.X, b9.Location.Y + 20); }else { b9.Location = new Point(button1.Location.X + random.Next(80), button1.Location.Y+15); }










                    sra++;

                    if (sra == 10) { y2 = true; }
                    else if (sra == 20) { y3 = true; }
                    else if (sra == 30) { y4 = true; }
                    else if (sra == 40) { y5 = true; }
                    else if (sra == 50) { y6 = true; }
                    else if (sra == 60) { y7 = true; }
                    else if (sra == 70) { y8 = true; }
                    else if (sra == 80) { y9 = true; }
                  
                   
                        



                }));




                Thread.Sleep(100);
            };


        }
    }



}
