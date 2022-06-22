/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

int size;

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
    array[i]= new Random().Next(-9,9);
    
    Console.Write(array[i] + " ");
}
Console.WriteLine();

void SumOddNumber (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 0)
        {
            result = result +array[i];
        }
    }
    Console.WriteLine($"Сумма нечетных позиций: {result}");
}

SumOddNumber(array);