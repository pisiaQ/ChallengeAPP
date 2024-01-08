using ChallengeApp;

Employee user1 = new Employee("Tymek", "Malesiński", 20);
Employee user2 = new Employee("Dariusz", "Bąk", 20);
Employee user3 = new Employee("Zosia", "Samosia", 20);

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(8);
user1.AddScore(6);
var result1 = user1.Result;

user2.AddScore(4);
user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(6);
user2.AddScore(9);
var result2 = user2.Result;

user3.AddScore(8);
user3.AddScore(9);
user3.AddScore(10);
user3.AddScore(6);
user3.AddScore(4);
var result3 = user3.Result;

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine($"Najwyzszy wynik ma: {user1.Name},{user1.Surname},{user1.Age}");
    Console.WriteLine("Wynik: " + result1);
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine($"Najwyzszy wynik ma: {user2.Name},{user2.Surname},{user2.Age}");
    Console.WriteLine("Wynik: " + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine($"Najwyzszy wynik ma: {user3.Name},{user3.Surname},{user3.Age}");
    Console.WriteLine("Wynik: " + result3);
}