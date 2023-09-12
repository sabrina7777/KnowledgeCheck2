using KnowledgeCheck2;
using System.IO.Pipes;

Employee employee = new Employee();

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<AnnualReview>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var AnnualReview = new AnnualReview();

    Console.WriteLine("Enter the value for ");
    AnnualReview. = Console.ReadLine();


    recordList.Add(AnnualReview);
}
