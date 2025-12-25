namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 5: Class and Object
     * 
     * A 'Class' is like a BLUEPRINT or a drawing of a toy.
     * An 'Object' is the REAL TOY built from that drawing.
     * 
     * You can use one blueprint to make many, many toys!
     */
    
    // The Blueprint
    public class ToyCar
    {
        public string Color = "Red";
        public string Brand = "Speedy";

        public void Honk()
        {
            Console.WriteLine("Toy Car: Beep Beep!");
        }
    }

    public class Chapter05_ClassObject
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 5: Blueprints and Real Toys ---");

            // Making a REAL toy car from the blueprint
            ToyCar myCar = new ToyCar();
            myCar.Color = "Blue";
            myCar.Brand = "Thunder";

            Console.WriteLine("Robot: I built a toy car for you!");
            Console.WriteLine("Robot: It is " + myCar.Color + " and the brand is " + myCar.Brand + ".");
            myCar.Honk();

            // Making ANOTHER toy car from the same blueprint
            ToyCar sisterCar = new ToyCar();
            sisterCar.Color = "Pink";
            Console.WriteLine("Robot: And here is a " + sisterCar.Color + " car for your sister!");
            
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
