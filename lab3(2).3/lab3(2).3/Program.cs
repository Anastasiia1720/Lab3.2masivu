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

        // Виводимо всі парні числа
        Console.WriteLine("Парні числа в масиві:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
