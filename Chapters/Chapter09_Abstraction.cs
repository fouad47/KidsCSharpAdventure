namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 9: Abstraction
     * 
     * Imagine I tell you to 'Draw a Shape'. 
     * You can't draw just a 'Shape' - it has to be a Circle or a Square!
     * 
     * Abstraction is about the IDEA of something, without the full details.
     * We use 'abstract' classes for things that are just ideas.
     */
    
    // Just an idea of a shape
    public abstract class Shape
    {
        public abstract void Draw(); // No detail how to draw it here!
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Robot: Drawing a round Circle! O");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Robot: Drawing a Square! []");
        }
    }

    public class Chapter09_Abstraction
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 9: Just an Idea (Abstraction) ---");

            Shape myCircle = new Circle();
            Shape mySquare = new Square();

            Console.WriteLine("Robot: I have some shape ideas...");
            myCircle.Draw();
            mySquare.Draw();

            Console.WriteLine("Robot: We knew they were 'Shapes', but we only knew HOW");
            Console.WriteLine("Robot: to draw them once we picked a real one!");
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}
