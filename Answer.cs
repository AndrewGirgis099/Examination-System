using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public Answer()
        {

        }
        public Answer(int _Id , string _AnswerText)
        {
            Id = _Id;
            AnswerText = _AnswerText;
        }

     
        public override string ToString()
        {
            return $"{Id}. {AnswerText}";
        }
    }
}
