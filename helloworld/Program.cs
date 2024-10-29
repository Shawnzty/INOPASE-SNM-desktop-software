// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Shawn!");

string friend1 = "      Bill     ";
string friend2 = "Alice and Alice";
string friends = $"My friends are {friend1.Trim()} and {friend2}";

Console.WriteLine(friends.Replace("Alice", "Charlie"));
Console.WriteLine(friends.Contains("Alice"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My "));
