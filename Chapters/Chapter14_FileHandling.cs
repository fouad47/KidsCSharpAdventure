using System.IO;

namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 14: File Handling
     * 
     * Imagine you want the Robot to REMEMBER your score even after you turn off the computer.
     * We can save data into a 'File' (like a digital notebook).
     */
    
    public class Chapter14_FileHandling
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 14: Writing in the Digital Notebook ---");

            string fileName = "my_game_save.txt";
            string contentToWrite = "Hi Robot! I reached Level 10 today!";

            Console.WriteLine("Robot: I am writing your message to a file...");
            File.WriteAllText(fileName, contentToWrite);

            Console.WriteLine("Robot: ... Done! Now let's try to read it back.");
            
            if (File.Exists(fileName))
            {
                string readContent = File.ReadAllText(fileName);
                Console.WriteLine("Robot: The notebook says: \"" + readContent + "\"");
            }
            else
            {
                Console.WriteLine("Robot: Oh, I couldn't find the notebook.");
            }

            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
