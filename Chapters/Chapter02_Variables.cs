namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 2: Variables and Data Types
     * 
     * Think of a Variable as a "Magic Box". 
     * You can put something inside the box and give it a label.
     * 
     * - 'string' is a box for words (like your name).
     * - 'int' is a box for whole numbers (like your age or game score).
     * - 'bool' is a box for True or False (like 'Is the game over?').
     */
    public class Chapter02_Variables
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 2: Magic Boxes (Variables) ---");

            // string is for text
            string playerName = "Super Kid";
            
            // int is for numbers
            int gameScore = 150;
            
            // bool is for yes/no
            bool isSunnyDay = true;

            Console.WriteLine("Robot: Let's look inside our magic boxes!");
            Console.WriteLine("Robot: Player Name is: " + playerName);
            Console.WriteLine("Robot: Current Score is: " + gameScore);
            Console.WriteLine("Robot: Is it a sunny day? " + isSunnyDay);
            
            Console.WriteLine("Robot: Now let's change the score!");
            gameScore = gameScore + 50; // Getting a bonus!
            Console.WriteLine("Robot: New Score is: " + gameScore);
            Console.WriteLine("------------------------------------------\n");
        }
    }
}
