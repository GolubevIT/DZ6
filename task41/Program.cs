//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputAndSumPositiveNumber(int amount)
{
    int number = 0;
    int sum = 0;
    for (var i = 1; i <= amount; i++)
    {
        Console.Write($"Введите {i} число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            sum += number;
        }
    }
    return sum;
}
Console.Clear();
Console.Write("Введите количество чисел: ");
int amount= Convert.ToInt32(Console.ReadLine());
int sumPositiveNumber = InputAndSumPositiveNumber(amount);
Console.WriteLine($"Сумма чисел больше 0 равна {sumPositiveNumber}");
