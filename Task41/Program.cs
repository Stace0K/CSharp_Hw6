// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Вводим число
int Number (string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

//Заполняем массив числами, введенными пользователем
int[] FillArray(int figure)
{
    int[] array = new int[figure];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Number($"Введите следующее число массива: ");
    }
    return array;
}

//Считаем числа больше нуля
int CountPositive(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count = count + 1;
    }
    return count;
}

int length = Number("Введите кол-во элементов массива: ");
int[] array = FillArray(length);
Console.WriteLine($"Введено чисел больше нуля: {CountPositive(array)}");