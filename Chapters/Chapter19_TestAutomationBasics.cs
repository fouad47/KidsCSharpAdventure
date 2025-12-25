namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 19: Test Automation Basics
     * 
     * What is Testing?
     * Checking if a toy works before you play with it!
     * 
     * What is a Bug?
     * A small mistake in the code.
     * 
     * Automation Testing:
     * Imagine a Robot that checks your homework for you 100 times, 
     * and it never gets tired!
     */
    
    public class SimpleCalculator
    {
        public int Add(int a, int b) { return a + b; }
    }

    public class Chapter19_TestAutomationBasics
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 19: Robot Homework Checker (Automation) ---");

            SimpleCalculator calc = new SimpleCalculator();
            
            Console.WriteLine("Robot: I am going to test if my Calculator works.");

            // Test Case 1
            int expected = 5;
            int actual = calc.Add(2, 3);

            Console.WriteLine("Test Case: 2 + 3 should be 5");
            Console.WriteLine("Expected: " + expected + " | Actual: " + actual);

            if (actual == expected)
            {
                Console.WriteLine("Robot Result: PASS! ✅ (The calculator is smart!)");
            }
            else
            {
                Console.WriteLine("Robot Result: FAIL! ❌ (We found a BUG!)");
            }

            Console.WriteLine("\nRobot: That's automation! We wrote code to check our code.");
            Console.WriteLine("-------------------------------------------------------\n");
        }
    }
}
