using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] QuestionList { get; set; }

        public Exam(int _Time , int _NumberOfQuestion )
        {
            Time= _Time;
            NumberOfQuestion= _NumberOfQuestion;
        }

        public abstract void CreeatQuestionList();
        public abstract void ShowExam();

       
    }
}
