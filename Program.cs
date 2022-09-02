// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] EnterRandomArray()
{
    System.Console.WriteLine("Укажите размер массива");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine($"Массив заполненный случайными положительными трёхзначными числами: {String.Join(", ", array)}");
    return array;
}

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    
    Console.WriteLine($"Количество чётных чисел в массиве {count}");
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

void SummInOddPositions(int[] array)
{
    int sum1 = 0;
    int sum2 = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum1 += array[i];
        }
        else sum2 += array[i];
    }

     Console.WriteLine($"Сумма элементов с нечетными индексами: {sum1}");
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum2}");
}



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void DifferenceBetweenMaxMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[minPos] > array[j])
            {
                minPos = j;
            }
            int temp = array[minPos];
            array[minPos] = array[i];
            array[i] = temp;
        }
    }
    int DifferenceBetweenMaxMin = Math.Abs(array[0] - array[array.Length - 1]);
   // Console.WriteLine($"rangered array: {String.Join(", ", array)}");
    System.Console.WriteLine($"разница между максимальным и минимальным элементами массива = {DifferenceBetweenMaxMin}");
}



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент
// , второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21 

void MultiplyPairs(int[] array)
{

    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = array[i] * array[array.Length - 1];
        array = array.SkipLast(1).ToArray();
    }
     
    Console.WriteLine($"Произведение пар чисел: {String.Join(", ", array)}");
}


System.Console.WriteLine("***Задача 34***");
EvenCount(EnterRandomArray());
System.Console.WriteLine("***Задача 36***");
SummInOddPositions(EnterRandomArray());
System.Console.WriteLine("***Задача 38***");
DifferenceBetweenMaxMin(EnterRandomArray());
System.Console.WriteLine("***Задача 37***");
MultiplyPairs(EnterRandomArray());
