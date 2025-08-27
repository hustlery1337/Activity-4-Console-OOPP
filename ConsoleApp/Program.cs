using System;

namespace ConsoleApp
{
    abstract class Student
    {
        protected string StudentName;
        protected double Grade;

        public void SetData(string StudentName, double Grade)
        {
            this.StudentName = StudentName;
            this.Grade = Grade;
        }
        public abstract void DisplayInfo();
        public abstract void CalculateGrade();
    }

    class College : Student
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("College");
            Console.WriteLine($"StudentName: {StudentName}");
            Console.WriteLine($"Grade: {Grade}");
            CalculateGrade();
        }
        public override void CalculateGrade()
        {
            if (Grade <= 3)
                Console.WriteLine("Status: Passed");
            else
                Console.WriteLine("Status: Failed");
        }
    }

    class Senior : Student
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Senior");
            Console.WriteLine($"StudentName: {StudentName}");
            Console.WriteLine($"Grade: {Grade}");
            CalculateGrade();
        }
        public override void CalculateGrade()
        {
            if (Grade > 75)
                Console.WriteLine("Status: Passed");
            else
                Console.WriteLine("Status: Failed");
        }
    }

    class Program
    {
        static void Main()
        {
            College college1 = new College();
            college1.SetData("Mike", 2.75);
            college1.DisplayInfo();

            College college2 = new College();
            college2.SetData("Daniel", 4.0);
            college2.DisplayInfo();

            Console.WriteLine("");

            Senior senior1 = new Senior();
            senior1.SetData("Nathan", 89);
            senior1.DisplayInfo();

            Senior senior2 = new Senior();
            senior2.SetData("Sarah", 69);
            senior2.DisplayInfo();
        }
    }
}
