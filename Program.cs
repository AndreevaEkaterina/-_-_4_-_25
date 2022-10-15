// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Power(int a, int b)
{
    Console.Write($"{Math.Pow(a, b)}");
}
Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число степени: ");
int B = int.Parse(Console.ReadLine()!);
Power(A, B);