using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BAD_GRADE = 4;

            int badGrades = int.Parse(Console.ReadLine());

            int numberOfProblems = 0;
            double sumGrades = 0;
            int badGradesCounter = 0;
            string lastProblem = String.Empty;

            string problem = Console.ReadLine();

            while (problem != "Enough")
            {
                numberOfProblems++;
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                        break;
                    }
                }
                lastProblem = problem;
                problem = Console.ReadLine();
            }

            double averageScore = sumGrades / numberOfProblems;

            if (problem == "Enough")
            {
                Console.WriteLine($"Average score: {averageScore:f2}\nNumber of problems: {numberOfProblems}\nLast problem: {lastProblem}");
            }
        }
    }
}
