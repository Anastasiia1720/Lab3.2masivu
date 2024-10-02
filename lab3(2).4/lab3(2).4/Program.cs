using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести кількість елементів масиву
        Console.WriteLine("Введіть кількість елементів масиву:");
        int length = int.Parse(Console.ReadLine());

        // Створюємо масив і заповнюємо його введеними значеннями
        int[] numbers = new int[length];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Обчислюємо суму додатних елементів
        int positiveSum = SumPositiveElements(numbers);

        // Виводимо результат
        Console.WriteLine("Сума всіх додатних елементів: " + positiveSum);
    }

    // Функція для обчислення суми додатних елементів
    static int SumPositiveElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
}

