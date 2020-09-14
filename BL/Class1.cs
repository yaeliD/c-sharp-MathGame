using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Class1
    {
        public bool GetUser(string name, string password)
        {


            using (var DB = new TestsDBnewEntities1())
            {
                //var cnt = DB.Users.Count(user => user.UserName.Equals(name));
                // if (cnt == 0 || cnt > 1)
                //     throw new Exception("ארעה שגיאה");
                // var pas = DB.Users.Count(user => user.Userpassword.Equals(password));
                // if ( pas.ToString()== password)
                //     throw new Exception("אחד הנתונים שהזנת שגויים");
                var answer = DB.Users.Where(x => x.UserName == name && x.Userpassword.ToString() == password).Select(x => x.UserName).Any();
                if (answer)
                    return true;
                else
                    return false;
            }
        }

        public Questions Score(string myq, string ans)
        {
            using (var DB = new TestsDBnewEntities1())
            {

                var myScore = DB.Users.Where(x => x.QuestionText == myq && x.QuestionAnswer == ans).Select(x => x.Percent).Any();
                // if (myScore)
                //return myScore;

            }
            return null;
        }

        public string tar()
        {
            using (var DB = new TestsDBnewEntities1())
            {

                //  var tarme = DB.Users.Where(x =>  { return Math.(x.QuestionText);  });
                return null;
            }
        }
    }
}
      
    