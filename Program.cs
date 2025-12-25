using KidsCSharpAdventure.Chapters;

namespace KidsCSharpAdventure
{
    /*
     * WELCOME TO THE KIDS C# ADVENTURE!
     * 
     * This is the Main Entry Point. 
     * Think of it as the "Control Center" for all your chapters.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   WELCOME TO THE KIDS C# ADVENTURE!    ");
                Console.WriteLine("========================================");
                Console.WriteLine("Pick a chapter to start your journey:");
                Console.WriteLine("1.  What is Programming?");
                Console.WriteLine("2.  Magic Boxes (Variables)");
                Console.WriteLine("3.  Decisions and Loops");
                Console.WriteLine("4.  Talking to your Robot (Input)");
                Console.WriteLine("5.  Blueprints (Class & Object)");
                Console.WriteLine("6.  Secret Boxes (Encapsulation)");
                Console.WriteLine("7.  Animal Families (Inheritance)");
                Console.WriteLine("8.  Many Shapes (Polymorphism)");
                Console.WriteLine("9.  The Big Idea (Abstraction)");
                Console.WriteLine("10. The Rule Book (Interfaces)");
                Console.WriteLine("11. Shared Rules (Static)");
                Console.WriteLine("12. Oops! (Exception Handling)");
                Console.WriteLine("13. Toy Box (Collections)");
                Console.WriteLine("14. Save Game (File Handling)");
                Console.WriteLine("15. Levels (Enums)");
                Console.WriteLine("16. Magic Box (Generics)");
                Console.WriteLine("17. Teamwork (Multithreading)");
                Console.WriteLine("18. Shortcut (Lambda)");
                Console.WriteLine("19. Robot Testing (Automation)");
                Console.WriteLine("20. Robot School (Mini Project)");
                Console.WriteLine("0.  Exit Game");
                Console.WriteLine("========================================");
                Console.Write("Choose a number (0-20): ");

                string choice = Console.ReadLine() ?? "0";

                switch (choice)
                {
                    case "1":
                        Chapter01_Basics.Run();
                        break;
                    case "2":
                        Chapter02_Variables.Run();
                        break;
                    case "3":
                        Chapter03_Conditions.Run();
                        break;
                    case "4":
                        Chapter04_UserInput.Run();
                        break;
                    case "5":
                        Chapter05_ClassObject.Run();
                        break;
                    case "6":
                        Chapter06_Encapsulation.Run();
                        break;
                    case "7":
                        Chapter07_Inheritance.Run();
                        break;
                    case "8":
                        Chapter08_Polymorphism.Run();
                        break;
                    case "9":
                        Chapter09_Abstraction.Run();
                        break;
                    case "10":
                        Chapter10_Interfaces.Run();
                        break;
                    case "11": Chapter11_StaticFinal.Run(); break;
                    case "12": Chapter12_ExceptionHandling.Run(); break;
                    case "13": Chapter13_Collections.Run(); break;
                    case "14": Chapter14_FileHandling.Run(); break;
                    case "15": Chapter15_Enum.Run(); break;
                    case "16": Chapter16_Generics.Run(); break;
                    case "17": Chapter17_Multithreading.Run(); break;
                    case "18": Chapter18_Lambda.Run(); break;
                    case "19": Chapter19_TestAutomationBasics.Run(); break;
                    case "20": Chapter20_MiniProject.Run(); break;
                    case "0":
                        keepRunning = false;
                        Console.WriteLine("Robot: Goodbye! Come back soon to learn more!");
                        break;
                    default:
                        Console.WriteLine("Robot: Oops! I don't know that chapter yet. Try 0 to 20.");
                        break;
                }

                if (keepRunning)
                {
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}
