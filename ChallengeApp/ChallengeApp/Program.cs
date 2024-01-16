using ChallengeApp;

Console.WriteLine("Welcome to XYZ program for employee rating!");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Add grade to employee or press [q] to exit the program and display statistics:");

var employee = new EmployeeInFile("Łukasz", "Pisiak");
employee.GradeAdded += EmployeGradeAded;

void EmployeGradeAded(object sender, EventArgs args)
{
    Console.WriteLine("New grade added");
}

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Something went wrong: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

//test