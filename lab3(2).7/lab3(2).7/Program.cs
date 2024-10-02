using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести розмір матриці (квадратна матриця)
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

        // Обчислюємо суму елементів по головній діагоналі
        int diagonalSum = SumMainDiagonal(matrix);

        // Виводимо результат
        Console.WriteLine("Сума елементів по головній діагоналі: " + diagonalSum);
    }

    // Функція для обчислення суми елементів по головній діагоналі
    static int SumMainDiagonal(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i]; // Додаємо елемент по головній діагоналі
        }
        return sum;
    }
}

