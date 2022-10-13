/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arr = new int[8];
FillArray(arr.Length);
Console.WriteLine($"[{String.Join(", ", arr)}]");

void FillArray (int size) {
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(100);
    }
}