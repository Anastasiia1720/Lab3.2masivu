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

        // Викликаємо метод перевірки паліндрома
        bool isPalindrome = CheckPalindrome(numbers);

        // Виводимо результат
        if (isPalindrome)
        {
            Console.WriteLine("Масив є паліндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є паліндромом.");
        }
    }

    // Метод для перевірки, чи є масив паліндромом
    static bool CheckPalindrome(int[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (array[i] != array[length - i - 1])
            {
                return false; // Якщо хоч один елемент не збігається, масив не є паліндромом
            }
        }
        return true; // Якщо всі елементи збігаються, масив є паліндромом
    }
}
