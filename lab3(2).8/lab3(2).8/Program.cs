using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести розмір матриці
        Console.WriteLine("Введіть кількість рядків матриці:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість стовпців матриці:");
        int columns = int.Parse(Console.ReadLine());

        // Створюємо двовимірний масив (матрицю)
        int[,] matrix = new int[rows, columns];

        // Заповнюємо матрицю введеними користувачем значеннями
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Запитуємо користувача ввести індекс стовпця для обчислення добутку
        Console.WriteLine("Введіть індекс стовпця (починається з 0) для обчислення добутку:");
        int columnIndex = int.Parse(Console.ReadLine());

        // Перевірка, чи введений індекс стовпця є коректним
        if (columnIndex < 0 || columnIndex >= columns)
        {
            Console.WriteLine("Неправильний індекс стовпця.");
            return;
        }

        // Обчислюємо добуток елементів вказаного стовпця
        int columnProduct = ProductOfColumn(matrix, columnIndex);

        // Виводимо результат
        Console.WriteLine("Добуток елементів стовпця " + columnIndex + ": " + columnProduct);
    }

    // Функція для обчислення добутку елементів вказаного стовпця
    static int ProductOfColumn(int[,] matrix, int column)
    {
        int product = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            product *= matrix[i, column];
        }
        return product;
    }
}

