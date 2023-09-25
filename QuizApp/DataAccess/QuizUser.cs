using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataAccess
{
    public class QuizUser
    {
        public int Id { get; set; }
        public List<int> AnswersID { get; set; }
    }
}
