//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите какое-нибудь трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num % 10;
int b = num / 10 % 10;
int c = num / 100 % 10;
Console.WriteLine(b);
