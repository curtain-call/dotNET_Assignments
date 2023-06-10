namespace databinding
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户姓名";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "customename", true));
            this.textBox1.Location = new System.Drawing.Point(108, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(program1.Order);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "商品名称";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "goodsname", true));
            this.textBox2.Location = new System.Drawing.Point(64, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 1;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(program1.OrderDetails);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "商品数量";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource3, "goodsname", true));
            this.textBox3.Location = new System.Drawing.Point(64, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 1;
            // 
            // orderDetailsBindingSource3
            // 
            this.orderDetailsBindingSource3.DataSource = typeof(program1.OrderDetails);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "商品价格";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource4, "goodsname", true));
            this.textBox4.Location = new System.Drawing.Point(64, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 1;
            // 
            // orderDetailsBindingSource4
            // 
            this.orderDetailsBindingSource4.DataSource = typeof(program1.OrderDetails);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "提交订单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource1, "goodsnum", true));
            this.textBox5.Location = new System.Drawing.Point(207, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 1;
            // 
            // orderDetailsBindingSource1
            // 
            this.orderDetailsBindingSource1.DataSource = typeof(program1.OrderDetails);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource5, "goodsnum", true));
            this.textBox6.Location = new System.Drawing.Point(207, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 25);
            this.textBox6.TabIndex = 1;
            // 
            // orderDetailsBindingSource5
            // 
            this.orderDetailsBindingSource5.DataSource = typeof(program1.OrderDetails);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource6, "goodsnum", true));
            this.textBox7.Location = new System.Drawing.Point(207, 203);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 25);
            this.textBox7.TabIndex = 1;
            // 
            // orderDetailsBindingSource6
            // 
            this.orderDetailsBindingSource6.DataSource = typeof(program1.OrderDetails);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource2, "goodsprice", true));
            this.textBox8.Location = new System.Drawing.Point(340, 141);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 25);
            this.textBox8.TabIndex = 1;
            // 
            // orderDetailsBindingSource2
            // 
            this.orderDetailsBindingSource2.DataSource = typeof(program1.OrderDetails);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource7, "goodsprice", true));
            this.textBox9.Location = new System.Drawing.Point(340, 172);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 25);
            this.textBox9.TabIndex = 1;
            // 
            // orderDetailsBindingSource7
            // 
            this.orderDetailsBindingSource7.DataSource = typeof(program1.OrderDetails);
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource8, "goodsprice", true));
            this.textBox10.Location = new System.Drawing.Point(340, 203);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 25);
            this.textBox10.TabIndex = 1;
            // 
            // orderDetailsBindingSource8
            // 
            this.orderDetailsBindingSource8.DataSource = typeof(program1.OrderDetails);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "3";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "ordernum", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(108, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(program1.Order);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 343);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource3;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource4;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource5;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource6;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource2;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource7;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource8;
    }
}