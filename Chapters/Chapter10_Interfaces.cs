namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 10: Interfaces
     * 
     * Imagine a 'Rule Book' for a Game Controller. 
     * It says: "Any controller MUST have an 'A' button and a 'B' button."
     * 
     * An Interface is a list of rules that a class MUST follow.
     */
    
    // The Rule Book
    public interface IGameController
    {
        void PressA();
        void PressB();
    }

    // A class that follows the rules
    public class XboxController : IGameController
    {
        public void PressA() { Console.WriteLine("Xbox: Jumping!"); }
        public void PressB() { Console.WriteLine("Xbox: Attacking!"); }
    }

    public class PlayStationController : IGameController
    {
        public void PressA() { Console.WriteLine("PS: Jumping with 'X' button!"); }
        public void PressB() { Console.WriteLine("PS: Attacking with 'Circle' button!"); }
    }

    public class Chapter10_Interfaces
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 10: The Rule Book (Interfaces) ---");

            IGameController myController = new XboxController();
            
            Console.WriteLine("Robot: Using the Xbox controller rules...");
            myController.PressA();
            myController.PressB();

            Console.WriteLine("Robot: Now switch to PlayStation controller...");
            myController = new PlayStationController();
            myController.PressA();
            myController.PressB();

            Console.WriteLine("Robot: Both controllers followed the same 'IGameController' rules!");
            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
