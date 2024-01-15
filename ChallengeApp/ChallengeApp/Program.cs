using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

var employee = new EmployeeInMemory("Łukasz", "Pisiak", "Men", 22);
employee.GradeAdded += EmployeeGradeAdded;
employee.AddGrade(70);
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.GradeAdded -= EmployeeGradeAdded;

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika lub zamknij program przy pomocy litery (q): ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Average in letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

