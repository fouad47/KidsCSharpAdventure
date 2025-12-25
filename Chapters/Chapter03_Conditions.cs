namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 3: Conditions and Loops
     * 
     * Conditions (if/else):
     * Imagine you are at a fork in the road. 
     * IF you have a key, you can go left. ELSE, you must go right.
     * 
     * Loops (for):
     * Imagine you are jumping rope. 
     * You say: "I will jump 5 times!" That's a loop.
     */
    public class Chapter03_Conditions
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 3: Making Decisions and Repeating ---");

            int health = 0;

            // Decision making
            if (health > 0)
            {
                Console.WriteLine("Robot: You are still in the game! Keep going!");
            }
            else
            {
                Console.WriteLine("Robot: Oh no! Game Over. Let's try again.");
            }

            Console.WriteLine("Robot: Now, let's count our robot jumps together!");

            // Looping - counting from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Robot: Jump number " + i + "!");
            }

            Console.WriteLine("Robot: Well done! You are getting fast.");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
