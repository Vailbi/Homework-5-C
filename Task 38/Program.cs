/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


int size;
int max;
int min;

int InputSizeArray (string x)
{
    Console.Write(x);
    size = Convert.ToInt32(Console.ReadLine());
    return size;
}

InputSizeArray("Введите размер массива: ");

int [] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(100);
    
    Console.Write(array[i] + " ");
}

Console.WriteLine();

void SearchMaxMinInArray (int [] array)
{
max = array[0];
min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max<array[i])
    {
        max = array[i];
    }
    if (min>array[i])
    {
        min = array[i];
    }
}

}

SearchMaxMinInArray(array);

Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Difference = {max-min}");

