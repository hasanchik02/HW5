// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int size = 6;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,21);
}
Console.WriteLine(string.Join(", ", array));
int result = 0;

for (int i = 0; i < size; i++)
{
    if (i % 2 == 1)
    {
        result += array[i];
    }
}
Console.WriteLine(result);