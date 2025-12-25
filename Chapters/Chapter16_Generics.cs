namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 16: Generics
     * 
     * Imagine a 'Magic Box' that can hold a Robot, OR a Car, OR a Cookie.
     * You don't need a different box for each!
     * 
     * 'Generics' let us write code that works with ANY kind of data.
     */
    
    // The Magic Box that can hold anything <T>
    public class MagicBox<T>
    {
        private T _item;

        public void PutInside(T item)
        {
            _item = item;
            Console.WriteLine("Robot: I put a " + item + " inside the magic box!");
        }

        public T GetOut()
        {
            return _item;
        }
    }

    public class Chapter16_Generics
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 16: The Magic Box (Generics) ---");

            // A box for strings (words)
            MagicBox<string> wordBox = new MagicBox<string>();
            wordBox.PutInside("Lucky Charm");

            // A box for numbers (ints)
            MagicBox<int> numberBox = new MagicBox<int>();
            numberBox.PutInside(777);

            Console.WriteLine("Robot: From the word box, I got: " + wordBox.GetOut());
            Console.WriteLine("Robot: From the number box, I got: " + numberBox.GetOut());

            Console.WriteLine("Robot: One class, many types of items! Magic!");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
