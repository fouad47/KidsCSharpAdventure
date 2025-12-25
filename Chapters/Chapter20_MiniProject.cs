using System.Collections.Generic;
using System.IO;

namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 20: The Grand Finale (Mini Project)
     * 
     * We are going to build a 'Robot School System'.
     * It will:
     * 1. Keep a List of students (Collections).
     * 2. Save them to a file (File Handling).
     * 3. Have a built-in test to make sure it works (Automation).
     */
    
    public class SchoolSystem
    {
        private List<string> _students = new List<string>();

        public void AddStudent(string name)
        {
            _students.Add(name);
            Console.WriteLine("School: Student '" + name + "' added!");
        }

        public int GetStudentCount() { return _students.Count; }

        public void SaveToFile(string path)
        {
            File.WriteAllLines(path, _students);
            Console.WriteLine("School: Saved student list to " + path);
        }
    }

    public class Chapter20_MiniProject
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 20: The Robot School (Mini Project) ---");

            SchoolSystem mySchool = new SchoolSystem();
            
            mySchool.AddStudent("Alex");
            mySchool.AddStudent("Bella");
            mySchool.AddStudent("Charlie");

            Console.WriteLine("Robot: Our school now has " + mySchool.GetStudentCount() + " students.");

            // Let's add an automation test inside our project!
            Console.WriteLine("\nRobot: [AUTOMATION TEST] Checking student count...");
            if (mySchool.GetStudentCount() == 3)
            {
                Console.WriteLine("Result: PASS ✅ (3 students found)");
            }
            else
            {
                Console.WriteLine("Result: FAIL ❌ (Expected 3 students but found " + mySchool.GetStudentCount() + ")");
            }

            string savePath = "students_list.txt";
            mySchool.SaveToFile(savePath);

            Console.WriteLine("\nRobot: CONGRATULATIONS! You finished the C# Adventure!");
            Console.WriteLine("Robot: You are now a Junior Robot Programmer.");
            Console.WriteLine("---------------------------------------------------\n");
        }
    }
}
