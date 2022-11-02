//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите какое-нибудь число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    int i = 10;
    while (num > 999)
    {
        num = num / i;
    }
Console.WriteLine(num % 10);    
}