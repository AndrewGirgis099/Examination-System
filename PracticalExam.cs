using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumberOfQuestion) : base(_Time, _NumberOfQuestion)
        {
        }

        public override void CreeatQuestionList()
        {
            QuestionList = new MCQ[NumberOfQuestion];
            for (int i = 0; i < QuestionList.Length; i++)
            {
                QuestionList[i] = new MCQ();
                QuestionList[i].AddQuestion();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            foreach(var Question in QuestionList)
            {
                Console.WriteLine(Question.ToString());
                foreach(var Answer in Question.AnswerList)
                {
                    Console.WriteLine(Answer.ToString());
                }

                int userAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Your Answer : ");
                } while (!int.TryParse(Console.ReadLine() , out userAnswerId) && userAnswerId<1 || userAnswerId>3);
                Question.UserAnswer=new Answer(userAnswerId , Question.AnswerList[userAnswerId-1].AnswerText);
            }
            Console.Clear();
            Console.WriteLine("Right Answer \n");
            foreach(var Question in QuestionList)
            {
                Console.WriteLine($"{Question.Body} ===> Right Answer = {Question.RightAnswer.AnswerText}");
            }
        }
    }
}
