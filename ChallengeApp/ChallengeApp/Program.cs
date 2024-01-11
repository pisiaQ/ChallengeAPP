using ChallengeApp;

Employee employee = new Employee("Adam", "Kamizelich");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine($"Average ForEachLoop: {statistics1.Average:N2}");
Console.WriteLine($"Max ForEachLoop: {statistics1.Max}");
Console.WriteLine($"Min ForEachLoop: {statistics1.Min}");

var statistics2= employee.GetStatisticsWithFor();

Console.WriteLine($"Average ForLoop: {statistics2.Average:N2}");
Console.WriteLine($"Max ForLoop: {statistics2.Max}");
Console.WriteLine($"Min ForLoop: {statistics2.Min}");

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Average DoWhileLoop: {statistics3.Average:N2}");
Console.WriteLine($"Max DoWhileLoop: {statistics3.Max}");
Console.WriteLine($"Min DoWhileLoop: {statistics3.Min}");

var statistics4= employee.GetStatisticsWithWhile();

Console.WriteLine($"Average WhileLoop: {statistics4.Average:N2}");
Console.WriteLine($"Max WhileLoop: {statistics4.Max}");
Console.WriteLine($"Min WhileLoop: {statistics4.Min}");


