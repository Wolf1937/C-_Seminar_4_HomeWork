/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int result = 1;
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {PowNumber(result)}");

int PowNumber (int pow) {
    for (int i = 0; i < B; i++) {
        result = result * A;
    }
    return result;
}