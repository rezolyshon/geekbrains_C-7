// Задача 47 
// class Program
// {
//     static void Main()
//     {
//         // Задаем размеры массива m и n
//         int m = 3;
//         int n = 4;

//         // Создаем двумерный массив размером m x n
//         double[,] array = new double[m, n];

//         // Заполняем массив случайными вещественными числами от -10 до 10
//         Random random = new Random();
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 array[i, j] = random.NextDouble() * 20 - 10;
//             }
//         }

//         // Выводим полученный массив на экран
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Задача 50

// class Program
// {
//     static void Main()
//     {
//         // Задаем двумерный массив
//         int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4}
//         };

//         // Считываем позицию элемента
//         Console.Write("Введите позицию элемента в массиве (через запятую): ");
//         string[] position = Console.ReadLine().Split(',');
//         int row = int.Parse(position[0]) - 1;
//         int col = int.Parse(position[1]) - 1;

//         // Проверяем, существует ли элемент в массиве
//         if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
//         {
//             // Если элемент существует, выводим его значение
//             int element = array[row, col];
//             Console.WriteLine($"Значение элемента: {element}");
//         }
//         else
//         {
//             // Если элемент не существует, выводим сообщение об ошибке
//             Console.WriteLine("Такого элемента в массиве нет.");
//         }
//     }
// }

// Задача 52
// int[,] array = new int[,] { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };
// int columns = array.GetLength(1); // количество столбцов

// for (int j = 0; j < columns; j++)
// {
// double sum = 0; // сумма элементов столбца
// for (int i = 0; i < array.GetLength(0); i++)
// {
// sum += array[i, j];
// }
// double average = sum / array.GetLength(0); // среднее арифметическое столбца
// Console.WriteLine("Среднее арифметическое столбца {0}: {1:F2}", j, average);
// }
