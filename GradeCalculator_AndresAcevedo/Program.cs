namespace GradeCalculator_AndresAcevedo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Student Grade Calculator ===");
            Console.WriteLine("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string grade;
            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            int score = int.Parse(Console.ReadLine());
            else if (score >= 60) grade = "D";
            else grade = "F";

            Console.Write("Enter number of assignments: "); 
            int assignments = int.Parse(Console.ReadLine()); 
            double average = (double)score / assignments; 
            Console.WriteLine($"Average score: {average:F2}");

            Console.WriteLine($"Your grade is: {grade}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
