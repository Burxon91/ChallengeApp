string name = "Ewa";
int age = 33;
bool kobieta = true;

if (kobieta)
{
    if (name == "Ewa" && age == 33)
    {
        var result = name + ", lat " + age;
        Console.WriteLine(result);
    }
    else if (name != "Ewa" && age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

