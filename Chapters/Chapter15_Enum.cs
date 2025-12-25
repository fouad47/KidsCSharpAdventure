namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 15: Enums
     * 
     * Imagine a remote control with only 3 buttons: Easy, Medium, Hard.
     * An 'Enum' is a special list of fixed choices.
     */
    
    public enum GameDifficulty
    {
        Easy,
        Medium,
        Hard
    }

    public class Chapter15_Enum
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 15: Pick a Level (Enums) ---");

            GameDifficulty myLevel = GameDifficulty.Medium;

            Console.WriteLine("Robot: You chose the " + myLevel + " difficulty.");

            if (myLevel == GameDifficulty.Easy)
            {
                Console.WriteLine("Robot: Relax! This will be a breeze.");
            }
            else if (myLevel == GameDifficulty.Medium)
            {
                Console.WriteLine("Robot: A good challenge for a brave coder!");
            }
            else
            {
                Console.WriteLine("Robot: Watch out! This level is tough!");
            }

            Console.WriteLine("---------------------------------------\n");
        }
    }
}
