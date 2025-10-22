# Решения задач по работе с массивами в C#

## Задачи с одномерными массивами

### Задача 1
**Условие:** Ввести массив, состоящий из 14 элементов целого типа. Найти количество элементов четных по значению.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1: Подсчет четных элементов в массиве из 14 элементов");
        
        int[] array = new int[14];
        
        // Ввод массива
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        // Подсчет четных элементов
        int evenCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        
        // Вывод результата
        Console.WriteLine($"Количество четных элементов: {evenCount}");
        
        // Демонстрация с тестовыми данными
        int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
        int testEvenCount = 0;
        
        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
        
        foreach (int num in testArray)
        {
            if (num % 2 == 0) testEvenCount++;
        }
        
        Console.WriteLine($"Четных элементов в тестовом массиве: {testEvenCount}");
    }
}
```

### Задача 2
**Условие:** Ввести массив, состоящий из 12 элементов целого типа. Получить новый массив, заменив значение пятого элемента среднеарифметическим исходного массива.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 2: Замена пятого элемента на среднее арифметическое");
        
        int[] array = new int[12];
        
        // Ввод массива
        Console.WriteLine("Введите 12 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        // Вычисление среднего арифметического
        double average = array.Average();
        
        // Создание нового массива
        int[] newArray = new int[12];
        Array.Copy(array, newArray, array.Length);
        
        // Замена пятого элемента (индекс 4)
        newArray[4] = (int)Math.Round(average);
        
        // Вывод результатов
        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
        
        // Демонстрация с тестовыми данными
        int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        double testAverage = testArray.Average();
        int[] testNewArray = (int[])testArray.Clone();
        testNewArray[4] = (int)Math.Round(testAverage);
        
        Console.WriteLine("\nТестовый пример:");
        Console.WriteLine("Исходный: [" + string.Join(", ", testArray) + "]");
        Console.WriteLine($"Среднее: {testAverage:F2}");
        Console.WriteLine("Результат: [" + string.Join(", ", testNewArray) + "]");
    }
}
```

### Задача 3
**Условие:** Задан целочисленный массив, состоящий из 11 элементов. Найти количество элементов, абсолютное значение которых больше среднего арифметического.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 3: Подсчет элементов с |значением| > среднего арифметического");
        
        int[] array = new int[11];
        
        // Ввод массива
        Console.WriteLine("Введите 11 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        // Вычисление среднего арифметического
        double average = array.Average();
        
        // Подсчет элементов
        int count = 0;
        Console.WriteLine("\nЭлементы, |значение| которых больше среднего:");
        
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) > average)
            {
                Console.WriteLine($"array[{i}] = {array[i]}, |{array[i]}| = {Math.Abs(array[i])}");
                count++;
            }
        }
        
        Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
        Console.WriteLine($"Количество элементов: {count}");
        
        // Демонстрация с тестовыми данными
        int[] testArray = {-10, 2, -5, 8, 1, -12, 3, 15, -2, 7, 4};
        double testAverage = testArray.Average();
        int testCount = testArray.Count(x => Math.Abs(x) > testAverage);
        
        Console.WriteLine("\nТестовый пример:");
        Console.WriteLine("Массив: [" + string.Join(", ", testArray) + "]");
        Console.WriteLine($"Среднее: {testAverage:F2}");
        Console.WriteLine($"Количество элементов |x| > среднего: {testCount}");
    }
}
```

### Задача 4
**Условие:** Ввести целочисленный массив, состоящий из 10 элементов. Поменять местами максимальный и первый элементы.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 4: Обмен максимального и первого элементов");
        
        int[] array = new int[10];
        
        // Ввод массива
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
        
        // Поиск индекса максимального элемента
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        
        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
        Console.WriteLine($"Первый элемент: {array[0]} (индекс 0)");
        
        // Обмен элементов
        if (maxIndex != 0)
        {
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;
            
            Console.WriteLine("\nПосле обмена: [" + string.Join(", ", array) + "]");
        }
        else
        {
            Console.WriteLine("\nМаксимальный элемент уже находится на первой позиции.");
        }
        
        // Демонстрация с тестовыми данными
        int[] testArray = {3, 7, 1, 9, 2, 8, 4, 6, 5, 10};
        Console.WriteLine("\nТестовый пример:");
        Console.WriteLine("До обмена: [" + string.Join(", ", testArray) + "]");
        
        int testMaxIndex = Array.IndexOf(testArray, testArray.Max());
        int temp2 = testArray[0];
        testArray[0] = testArray[testMaxIndex];
        testArray[testMaxIndex] = temp2;
        
        Console.WriteLine("После обмена: [" + string.Join(", ", testArray) + "]");
    }
}
```

### Задача 5
**Условие:** Ввести целочисленный массив, состоящий из 9 элементов. Поменять местами максимальный и минимальный элементы массива.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 5: Обмен максимального и минимального элементов");
        
        int[] array = new int[9];
        
        // Ввод массива
        Console.WriteLine("Введите 9 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
        
        // Поиск индексов максимального и минимального элементов
        int maxIndex = 0, minIndex = 0;
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
                maxIndex = i;
            if (array[i] < array[minIndex])
                minIndex = i;
        }
        
        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
        Console.WriteLine($"Минимальный элемент: {array[minIndex]} (индекс {minIndex})");
        
        // Обмен элементов
        if (maxIndex != minIndex)
        {
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            
            Console.WriteLine("\nПосле обмена: [" + string.Join(", ", array) + "]");
        }
        else
        {
            Console.WriteLine("\nВсе элементы массива одинаковы.");
        }
        
        // Демонстрация с тестовыми данными
        int[] testArray = {5, 2, 8, 1, 9, 3, 7, 4, 6};
        Console.WriteLine("\nТестовый пример:");
        Console.WriteLine("До обмена: [" + string.Join(", ", testArray) + "]");
        
        int testMaxIndex = Array.IndexOf(testArray, testArray.Max());
        int testMinIndex = Array.IndexOf(testArray, testArray.Min());
        
        int temp3 = testArray[testMaxIndex];
        testArray[testMaxIndex] = testArray[testMinIndex];
        testArray[testMinIndex] = temp3;
        
        Console.WriteLine("После обмена: [" + string.Join(", ", testArray) + "]");
    }
}
```

## Задачи с двумерными массивами

### Задача 1
**Условие:** Отсортировать по возрастанию элементов последней строки целочисленный двухмерный массив 3×4.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1: Сортировка массива 3×4 по последней строке");
        
        int[,] matrix = new int[3, 4];
        
        // Ввод матрицы
        Console.WriteLine("Введите элементы матрицы 3×4:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);
        
        // Сортировка по элементам последней строки (индекс 2)
        SortMatrixByLastRow(matrix);
        
        Console.WriteLine("\nМатрица после сортировки по последней строке:");
        PrintMatrix(matrix);
        
        // Демонстрация с тестовыми данными
        int[,] testMatrix = {
            {1, 5, 9, 2},
            {3, 7, 1, 8},
            {6, 2, 4, 3}
        };
        
        Console.WriteLine("\nТестовый пример:");
        Console.WriteLine("До сортировки:");
        PrintMatrix(testMatrix);
        
        SortMatrixByLastRow(testMatrix);
        
        Console.WriteLine("После сортировки:");
        PrintMatrix(testMatrix);
    }
    
    static void SortMatrixByLastRow(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // Сортировка столбцов по элементам последней строки
        for (int i = 0; i < cols - 1; i++)
        {
            for (int j = 0; j < cols - 1 - i; j++)
            {
                if (matrix[rows - 1, j] > matrix[rows - 1, j + 1])
                {
                    // Обмен столбцов
                    for (int row = 0; row < rows; row++)
                    {
                        int temp = matrix[row, j];
                        matrix[row, j] = matrix[row, j + 1];
                        matrix[row, j + 1] = temp;
                    }
                }
            }
        }
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

### Задача 2
**Условие:** Дан двухмерный массив 7×7. Найти сумму модулей отрицательных нечетных элементов.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 2: Сумма модулей отрицательных нечетных элементов в массиве 7×7");
        
        int[,] matrix = new int[7, 7];
        Random random = new Random();
        
        // Заполнение матрицы случайными числами от -20 до 20
        Console.WriteLine("Генерация матрицы 7×7 со случайными числами:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                matrix[i, j] = random.Next(-20, 21);
            }
        }
        
        Console.WriteLine("\nМатрица:");
        PrintMatrix(matrix);
        
        // Поиск и суммирование модулей отрицательных нечетных элементов
        int sum = 0;
        Console.WriteLine("\nОтрицательные нечетные элементы:");
        
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
                {
                    Console.WriteLine($"matrix[{i},{j}] = {matrix[i, j]}, |{matrix[i, j]}| = {Math.Abs(matrix[i, j])}");
                    sum += Math.Abs(matrix[i, j]);
                }
            }
        }
        
        Console.WriteLine($"\nСумма модулей отрицательных нечетных элементов: {sum}");
        
        // Альтернативный ввод с клавиатуры (закомментировано для демонстрации)
        /*
        Console.WriteLine("Введите элементы матрицы 7×7:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        */
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

### Задача 3
**Условие:** Дан двухмерный массив 5×6. Определить среднее арифметическое положительных элементов каждого столбца.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 3: Среднее арифметическое положительных элементов каждого столбца (5×6)");
        
        int[,] matrix = new int[5, 6];
        Random random = new Random();
        
        // Заполнение матрицы случайными числами от -10 до 15
        Console.WriteLine("Генерация матрицы 5×6 со случайными числами:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                matrix[i, j] = random.Next(-10, 16);
            }
        }
        
        Console.WriteLine("\nМатрица:");
        PrintMatrix(matrix);
        
        // Вычисление среднего арифметического положительных элементов каждого столбца
        Console.WriteLine("\nСреднее арифметическое положительных элементов по столбцам:");
        
        for (int j = 0; j < 6; j++)
        {
            int sum = 0;
            int count = 0;
            
            Console.Write($"Столбец {j}: положительные элементы: ");
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] > 0)
                {
                    sum += matrix[i, j];
                    count++;
                    Console.Write($"{matrix[i, j]} ");
                }
            }
            
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"→ Среднее: {average:F2}");
            }
            else
            {
                Console.WriteLine("→ Положительных элементов нет");
            }
        }
        
        // Альтернативный ввод с клавиатуры (закомментировано)
        /*
        Console.WriteLine("Введите элементы матрицы 5×6:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        */
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

### Задача 4
**Условие:** Дана вещественная квадратная матрица порядка 5. Найти наименьший элемент на побочной диагонали.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 4: Наименьший элемент на побочной диагонали матрицы 5×5");
        
        double[,] matrix = new double[5, 5];
        Random random = new Random();
        
        // Заполнение матрицы случайными вещественными числами
        Console.WriteLine("Генерация матрицы 5×5 со случайными вещественными числами:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); // от -10 до 10
            }
        }
        
        Console.WriteLine("\nМатрица:");
        PrintMatrix(matrix);
        
        // Поиск наименьшего элемента на побочной диагонали
        // Побочная диагональ: элементы с индексами (i, n-1-i), где n - размер матрицы
        double minElement = matrix[0, 4]; // Первый элемент побочной диагонали
        int minRow = 0, minCol = 4;
        
        Console.WriteLine("\nЭлементы побочной диагонали:");
        for (int i = 0; i < 5; i++)
        {
            int j = 4 - i; // Столбец побочной диагонали
            Console.WriteLine($"matrix[{i},{j}] = {matrix[i, j]}");
            
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
        
        Console.WriteLine($"\nНаименьший элемент на побочной диагонали:");
        Console.WriteLine($"Значение: {minElement}");
        Console.WriteLine($"Позиция: [{minRow},{minCol}]");
        
        // Альтернативный ввод с клавиатуры (закомментировано)
        /*
        Console.WriteLine("Введите элементы матрицы 5×5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
        */
    }
    
    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],7:F2}");
            }
            Console.WriteLine();
        }
    }
}
```

### Задача 5
**Условие:** Отсортировать по убыванию элементов последнего столбца целочисленный двухмерный массив 5×4.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 5: Сортировка массива 5×4 по убыванию элементов последнего столбца");
        
        int[,] matrix = new int[5, 4];
        Random random = new Random();
        
        // Заполнение матрицы случайными числами
        Console.WriteLine("Генерация матрицы 5×4 со случайными числами:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix[i, j] = random.Next(1, 21);
            }
        }
        
        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);
        
        // Сортировка строк по убыванию элементов последнего столбца (индекс 3)
        SortMatrixByLastColumn(matrix);
        
        Console.WriteLine("\nМатрица после сортировки по убыванию последнего столбца:");
        PrintMatrix(matrix);
        
        // Альтернативный ввод с клавиатуры (закомментировано)
        /*
        Console.WriteLine("Введите элементы матрицы 5×4:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        */
    }
    
    static void SortMatrixByLastColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int lastCol = cols - 1;
        
        // Сортировка строк по элементам последнего столбца (по убыванию)
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - 1 - i; j++)
            {
                if (matrix[j, lastCol] < matrix[j + 1, lastCol])
                {
                    // Обмен строк
                    for (int col = 0; col < cols; col++)
                    {
                        int temp = matrix[j, col];
                        matrix[j, col] = matrix[j + 1, col];
                        matrix[j + 1, col] = temp;
                    }
                }
            }
        }
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

### Задача 6
**Условие:** В матрице А(4 строки, 3 столбца) поменять... *(условие не завершено)*

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 6: Операции с матрицей 4×3");
        Console.WriteLine("Примечание: Условие задачи не завершено.");
        Console.WriteLine("Ниже представлены возможные варианты операций:");
        
        int[,] matrix = new int[4, 3];
        Random random = new Random();
        
        // Заполнение матрицы
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = random.Next(1, 21);
            }
        }
        
        Console.WriteLine("\nИсходная матрица 4×3:");
        PrintMatrix(matrix);
        
        // Вариант 1: Поменять местами первую и последнюю строки
        Console.WriteLine("\nВариант 1: Обмен первой и последней строк");
        SwapRows(matrix, 0, 3);
        PrintMatrix(matrix);
        
        // Восстановление исходной матрицы
        SwapRows(matrix, 0, 3);
        
        // Вариант 2: Поменять местами первый и последний столбцы
        Console.WriteLine("\nВариант 2: Обмен первого и последнего столбцов");
        SwapColumns(matrix, 0, 2);
        PrintMatrix(matrix);
        
        // Восстановление исходной матрицы
        SwapColumns(matrix, 0, 2);
        
        // Вариант 3: Поменять местами максимальный и минимальный элементы
        Console.WriteLine("\nВариант 3: Обмен максимального и минимального элементов");
        SwapMinMax(matrix);
        PrintMatrix(matrix);
    }
    
    static void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
    }
    
    static void SwapColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }
    
    static void SwapMinMax(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int min = matrix[0, 0], max = matrix[0, 0];
        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;
        
        // Поиск минимального и максимального элементов
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minRow = i;
                    minCol = j;
                }
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        
        Console.WriteLine($"Минимальный элемент: {min} в позиции [{minRow},{minCol}]");
        Console.WriteLine($"Максимальный элемент: {max} в позиции [{maxRow},{maxCol}]");
        
        // Обмен элементов
        matrix[minRow, minCol] = max;
        matrix[maxRow, maxCol] = min;
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
```

## Дополнительные замечания

### Компиляция и запуск
Для компиляции и запуска программ на C# используйте следующие команды:

```bash
# Компиляция
csc Program.cs

# Запуск
Program.exe
```

Или используйте Visual Studio / Visual Studio Code с установленным .NET SDK.

### Особенности реализации

1. **Ввод данных**: В каждой программе предусмотрен ввод данных с клавиатуры, а также демонстрационные примеры с заранее заданными значениями.

2. **Обработка ошибок**: Для учебных целей обработка исключений упрощена. В реальных приложениях рекомендуется добавить проверки на корректность введенных данных.

3. **Вывод результатов**: Все программы выводят подробную информацию о процессе вычислений для лучшего понимания алгоритмов.

4. **Алгоритмы сортировки**: Использованы простые алгоритмы сортировки (пузырьковая сортировка) для наглядности. Для больших массивов рекомендуется использовать более эффективные алгоритмы.

### Возможные улучшения

- Добавление проверки корректности ввода данных
- Использование более эффективных алгоритмов сортировки
- Создание отдельных методов для различных операций
- Добавление unit-тестов для проверки корректности работы программ