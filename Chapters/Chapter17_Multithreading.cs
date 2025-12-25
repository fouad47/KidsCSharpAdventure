using System.Threading.Tasks;

namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 17: Multithreading
     * 
     * Can you pat your head and rub your tummy at the same time?
     * Computers can! 
     * 
     * 'Multithreading' is like having two Robots working together.
     * One Robot can play music while the other Robot draws a picture.
     */
    
    public class Chapter17_Multithreading
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 17: Two Robots are Better than One ---");

            // Start a second Robot task
            Task musicTask = Task.Run(() => 
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Music Robot: *Playing a cool song* ♫ ♫ ♫");
                    Task.Delay(1000).Wait(); // Wait for 1 second
                }
            });

            // The main Robot keeps working too!
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Drawing Robot: *Drawing a superhero* ✎");
                Task.Delay(1000).Wait();
            }

            // Wait for the music to finish
            musicTask.Wait();

            Console.WriteLine("Robot: We both finished at the same time! Teamwork!");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
