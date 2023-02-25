/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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
void PrintNumbers(int number)
{
    if (number < 1) // базовый случай, когда n становится меньше 1
    {
        return;
    }
    Console.Write(number + ", ");
    PrintNumbers(number - 1); // вызываем функцию с аргументом на единицу меньше текущего значения
}

int number = GetNumber("Введите число больше 0:");
PrintNumbers(number);