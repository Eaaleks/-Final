/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int SumNaturalNumbers(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}

int m = GetNumber("Введите число");
int n = GetNumber("Введите число");
int sum = SumNaturalNumbers(m, n);

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}");

