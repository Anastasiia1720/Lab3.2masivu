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

        // Обчислюємо добуток від'ємних елементів
        int negativeProduct = ProductOfNegativeElements(numbers);

        // Виводимо результат
        if (negativeProduct != 1) // Якщо є хоча б один від'ємний елемент
        {
            Console.WriteLine("Добуток всіх від'ємних елементів: " + negativeProduct);
        }
        else
        {
            Console.WriteLine("У масиві немає від'ємних елементів.");
        }
    }

    // Функція для обчислення добутку від'ємних елементів
    static int ProductOfNegativeElements(int[] array)
    {
        int product = 1;
        bool hasNegative = false; // Перевірка на наявність від'ємних елементів

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                product *= array[i];
                hasNegative = true;
            }
        }

        return hasNegative ? product : 1; // Якщо немає від'ємних, повертаємо 1
    }
}
