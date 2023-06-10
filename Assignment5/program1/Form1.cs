using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        static int kk1;//位置
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2, kk1);
        }
        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        Color col;
        float wid;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th, double k)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1, k);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2, k);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen p1 = new Pen(col, wid);
            graphics.DrawLine(
                p1,
                (int)x0, (int)y0, (int)x1, (int)y1);

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            kk1 = trackBar1.Value;
            textBox1.Text = trackBar1.Value.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int k2 = trackBar2.Value;
            double kk2 = (double)k2;
            per1 = kk2 / 10;
            textBox2.Text = per1.ToString();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int k3 = trackBar3.Value;
            double kk3 = (double)k3;
            per2 = kk3 / 10;
            textBox3.Text = per2.ToString();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int k4 = trackBar4.Value;
            int kk4 = k4 * 5;
            th1 = kk4 * Math.PI / 180;
            textBox4.Text = kk4.ToString();
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            int k5 = trackBar5.Value;
            int kk5 = k5 * 5;
            th2 = kk5 * Math.PI / 180;
            textBox5.Text = kk5.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色 
                Color colorChoosed = colorDia.Color;
                col = colorChoosed;
                textBox6.BackColor = col;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int R = new Random().Next(255);
            int G = new Random().Next(255);
            int B = new Random().Next(255);
            B = (R + G > 400) ? R + G - 400 : B;//0 : 380 - R - G;
            B = (B > 255) ? 255 : B;
            col = Color.FromArgb(R, G, B);
            textBox7.BackColor = col;
        }
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            int k6 = trackBar6.Value;
            wid = (float)k6;
            textBox8.Text = k6.ToString();
        }
    }
}

