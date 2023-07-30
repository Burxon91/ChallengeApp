int number = 4566;
int zero = 0;
int one = 0;
int two = 0;
int three = 0;
int four = 0;
int five = 0;
int six = 0;
int seven = 0;
int eight = 0;
int nine = 0;

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

for (int i = 0; i < letters.Length; i++)
{
    if (letters[i] == '0')
    {
        zero++;  
    }
    else if (letters[i] == '1')
    {
        one++;
    }
    else if (letters[i] == '2')
    {
        two++;
    }
    else if (letters[i] == '3')
    {
        three++;
    }
    else if (letters[i] == '4')
    {
        four++;
    }
    else if (letters[i] == '5')
    {
        five++;
    }
    else if (letters[i] == '6')
    {
        six++;
    }
    else if (letters[i] == '7')
    {
        seven++;
    }
    else if (letters[i] == '8')
    {
        eight++;
    }
    else 
    {
        nine++;
    }

}
Console.WriteLine("0-->" + zero);
Console.WriteLine("1-->" + one);
Console.WriteLine("2-->" + two);
Console.WriteLine("3-->" + three);
Console.WriteLine("4-->" + four);
Console.WriteLine("5-->" + five);
Console.WriteLine("6-->" + six);
Console.WriteLine("7-->" + seven);
Console.WriteLine("8-->" + eight);
Console.WriteLine("9-->" + nine);


