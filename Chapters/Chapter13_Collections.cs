using System.Collections.Generic;

namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 13: Collections
     * 
     * A 'List' is like a big TOY BOX where you can keep adding many toys.
     * A 'Dictionary' is like a HOBBY BOOK where you look up a name to find a detail.
     */
    
    public class Chapter13_Collections
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 13: The Big Toy Box ---");

            // A List of toys
            List<string> toyBox = new List<string>();
            toyBox.Add("Robot");
            toyBox.Add("Car");
            toyBox.Add("Dinosaur");

            Console.WriteLine("Robot: In my toy box, I have:");
            foreach (string toy in toyBox)
            {
                Console.WriteLine("- " + toy);
            }

            // A Dictionary for game scores
            Dictionary<string, int> scoreBoard = new Dictionary<string, int>();
            scoreBoard["SuperKid"] = 500;
            scoreBoard["CoolRobot"] = 999;

            Console.WriteLine("\nRobot: Let's check the scoreboard:");
            Console.WriteLine("SuperKid has: " + scoreBoard["SuperKid"] + " points.");
            
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
