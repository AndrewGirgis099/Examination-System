using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSol_
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int _Id , string _Name)
        {
            Id = _Id ;
            Name = _Name ;
        }

        public void CreatExam()
        {
            int examType, time, noOfQuestion;
            do
            {
                Console.WriteLine("Choose Type Of Exam (1 for Practical || 2 For Final)");

            } while (!int.TryParse(Console.ReadLine(),out examType)&&(examType<1 || examType>2));
            do
            {
                Console.WriteLine("Please Enter Duration Of Exam : ");
            } while (!int.TryParse(Console.ReadLine(),out time) && time < 1);
            do
            {
                Console.WriteLine("Please Enter Number Of Question");
            } while (!int.TryParse(Console.ReadLine(),out noOfQuestion)&& noOfQuestion<1);

            if(examType == 1)
            {
                SubjectExam = new PracticalExam(time , noOfQuestion);
            }
            else if(examType==2)
            {
                SubjectExam=new FinalExam(time , noOfQuestion);
            }
            Console.Clear();
            SubjectExam.CreeatQuestionList();


        }

        public void ShowExam()
        {
            SubjectExam.ShowExam();
        }
    }
}
