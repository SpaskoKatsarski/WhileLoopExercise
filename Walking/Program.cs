using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int STEPS_GOAL = 10000;

            string input = Console.ReadLine();

            int sumSteps = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                sumSteps += steps;

                if (sumSteps >= STEPS_GOAL)
                {
                    int stepsMore = sumSteps - STEPS_GOAL;
                    Console.WriteLine($"Goal reached! Good job!\n{stepsMore} steps over the goal!");
                    return;
                }
                input = Console.ReadLine();
            }
            int stepsToHome = int.Parse(Console.ReadLine());
            sumSteps += stepsToHome;
            int difference = Math.Abs(sumSteps - STEPS_GOAL);
            if (sumSteps >= STEPS_GOAL)
            {
                Console.WriteLine($"Goal reached! Good job!\n{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
