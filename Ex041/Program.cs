/*Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/


Console.Write($"Enter the number M, which corresponds to the number of numbers: ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[Num];

void InputNumbers(int Num)
{
    for (int i = 0; i < Num; i++)
    {
        Console.Write($"Enter {i + 1} Number: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(Num);

Console.WriteLine($"The number of array elements greater than 0: {Comparison(massiveNumbers)} ");