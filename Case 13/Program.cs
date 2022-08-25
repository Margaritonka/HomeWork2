// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void PrintThirdInt() 
{
    Console.WriteLine("Введите число ");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = 100;
    if (x < y)
    {
    Console.WriteLine("третьего числа нет ");
    }
    if (x >= y)
    {
    string z = x.ToString();
    Console.Write(z[2]);
    }
}
PrintThirdInt();



