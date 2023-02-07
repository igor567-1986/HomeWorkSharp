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
