using System.Security.Cryptography.X509Certificates;
using static System.Console;

//TASK1
/*do
	{
	        Console.Write("Введите число:");
int number=Convert.ToInt32 (Console.ReadLine()); 
	} while (number >= 100 || number <= 0) ;
if(number%3==0&&number%5==0) Console.WriteLine("Fizz Buzz");
else if (number % 3 == 0) Console.WriteLine("Fizz");
else if(number%5==0) Console.WriteLine("Buzz");
else Console.WriteLine(number);*/

//Task2
/*Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int percent = 0;
do
{
	Console.Write("Введите какой  процент от этого числа надо вычислить:");
	percent = Convert.ToInt32(Console.ReadLine());
	if (percent >= 100 || percent <= 0) Console.WriteLine("Error:не коректное значение введите число от ноля до ста");

} while (percent >= 100 || percent <= 0);
double answer = (double)number / 100; 
answer	*= percent;
Console.WriteLine(answer.ToString());*/

//Task3
/*Console.Write("Введите тысячи:");
int thousands = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сотни:");
int hundreds = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите десятки:");
int dozens = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
number += thousands * 1000 + hundreds * 100 + dozens * 10;
Console.WriteLine(number);*/

//Task 4
int chislo,num1,num2,num3,num4,num5,num6;
do
{
	Console.Write("Введите шестизначное число:");
	chislo = int.Parse(Console.ReadLine());
	if (chislo >= 1000000 || chislo < 100000) Console.WriteLine("Error:не коректное значение введите шестизначное число "); 
} while (chislo >= 1000000 || chislo < 100000);
num1 = chislo / 100000;
chislo = chislo % 100000;
num2 = chislo / 10000;
chislo = chislo % 10000;
num3 = chislo / 1000;
chislo = chislo % 1000;
num4 = chislo / 100;
chislo = chislo %100;
num5 = chislo / 10;
num6 = chislo %10;
int[] numbers =  { num1, num2 ,num3,num4,num5,num6};
int x, y;
do
{
	Console.Write("Введите индекс числа который хотите поменять:");
    x = int.Parse(Console.ReadLine());
	if (x < 0 || x > 7) Console.WriteLine("Error:не коректное значение введите от0 до6");
} while (x<0||x>7);
do
{
	Console.Write("Введите индекс числа  на который хотите поменять:");
	y = int.Parse(Console.ReadLine());
	if (y < 0 || y > 7) Console.WriteLine("Error:не коректное значение введите от0 до6"); 
} while (y < 0 || y > 7);
int buffer = numbers[x-1];
numbers[x-1] = numbers[y-1];
numbers[y - 1] = buffer;
for (int i = 0; i < numbers.Length; i++)
{
        Console.Write(numbers[i]);
}
