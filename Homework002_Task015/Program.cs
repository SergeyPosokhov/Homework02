//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5 && num < 8)
{
Console.WriteLine("да, это выходной день");
}
else
{
    if(num > 0 && num < 6)
    {
        Console.WriteLine("нет, это будний день");
    }
}


if(num > 7 || num < 1)
{
    Console.WriteLine("Цифра должна быть от 1 до 7 ");
}