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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            ////הגדרת רשימה של פקדי שאלה אמריקאית
            //List<UserControl2> lstUc = new List<UserControl2>();
            ////רצים בלולאה על הרשימה ומוסיפים לתצוגה
            //foreach(var item in lstUc)
            //{
            //    this.Controls.Add(item);
            //}
            //UserControl2 uc2 = new UserControl2();
            //this.Controls.Add(uc2);
            //for(int i=0;i<9;i++)
            //{
            //    this.Controls.Add(new UserControl2());
            //}
            //UserControl1 uc1 = new UserControl1();
            //this.Controls.Add(uc1);
            int mark = 0;
            int cnt = 1;
            int UserPassword;
            Class1 bll = new Class1();
            public Form2(int userPassword)
            {
                InitializeComponent();
                UserPassword = userPassword;

            }

        private void Form2_Load(object sender, EventArgs e)
        {
            {
                if (!panel1.Controls.Contains(UserControl1.ucTop))
                {
                    panel1.Controls.Add(UserControl1.ucTop);
                    UserControl1.ucTop.BringToFront();
                }
                else
                {
                    UserControl1.ucTop.BringToFront();
                }
                cnt++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
            {
                if (cnt < 11)
                {
                    if (UserControl1.ucTop.getAnswer() > -1)
                    {
                        mark += UserControl1.ucTop.getAnswer();
                        label2.Text = mark.ToString();
                    }
                }
                else
                {
                    if (UserControl2.ucEnd.getAnswer() > -1)
                    {
                        mark += UserControl2.ucEnd.getAnswer();
                        label2.Text = mark.ToString();
                    }
                }
                if (cnt <= 9)
                {
                    UserControl1.ucTop = null;
                    if (!panel1.Controls.Contains(UserControl1.ucTop))
                    {
                        panel1.Controls.Add(UserControl1.ucTop);
                        UserControl1.ucTop.BringToFront();
                    }
                    else
                    {
                        UserControl1.ucTop.BringToFront();
                    }
                }
                else if (cnt <= 15)
                {
                panel1.Controls.Clear();
                    UserControl2.ucEnd = null;
                    if (!panel1.Controls.Contains(UserControl2.ucEnd))
                    {
                        panel1.Controls.Add(UserControl2.ucEnd);
                        UserControl2.ucEnd.BringToFront();
                    }
                    else
                    {
                        UserControl2.ucEnd.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("The test score is over" + " "+mark);
                    bll.save(UserPassword, mark);
                }
                cnt++;
            }
    }

      
}
