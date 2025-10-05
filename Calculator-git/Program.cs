Console.WriteLine("Calculator");

Console.WriteLine("enter your first number:");
double a = double.Parse(Console.ReadLine()!);

Console.WriteLine("enter your second number:");
double b = double.Parse(Console.ReadLine()!);

Console.WriteLine("Выберите операцию + или *");
char op = Console.ReadLine()[0];

double result = op == '+' ? a+b : a*b;

Console.WriteLine($"Answer: {result}");
