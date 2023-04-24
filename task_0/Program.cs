//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



// Console.Write("Введите числа: ");
// string numbers = Console.ReadLine();
// char [] ar = numbers.ToCharArray();
// Console.Write($" {String.Join(" ", ar)} ->");

int CountNumbersPositive(int[] numb)
{
    int count = 0;
    for (int i = 0; i < numb.Length; i++)
    {
        if (numb [i] > 0 ) count ++;
    }
    return count;
}

Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = CountNumbersPositive(arr);
Console.WriteLine($"{String.Join(", ", arr)} --> {count} ");