// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = {3,7,22,2,78};
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    while(array[i] > max)
    {
        max = array[i];
    }
     while(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine(string.Join(", ", array));
int result = max - min;
Console.WriteLine(result);