using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    internal class TrueFalse : Question
    {
        public override string Header => $"True or False Question";


        public TrueFalse()
        {
            AnswerList = new Answer[2]
            {
                new Answer(1 , "True"),
                new Answer(2 , "False"),
            };
        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Body Of Question");
            Body = Console.ReadLine() ?? "No Question Found";

            int mark;
            do
            {
                Console.WriteLine("Please Enter Mark Of Question");

            } while (!int.TryParse(Console.ReadLine(), out mark) && mark < 1);
            Mark = mark;

            // specify RightAnswer
            int rightAnswer;
            do
            {
                Console.WriteLine("Please Enter Right Answer (1 or 2)");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer<1 || rightAnswer>2));

            RightAnswer = new Answer(AnswerList[rightAnswer - 1].Id, AnswerList[rightAnswer - 1].AnswerText);

        }
    }
}
