using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace myp
{
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _ucTop;
        public static UserControl1 ucTop
        {
            get
            {
                if (_ucTop == null)
                    _ucTop = new UserControl1();
                return _ucTop;
            }
            set
            {
                _ucTop = null;
            }
        }
        public static int cnt = 1;
        Questions q = new Questions();
        public UserControl1()
        {
            InitializeComponent();
        }
        Class1 bl = new Class1();
 
        //אם התשובה נכונה
        public int getAnswer()
        { 
            if(textBox1.Text == "")
            {
                return 0;
            }
            if (q.QuestionAnswer == Convert.ToInt32(textBox1.Text))
                return Convert.ToInt32(q.Percent);
            return 0;
        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {
            if (cnt <= 5)
            {
                q = bl.top5();
                label3.Text = q.QuestionText;
            }
            else
            {
                q = bl.next4();
                label3.Text = q.QuestionText;
            }
            label4.Text = null;
            cnt++;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("mark:" + staticclass.mark);
        //    staticclass.mark = 0;
        //    Form2 f = new Form2();
        //    f.Close();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    staticclass.mark += getAnswer();

        //}
    }
}



