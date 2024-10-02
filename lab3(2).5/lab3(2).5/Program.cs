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

        // Запитуємо елемент для пошуку
        Console.WriteLine("Введіть елемент для пошуку:");
        int target = int.Parse(Console.ReadLine());

        // Знаходимо найменший індекс елемента
        int index = FindSmallestIndex(numbers, target);

        // Виводимо результат
        if (index != -1)
        {
            Console.WriteLine("Найменший індекс елемента " + target + " у масиві: " + index);
        }
        else
        {
            Console.WriteLine("Елемент " + target + " не знайдено у масиві.");
        }
    }

    // Метод для пошуку найменшого індексу заданого елемента
    static int FindSmallestIndex(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                return i; // Повертаємо індекс першого входження елемента
            }
        }
        return -1; // Якщо елемент не знайдено, повертаємо -1
    }
}
