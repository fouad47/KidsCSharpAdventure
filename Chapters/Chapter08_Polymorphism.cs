namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 8: Polymorphism
     * 
     * 'Poly' means many. 'Morph' means shape.
     * It means 'Many Shapes'!
     * 
     * Imagine a 'Play' button on different toys.
     * - On a Drum toy, it goes 'Boom!'.
     * - On a Flute toy, it goes 'Toot!'.
     * 
     * Same button, different sound!
     */
    
    public class Toy
    {
        // 'virtual' means children can change how this works
        public virtual void PressButton()
        {
            Console.WriteLine("Toy: Making a sound...");
        }
    }

    public class DrumToy : Toy
    {
        // 'override' means we are changing the behavior
        public override void PressButton()
        {
            Console.WriteLine("Drum: BOOM! BOOM!");
        }
    }

    public class FluteToy : Toy
    {
        public override void PressButton()
        {
            Console.WriteLine("Flute: TOOT! TOOT!");
        }
    }

    public class Chapter08_Polymorphism
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 8: One Button, Many Sounds ---");

            Toy myDrum = new DrumToy();
            Toy myFlute = new FluteToy();

            Console.WriteLine("Robot: Let's press the buttons on our toys!");
            
            myDrum.PressButton();
            myFlute.PressButton();

            Console.WriteLine("Robot: They both had a 'PressButton' power, but did different things!");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
