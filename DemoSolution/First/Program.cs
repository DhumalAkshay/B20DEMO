// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Welcome to Calculator App");

Console.WriteLine("Please Enter the first Number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Please Enter the Second Number");
int b = int.Parse(Console.ReadLine());




Calculator c = new Calculator();
c.Add(a, b);


Console.ReadLine();
