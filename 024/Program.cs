// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double X,Y;
Console.Write("Введите координату X: ");
X=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
Y=Convert.ToDouble(Console.ReadLine());
if (X>0 && Y>0) System.Console.WriteLine("Первая четверь");
if (X<0 && Y>0) System.Console.WriteLine("Вторая четверь");
if (X<0 && Y<0) System.Console.WriteLine("Третья четверь");
if (X>0 && Y<0) System.Console.WriteLine("Четвертая четверь");
if (X==0 || Y==0) System.Console.WriteLine("Точка находится на оси");

