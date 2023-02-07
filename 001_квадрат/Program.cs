// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).
// Например:
// ● 4 -> 16
// ● -3 -> 9
// ● -7 -> 49

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
if (b * b == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
