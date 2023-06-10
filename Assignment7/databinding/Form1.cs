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

    public partial class Form1 : Form
    {
        public List<Order> orderlist = new List<Order>();
        public BindingList<Order> Border;
        public Form1()
        {
            InitializeComponent();
            
            List<OrderDetails> od = new List<OrderDetails>();
            OrderDetails a1 = new OrderDetails("1", 2, 2);
            OrderDetails a2 = new OrderDetails("2", 2, 2);
            OrderDetails a3 = new OrderDetails("3", 2, 2);
            od.Add(a1);
            od.Add(a2);
            od.Add(a3);
            Order ood = new Order(1, "lala", od);
            orderlist.Add(ood);
             od = new List<OrderDetails>();
            OrderDetails b1 = new OrderDetails("4", 3, 3);
            OrderDetails b2 = new OrderDetails("5", 3, 3);
            OrderDetails b3 = new OrderDetails("6", 3, 3);
            od.Add(b1);
            od.Add(b2);
            od.Add(b3);
            ood= new Order(2, "lala2", od);
            orderlist.Add(ood);
            Border = new BindingList<Order>(orderlist);
            //bs.Add(orderlist);
            this.dataGridView1.DataSource = Border;

        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            orderlist.Add(form2.order);
            Border = new BindingList<Order>(orderlist);
            this.dataGridView1.DataSource = Border;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            //this.dataGridView1.DataSource = new List<Order>();
            List<Order> orderlist2 = orderlist.Where(s => s.ordernum == a).ToList<Order>();
            Border = new BindingList<Order>(orderlist2);
            this.dataGridView1.DataSource = Border;
            //bs.Add(orderlist);
            //dataGridView1.DataBindings.Add("ordernum", bs, "ordernum");
            //dataGridView1.DataBindings.Add("costomename", bs, "costomename");
            //dataGridView1.DataBindings.Add("totalmoney", bs, "totalmoney");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            for (int i = 0; i < orderlist.Count; i++)
            {
                if(a==orderlist[i].ordernum)
                {
                    orderlist.Remove(orderlist[i]);
                }
            }
            Border = new BindingList<Order>(orderlist);
            this.dataGridView1.DataSource = Border;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (a == orderlist[i].ordernum)
                {
                    orderlist.Remove(orderlist[i]);
                }
            }
            Form2 form2 = new Form2();
            form2.ShowDialog();
            orderlist.Add(form2.order);
            Border = new BindingList<Order>(orderlist);
            this.dataGridView1.DataSource = Border;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            Order orderr = new Order();
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (a == orderlist[i].ordernum)
                {
                    orderr=orderlist[i];
                }
            }
            this.dataGridView2.DataSource = orderr.detaillist;
        }
    }
}
