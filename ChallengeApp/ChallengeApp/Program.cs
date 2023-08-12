using ChallengeApp;

var employee = new Employee("Krzysztof", "Trela");

employee.AddGrade("stefan");
employee.AddGrade("226");
employee.AddGrade(6);
employee.AddGrade(10);
employee.AddGrade(5);
employee.AddGrade(3);
employee.AddGrade("4");
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Avg:N1}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

 



