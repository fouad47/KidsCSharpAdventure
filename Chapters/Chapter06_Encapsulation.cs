namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 6: Encapsulation
     * 
     * Imagine you have a "Secret Diary". 
     * You don't want everyone to just grab it and read it!
     * 
     * Encapsulation is like putting your data in a locked box.
     * Only YOU have the key (Getters and Setters) to see or change it safely.
     */
    
    public class SecretDiary
    {
        // 'private' means it's hidden from the outside world
        private string _secretMessage = "I love cookies!";

        // This is a 'Property' (the key to the lock)
        public string SecretMessage
        {
            get { return _secretMessage; } // Let someone read it
            set 
            { 
               // We can check if they are allowed to change it!
               if (value.Length > 0)
               {
                   _secretMessage = value; 
               }
            }
        }
    }

    public class Chapter06_Encapsulation
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 6: The Locked Secret Box ---");

            SecretDiary myDiary = new SecretDiary();

            Console.WriteLine("Robot: Let's try to read the secret message...");
            Console.WriteLine("Robot: The diary says: " + myDiary.SecretMessage);

            Console.WriteLine("Robot: Now let's change it to something else.");
            myDiary.SecretMessage = "I also love C#!";
            Console.WriteLine("Robot: Now the diary says: " + myDiary.SecretMessage);

            Console.WriteLine("Robot: We kept the message safe inside the class!");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
