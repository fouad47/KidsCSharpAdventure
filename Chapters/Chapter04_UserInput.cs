namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 4: User Input
     * 
     * Up until now, the Robot has been doing all the talking!
     * Now, let's learn how to talk back to the Robot.
     * 
     * We use 'Console.ReadLine()' to listen to what you type.
     */
    public class Chapter04_UserInput
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 4: Talking to Your Robot ---");

            Console.WriteLine("Robot: Hi! I forgot to ask... what is your name?");
            Console.Write("Type your name here: ");
            string name = Console.ReadLine() ?? "Friend";

            Console.WriteLine("Robot: It is so nice to meet you, " + name + "!");

            Console.WriteLine("Robot: How many toys do you have in your room?");
            Console.Write("Enter a number: ");
            string toyInput = Console.ReadLine() ?? "0";
            
            // Converting text numbers to real numbers
            if (int.TryParse(toyInput, out int toyCount))
            {
                Console.WriteLine("Robot: Wow! " + toyCount + " is a lot of toys!");
            }
            else
            {
                Console.WriteLine("Robot: Hmm, that didn't look like a number, but I'll bet it's a lot!");
            }

            Console.WriteLine("Robot: I'm happy we are friends now.");
            Console.WriteLine("------------------------------------------\n");
        }
    }
}
