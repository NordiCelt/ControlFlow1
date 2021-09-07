using System;

namespace ControlFlowExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's good homie? How many years have you studied C#?");
            short experience = Convert.ToInt16(Console.ReadLine());

            if (experience >= 1 && experience <= 10)
                {
                    Console.WriteLine($"You've been learning C# for {experience} years!");
                }
            else
            {
                Console.WriteLine("This cant be true!");
            }
        }
    }
}
