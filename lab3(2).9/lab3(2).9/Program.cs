using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести розмір квадратної матриці
        Console.WriteLine("Введіть розмір матриці (наприклад, 3 для матриці 3x3):");
        int size = int.Parse(Console.ReadLine());

        // Створюємо двовимірний масив (матрицю)
        int[,] matrix = new int[size, size];

        // Заповнюємо матрицю введеними користувачем значеннями
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Виводимо початкову матрицю
        Console.WriteLine("\nПочаткова матриця:");
        PrintMatrix(matrix);

        // Обертаємо матрицю на 90 градусів проти годинникової стрілки
        int[,] rotatedMatrix = RotateMatrix90Degrees(matrix);

        // Виводимо обернену матрицю
        Console.WriteLine("\nМатриця після обертання на 90 градусів проти годинникової стрілки:");
        PrintMatrix(rotatedMatrix);
    }

    // Метод для обертання матриці на 90 градусів проти годинникової стрілки
    static int[,] RotateMatrix90Degrees(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        int[,] rotatedMatrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                rotatedMatrix[size - j - 1, i] = matrix[i, j];
            }
        }

        return rotatedMatrix;
    }

    // Метод для виведення матриці
    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
