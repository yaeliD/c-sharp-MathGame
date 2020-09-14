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
    public partial class UserControl2 : UserControl
    {
            private static UserControl2 _ucEnd;
            public static UserControl2 ucEnd
            {
                get
                {
                    if (_ucEnd == null)
                        _ucEnd = new UserControl2();
                    return _ucEnd;
                }
                set
                {
                    _ucEnd = null;
                }
            }
            public UserControl2()
            {
                InitializeComponent();
            }
            Questions q = new Questions();
            Class1 bll = new Class1();
            List<Answers> answers = new List<Answers>();
        private void UserControl2_Load(object sender, EventArgs e)
        {
            q = bll.end6();
            label3.Text = q.QuestionText;
            answers = bll.end6answers(q.ID);
            radioButton1.Text = answers[0].AnswerValue.ToString();
            radioButton2.Text = answers[1].AnswerValue.ToString();
            radioButton3.Text = answers[2].AnswerValue.ToString();
            radioButton4.Text = answers[3].AnswerValue.ToString();
        }
        public int getAnswer()
        {
            if (answers[0].ID == q.QuestionAnswer && radioButton1.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[1].ID == q.QuestionAnswer && radioButton2.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[2].ID == q.QuestionAnswer && radioButton3.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[3].ID == q.QuestionAnswer && radioButton4.Checked)
                return Convert.ToInt32(q.Percent);
            return 0;

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (getAnswer() > 0)
        //    {
        //        label2.Text += q.Percent.ToString();
        //        //יש לבצע חישוב של הציון
        //        staticclass.mark += getAnswer();
        //    }

        //    this.Hide();//הסתרה של הפקד - יציג את השאלה הבאה כיוון שהיא נמצאת תחת פקד זה
        //}
        //Class1 bl = new Class1();
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("mark:" + staticclass.mark);
        //    bl.save(Form1.up, staticclass.mark);
        //}
    }
}

