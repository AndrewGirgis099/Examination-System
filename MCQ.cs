using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    internal class MCQ : Question
    {
        public override string Header { get => $"Choose (One Answer Question)"; }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Body Of Question");
            Body = Console.ReadLine() ?? "not found Qusetion";

            int mark;
            do
            {
                Console.WriteLine("Please Enter Mark Of Question");

            } while (!int.TryParse(Console.ReadLine() , out mark) && mark < 1);
            Mark = mark;

            // Choices of Question
            Console.WriteLine("The Choices of Question");
            AnswerList = new Answer[3];
            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"Please Enter Choices Number {i+1}");
                AnswerList[i] = new Answer(i + 1, Console.ReadLine() ?? "Not Choices");
            }

            // specify RightAnswer
            int rightAnswer;
            do
            {
                Console.WriteLine("Please Enter Right Answer (1 or 2 or 3)");
            } while (!int.TryParse(Console.ReadLine() , out rightAnswer) && (rightAnswer < 1 || rightAnswer > 3));

            RightAnswer = new Answer(AnswerList[rightAnswer-1].Id , AnswerList[rightAnswer-1].AnswerText);
        }
    }
}
