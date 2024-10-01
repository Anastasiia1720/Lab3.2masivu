using System;

class Program
{
    static void Main()
    {
        // Задаємо масив цілих чисел
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Обчислюємо суму всіх елементів масиву
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Обчислюємо середнє арифметичне
        double average = (double)sum / numbers.Length;

        // Виводимо результат
        Console.WriteLine("Середнє арифметичне: " + average);
    }
}

