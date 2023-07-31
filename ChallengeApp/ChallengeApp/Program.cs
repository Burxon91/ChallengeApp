using ChallengeApp;
using System.ComponentModel.Design;

Employee employee1 = new Employee("Adam", "Nowak", 23);
Employee employee2 = new Employee("Monika", "Kowalska", 41);
Employee employee3 = new Employee("Stefan", "Batory", 28);


employee1.AddMark(5);
employee1.AddMark(7);
employee1.AddMark(8);
employee1.AddMark(3);
employee1.AddMark(7);

employee2.AddMark(10);
employee2.AddMark(2);
employee2.AddMark(9);
employee2.AddMark(5);
employee2.AddMark(9);

employee3.AddMark(9);
employee3.AddMark(7);
employee3.AddMark(5);
employee3.AddMark(1);
employee3.AddMark(4);


var result = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;
var name1 = employee1.Name;
var surname1 = employee1.Surname;
var age1 = employee1.Age;
var name2 = employee2.Name;
var surname2 = employee2.Surname;
var age2 = employee2.Age;
var name3 = employee3.Name;
var surname3 = employee3.Surname;
var age3 = employee3.Age;

if (employee1.Result > employee2.Result)
{
    if (employee1.Result > employee3.Result)
    {

        System.Console.WriteLine("Imię: " + name1 + " Nazwisko: " + surname1 + " Wiek: " + age1 + " Wynik: " + employee1.Result);
    }
    else
    {
        System.Console.WriteLine("Imię: " + name3 + " Nazwisko: " + surname3 + " Wiek: " + age3 + " Wynik: " + employee3.Result);
    }
}
else if (employee2.Result > employee3.Result)
{
    System.Console.WriteLine("Imię: " + name2 + " Nazwisko: " + surname2 + " Wiek: " + age2 + " Wynik: " + employee2.Result);
}
else
{
    System.Console.WriteLine("Imię: " + name3 + " Nazwisko: " + surname3 + " Wiek: " + age3 + " Wynik: " + employee3.Result);
}
