namespace GradeWeightAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double HOME_WORKS = 0.1;
            const double PROJECTS = 0.35;
            const double QUIZZES = 0.1;
            const double EXAMS = 0.3;
            const double FINAL_EXAMS = 0.15;
            /*
            int homeWorkScore = 97;
            int projectScore = 82;
            int quizzesScore = 60;
            int examsScore = 75;
            int finalExamsScore = 80;
            */

            int homeWorkScore = 90;
            int projectScore = 70;
            int quizzesScore = 75;
            int examsScore = 65;
            int finalExamsScore = 80;

            double totalGrade = (HOME_WORKS * homeWorkScore) + (PROJECTS * projectScore) + (QUIZZES * quizzesScore) + (EXAMS * examsScore) + (FINAL_EXAMS * finalExamsScore);

            Console.WriteLine("\tFINAL GRADE");
            Console.WriteLine("{0, -15}: {1:P0}{2, 5}", "Home Work", HOME_WORKS, homeWorkScore);
            Console.WriteLine("{0, -15}: {1:P0}{2, 5}", "Project", PROJECTS, projectScore);
            Console.WriteLine("{0, -15}: {1:P0}{2, 5}", "Quizzes", QUIZZES, quizzesScore);
            Console.WriteLine("{0, -15}: {1:P0}{2, 5}", "Exam", EXAMS, examsScore);
            Console.WriteLine("{0, -15}: {1:P0}{2, 5}", "Final Exam", FINAL_EXAMS, finalExamsScore);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("{0, -15}: \t{1:F2}", "Final Grade", totalGrade);

            Console.ReadKey();
        }
    }
}
