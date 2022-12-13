
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();

            button1.Click += type;
            button2.Click += type;
            button3.Click += type;
            button4.Click += type;

            this.MouseUp += Form1_MouseUp;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
        }


        bool isClick = false;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isClick)
            {
                var g = CreateGraphics();
                SolidBrush s = new SolidBrush(Color.Cyan);
                g.FillEllipse(s, e.X, e.Y, 5, 5);

            }
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isClick = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isClick = false;
        }


        // object s =  button1; // upcasting 
        private void type(object s, EventArgs e)
        {
           // s.Text;

            Button btn = (Button) s; // downcasting 

            textBox1.Text += btn.Text;


            //if (s == button1)
            //{
            //    textBox1.Text += "1";
            //}
            //if (s == button2)
            //{
            //    textBox1.Text += "2";
            //}
            //if (s == button4)
            //{
            //    textBox1.Text += "3";
            //}
            //if (s == button3)
            //{
            //    textBox1.Text += "4";
            //}
        }
    }
}
