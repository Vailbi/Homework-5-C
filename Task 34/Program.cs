/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */

int size;

InputSizeArray("Введите размер массива: ");

int InputSizeArray (string x)
{
    Console.Write(x);
    size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int [] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(1,1000);
    
    Console.Write(array[i] + " ");
}

Console.WriteLine();

void Count (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        result++;
    }
    Console.WriteLine($"Количество четных чисел: {result}");
}

Count(array);