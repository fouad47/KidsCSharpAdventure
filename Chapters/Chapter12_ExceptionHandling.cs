namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 12: Exception Handling
     * 
     * Sometimes things go wrong! 
     * Like trying to divide a cookie by zero friends (impossible!).
     * 
     * 'Try... Catch' is how we catch mistakes before they crash the program.
     */
    
    public class Chapter12_ExceptionHandling
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 12: Oops! Handling Mistakes ---");

            Console.WriteLine("Robot: Let's try to divide 10 by a number you pick.");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine() ?? "0";

            try
            {
                int number = int.Parse(input);
                int result = 10 / number;
                Console.WriteLine("Robot: 10 divided by " + number + " is " + result + "!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Robot: OH NO! You can't divide by zero! That's a math monster!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Robot: Oops! That wasn't a number. Please type digits like 1, 2, 3.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Robot: Something else went wrong: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Robot: No matter what happened, I'm still here to help!");
            }

            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
