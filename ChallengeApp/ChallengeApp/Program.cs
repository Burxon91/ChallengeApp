using ChallengeApp;

var employee = new Employee("Krzysztof", "Trela");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Avg:N1}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





