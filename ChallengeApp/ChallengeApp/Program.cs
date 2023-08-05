<<<<<<< HEAD
﻿using ChallengeApp;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

User user1 = new User("Adam", "abc1234");
User user2 = new User("Monika", "abc1234");
User user3 = new User("Stefan", "abc1234");
=======
﻿using System.Threading.Tasks.Sources;

User user1 = new User("Adam", "Adam");
User user2 = new User("Monika", "Adam");
User user3 = new User("Zuzia", "Adam");
User user4 = new User("Damian", "Adam");
>>>>>>> parent of 7cccbde (Zadanie domowe #6)

user1.AddScore(5);
user1.AddScore(2);
user2.AddScore(3);
user2.AddScore(3);
user2.AddScore(10);
user3.AddScore(4);
user3.AddScore(6);
user3.AddScore(4);
var result = user1.Result;
var result2 = user2.Result;
var result3 = user3.Result; 
Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);

<<<<<<< HEAD
user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(8);

user2.AddScore(10);
user2.AddScore(2);
user2.AddScore(9);

user3.AddScore(9);
user3.AddScore(7);
user3.AddScore(5);



=======
class User
{
    private List<int> score = new List<int>();
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
       
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result 
    { 
        get
        {
            return this.score.Sum();
        } 
    }

    public void AddScore(int score)
    {
        this.score.Add(score);
    }
}
>>>>>>> parent of 7cccbde (Zadanie domowe #6)

