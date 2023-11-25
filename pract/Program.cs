// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90]

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
//     return array;
// }

// void PrintArray(int[] InMass)
// {
//     Console.Write("Массив с элементами: ");
//     for(int i = 0; i < InMass.Length; i++)
//     {
//         Console.Write(InMass[i] + " ");
//     }
// }

// void Filter(int[] num) 
// { 
//     int[] n = new int[num.Length];
//     Console.WriteLine(); 
//     Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); 

//     for (int i = 0; i < num.Length; i++) 
//     { 
//         if (num[i] >= 20 && num[i] <= 90) 
//         { 
//             Console.Write(num[i] + " ");
//             n[i] = num[i];
//         } 
//     }
//     int countWithoutZeros = n.Count(x => x != 0);
//     Console.WriteLine();
//     Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {countWithoutZeros}");
// }

// int sizeMass = 10;
// int[] mass = FillArray(sizeMass);
// PrintArray(mass);
// Filter(mass);

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 1001);
//     }
//     return array;
// }

// void PrintArray(int[] InMass)
// {
//     Console.Write("Массив с элементами: ");
//     for(int i = 0; i < InMass.Length; i++)
//     {
//         Console.Write(InMass[i] + " ");
//     }
// }

// void fevenNumbers(int[] num) 
// {
//     int[] n = new int[num.Length];
//     Console.WriteLine(); 
//     Console.Write("Элементы массива, значения которых четное: "); 
//     int countWithoutZeros = 0;

//     for (int i = 0; i < num.Length; i++) {
//         if (num[i] % 2 == 0) {
//             Console.Write(num[i] + " ");
//             n[countWithoutZeros] = num[i];
//             countWithoutZeros++;
//         }
//     }

//     Console.WriteLine();
//     Console.WriteLine($"Количество чётных чисел в массиве: {countWithoutZeros}");
// }

// int sizeMass = 10;
// int[] mass = FillArray(sizeMass);
// PrintArray(mass);
// fevenNumbers(mass);

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// static double[] AFAWNZD(int length) // AFAWNZD = AutoFillArrayWithNonZeroDecimals
// {
//     double[] array = new double[length];
//     Random random = new Random();

//     for (int i = 0; i < length; i++)
//     {
//         double randomNumber = Math.Round(random.NextDouble() * 10, 2);
//         array[i] = randomNumber;
//     }
//     return array;
// }

// void PrintArray(double[] InMass)
// {
//     Console.Write("Массив с элементами: ");
//     for (int i = 0; i < InMass.Length; i++)
//     {
//         Console.Write(InMass[i] + " ");
//     }
// }

// void DON(double[] InMass) // DON = DifferenceOofNnumbers
// {
//     double max = InMass[0];
//     double min = InMass[0];

//     foreach (double num in InMass)
//     {
//         if (num > max)
//             max = num;

//         if (num < min)
//             min = num;
//     }

//     double difference = max - min;

//     Console.WriteLine();
//     Console.WriteLine($"Максимальный элемент: {max}");
//     Console.WriteLine($"Минимальный элемент: {min}");
//     Console.WriteLine($"Разница: {difference}");
// }

// int arrayLength = 25;
// double[] myArray = AFAWNZD(arrayLength);
// PrintArray(myArray);
// DON(myArray);