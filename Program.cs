﻿//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());

//int sum = num * num;
//Console.WriteLine(sum);
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
   Console.Write("Первое число ");
   Console.Write(firstNumber);
   Console.Write(" больше чем второе число ");
   Console.Write(secondNumber);
}
else if(firstNumber < secondNumber)
{
 Console.Write("Первое число ");
   Console.Write(firstNumber);
   Console.Write(" меньше чем второе число ");
   Console.Write(secondNumber);   
}
else
{
Console.WriteLine("Введённые числа равны ");
Console.Write(firstNumber);
}