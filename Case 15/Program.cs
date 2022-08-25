// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void PrintThirdInt() 
{
    Console.WriteLine("Введите число от 1 до 7");
    int x = Convert.ToInt32( Console.ReadLine());
    if (x == 1)
    Console.WriteLine($"Понедельник - не выходной ");
    if (x == 2)
    Console.WriteLine($"Вторник - не выходной ");
    if (x == 3)
    Console.WriteLine($"Среда - не выходной ");
    if (x == 4)
    Console.WriteLine($"Четверг - не выходной ");
    if (x == 5)
    Console.WriteLine($"Пятница - не выходной ");
    if (x == 6)
    Console.WriteLine($"Суббота - выходной ");
    if (x == 7)
    Console.WriteLine($"Воскресенье - выходной ");
}
PrintThirdInt();