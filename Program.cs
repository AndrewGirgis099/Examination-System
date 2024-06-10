namespace ExamSol_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(1, "C#");
            sub.CreatExam();
            Console.Clear();
            char choice;
            do
            {
                Console.WriteLine("Do You Want To Start Exam");
            } while (!char.TryParse(Console.ReadLine().ToLower(),out choice) && choice !='y' && choice !='n');
            if(choice == 'y')
            {
                sub.ShowExam();
            }
            else if(choice =='n')
            {
                Console.WriteLine("Thank You ");
            }
        }
    }
}
