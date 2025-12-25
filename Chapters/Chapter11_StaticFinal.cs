namespace KidsCSharpAdventure.Chapters
{
    /*
     * CHAPTER 11: Static and Readonly
     * 
     * 'Static' means something is SHARED by everyone.
     * Like the name of your school - every student in the school has the same school name!
     * 
     * 'Readonly' means a rule that CANNOT be changed once it's set.
     */
    
    public class Student
    {
        // Static means all Students share this one name
        public static string SchoolName = "Coding Academy for Kids";

        // Readonly means once we give the student an ID, it stays forever!
        public readonly int StudentID;

        public Student(int id)
        {
            StudentID = id;
        }
    }

    public class Chapter11_StaticFinal
    {
        public static void Run()
        {
            Console.WriteLine("--- Chapter 11: Shared Rules (Static & Readonly) ---");

            Student s1 = new Student(101);
            Student s2 = new Student(102);

            Console.WriteLine("Robot: Student 1 goes to: " + Student.SchoolName);
            Console.WriteLine("Robot: Student 2 goes to: " + Student.SchoolName);

            Console.WriteLine("Robot: Student 1 ID is: " + s1.StudentID);
            Console.WriteLine("Robot: Student 2 ID is: " + s2.StudentID);

            Console.WriteLine("Robot: Everyone shares the school name because it is 'static'!");
            Console.WriteLine("----------------------------------------------------\n");
        }
    }
}
