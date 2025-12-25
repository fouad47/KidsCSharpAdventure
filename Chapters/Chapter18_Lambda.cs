using System.Collections.Generic;
using System.Linq;

namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 18: Lambda Expressions
     * 
     * Imagine a shortcut for a long walk.
     * 'Lambda Expressions' are like tiny, smart shortcuts for code logic.
     * 
     * They use a special arrow '=>' which means "Go do this!".
     */
    
    public class Chapter18_Lambda
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 18: The Smart Shortcut (Lambda) ---");

            List<int> numbers = new List<int> { 1, 5, 8, 12, 15, 20 };

            Console.WriteLine("Robot: I have a list of numbers: 1, 5, 8, 12, 15, 20");

            // Using a lambda shortcut to find numbers bigger than 10
            var bigNumbers = numbers.Where(n => n > 10).ToList();

            Console.Write("Robot: The numbers bigger than 10 are: ");
            foreach (var n in bigNumbers)
            {
                Console.Write(n + " ");
            }
            
            Console.WriteLine("\nRobot: That was a very short and smart piece of code!");
            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
