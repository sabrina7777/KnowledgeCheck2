using KnowledgeCheck2;
using System.IO.Pipes;

Employee employee = new Employee();

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<AnnualReview>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var annualReview = new AnnualReview();

    Console.WriteLine("Enter Y or N for if Annual Review Completed");
    annualReview.OnboardingComplete = bool.TryParse(Console.ReadLine(), out annualReview.OnboardingComplete);
    
    string answer = Console.ReadLine().ToUpper();
    if(answer=="Y")
        annualReview.OnboardingComplete = true;
    if(answer=="N")
        annualReview.OnboardingComplete = false;

    recordList.Add(annualReview);

    Console.WriteLine("Enter Y or N for if Bonus Approved");
    object bonusApproved = null;
    bonusApproved.OnboardingComplete = bool.TryParse(Console.ReadLine(), out bonusApproved.OnboardingComplete);

    string answerbonus = Console.ReadLine().ToUpper();
    if (answerbonus == "Y")
        bonusApproved.OnboardingComplete = true;
    if (answerbonus == "N")
        bonusApproved.OnboardingComplete = false;
}
