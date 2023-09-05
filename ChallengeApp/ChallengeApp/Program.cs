using ChallengeApp;

var employee = new Employee("Krzysztof", "Trela");

employee.AddGrade("stefan");
employee.AddGrade("226");
employee.AddGrade(6);
employee.AddGrade(10);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

//Console.WriteLine($"Average: {statistics.Avg:N1}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");





