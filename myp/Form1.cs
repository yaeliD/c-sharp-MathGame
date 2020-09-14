using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using myp;


namespace myp
{

    public partial class Form1 : Form
    {
        public static string up;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 bl = new Class1();
            if (bl.GetUser(textBox1.Text, textBox2.Text))
               {
                up =textBox2.Text;
                MessageBox.Show("שלום לך!!");
                Form2 f = new Form2();
                f.Show();
                staticclass.mark = 0;
            }
            else
            {
                MessageBox.Show("לא תקין");
            }
        }
    }
}


