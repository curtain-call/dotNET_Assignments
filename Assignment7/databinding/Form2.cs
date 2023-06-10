using program1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class Form2 : Form
    {
        public Order order;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<OrderDetails> od = new List<OrderDetails>();
            string aa1 = textBox2.Text;
            int aa2 = int.Parse(textBox5.Text);
            float aa3 = float.Parse(textBox8.Text);
            string ab1 = textBox3.Text;
            int ab2 = int.Parse(textBox6.Text);
            float ab3 = float.Parse(textBox9.Text);
            string ac1 = textBox4.Text;
            int ac2 = int.Parse(textBox7.Text);
            float ac3 = float.Parse(textBox10.Text);
            OrderDetails a1 = new OrderDetails(aa1, aa2, aa3);
            OrderDetails a2 = new OrderDetails(ab1, ab2, ab3);
            OrderDetails a3 = new OrderDetails(ac1, ac2, ac3);
            od.Add(a1);
            od.Add(a2);
            od.Add(a3);
            int numm = int.Parse(comboBox1.Text);
            string nammme = textBox1.Text;
             order = new Order(numm, nammme, od);
           
            this.Close();
        }
    }
}
