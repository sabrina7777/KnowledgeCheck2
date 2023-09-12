using KnowledgeCheck2;
using System.IO.Pipes;

internal class Program
{
    private static void Main(string[] args)
    {
      Employee employee = new Employee();
        employee.FirstName = "Sabrina";
        employee.LastName = "Clore";
        employee.Department = "Human Resources";
        employee.YearsService = 10;

        employee.Greeting();
}
}