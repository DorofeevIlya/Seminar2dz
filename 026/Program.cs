// 26. Программа проверяет пятизначное число на палиндромом.

int N,d1,d2,d3,d4,d5;
Console.Write("Введите пятизначное число N: ");
N=Convert.ToInt32(Console.ReadLine());
d1=N/10000;
d2=N/1000%10;
d3=N/100%10;
d4=N/10%10;
d5=N%10;
if (d1==d5 && d2==d4)
    Console.WriteLine($"Число палиндром");
else
    Console.WriteLine($"Число не палиндром");