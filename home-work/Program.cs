//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbers(int m, int n)

{
    if (m == 0 || n == 0) return;

    if (m < n)
    {
        Console.Write($"{m}, ");
        PrintNaturalNumbers(m + 1, n);
        return;
    }

    else
    {
        if (m > n)
        {
            Console.Write($"{m}, ");
            PrintNaturalNumbers(m - 1, n);
            return;
        }
    }

    if (m == n)
    {
        Console.Write($"{m}, ");
        return;
    }
}

PrintNaturalNumbers(m, n);




//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
}

Console.Write($"A(m,n) = {FunctionAkk(m, n)}");





//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] array = { 1, 2, 5, 0, 10, 34 };

string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

Console.WriteLine($"{PrintArray(ArraySwap(array, array.Length - 1))}");
