using System.Data;


double investAmount;
double interestRate;
double interestPerMonth;
int numYrs;
double total;

Console.WriteLine("Enter Investment Amount:");
investAmount = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Annual Interest Rate in Percentage:");
interestRate = double.Parse(Console.ReadLine());

interestPerMonth = interestRate / 100 / 12;

Console.WriteLine("Enter Number of years:");
numYrs = int.Parse(Console.ReadLine());

total = investAmount * Math.Pow(1 + interestPerMonth, numYrs * 12);

Console.WriteLine($"Future Value is {total:c}");
