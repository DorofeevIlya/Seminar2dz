// 22 По двум заданным числам проверять является ли одно квадратом другого.
int A,B;
Console.Write("Введите A: ");
A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
B=Convert.ToInt32(Console.ReadLine());
if (A==B*B) System.Console.WriteLine($"{A} является квадратом {B}");
if (B==A*A) System.Console.WriteLine($"{B} является квадратом {A}");
if (B!=A*A && A!=B*B) System.Console.WriteLine($"{A} и {B} не являются квадратами друг друга");
        