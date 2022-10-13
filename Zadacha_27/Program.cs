/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = 0;
Console.WriteLine($"Сумма цифр числа {number} -> {SumOfDigits(result)}.");


int SumOfDigits (int size) {
    int digit = 0;
    for (int i = 1; number > 0; i++) {
        digit = number % 10;
        result = result + digit;
        number /= 10;
    }
    return result;
}