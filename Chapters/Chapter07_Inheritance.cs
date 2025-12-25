namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 7: Inheritance
     * 
     * Think about a Dad and a Son. 
     * The Son 'inherits' things from his Dad, like eye color or a last name.
     * 
     * In coding, a 'Child Class' can inherit powers from a 'Parent Class'.
     */
    
    // The Parent Class
    public class Animal
    {
        public string Name = "Some Creature";
        public void Eat()
        {
            Console.WriteLine("Robot: " + Name + " is munching on food. Nom nom!");
        }
    }

    // The Child Class (inherits from Animal)
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Robot: " + Name + " says: WOOF WOOF!");
        }
    }

    public class Chapter07_Inheritance
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 7: Like Parent, Like Child ---");

            Dog myPuppy = new Dog();
            myPuppy.Name = "Sparky";

            // Sparky can Bark (his own power)
            myPuppy.Bark();

            // Sparky can also Eat (inherited from its Parent Animal!)
            myPuppy.Eat();

            Console.WriteLine("Robot: See? Sparky didn't need to learn how to Eat,");
            Console.WriteLine("Robot: he inherited it from the Animal family!");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
