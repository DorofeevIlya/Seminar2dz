// 20. Дано число. Проверить кратно ли оно 7 и 23
int N,d0, d1;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
d0=N%7;
d1=N%23;
if (d0==0 && d1!=0) Console.WriteLine($"Число {N} кратно только 7");
if (d0!=0 && d1==0) Console.WriteLine($"Число {N} кратно только 23 ");
if (d0==0 && d1==0) Console.WriteLine($"Число {N} кратно 7 и 23 ");
if (d0!=0 && d1!=0) Console.WriteLine($"Число {N} не кратно 7 и 23 ");
