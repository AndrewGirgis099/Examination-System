using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    public class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumberOfQuestion) : base(_Time, _NumberOfQuestion)
        {
        }

        public override void CreeatQuestionList()
        {
            QuestionList = new Question[3];
            for(int i = 0; i < QuestionList.LongLength; i++)
            {
                int questionType;
                do
                {
                    Console.WriteLine("1 for MCQ || 2 for True Or False");
                } while (!int.TryParse(Console.ReadLine(),out questionType) && (questionType<1 || questionType >2));
                Console.Clear();
                if(questionType==1)
                {
                    QuestionList[i]= new MCQ();
                    QuestionList[i].AddQuestion();
                }
                else if(questionType==2)
                {
                    QuestionList[i] = new TrueFalse();
                    QuestionList[i].AddQuestion();
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var Question in QuestionList)
            {
                Console.WriteLine(Question.ToString());
                foreach (var Answer in Question.AnswerList)
                {
                    Console.WriteLine(Answer.ToString());
                }

                int userAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out userAnswerId) && userAnswerId < 1 || userAnswerId > 3);
                Question.UserAnswer = new Answer(userAnswerId , Question.AnswerList[userAnswerId - 1].AnswerText);
            }
            Console.Clear();
            int TotalMark = 0, Grade = 0;
            foreach (var Question in QuestionList)
            {
                TotalMark += Question.Mark;
                if(Question.UserAnswer.Id == Question.RightAnswer.Id)
                {
                    Grade += Question.Mark;
                }

            }
            Console.WriteLine("Right Answer \n");
            foreach (var Question in QuestionList)
            {
                Console.WriteLine($"{Question.Body} ===> Right Answer = {Question.RightAnswer.AnswerText}" 
                    + $"User Answer = {Question.UserAnswer.AnswerText}");

                Console.WriteLine($"Student Grade = {Grade} / {TotalMark}");
            }
        }
    }
}
