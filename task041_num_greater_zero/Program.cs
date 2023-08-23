// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CheckNum(int num)
{
    if(num < 0)
    {
        Console.WriteLine($"Ошибка! Число должно быть положительным и целым!!!");
    }
    return;
}

int[] OutputMassive(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        Console.Write("-> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int PozitiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        count ++;        
    }
    return count;
}

Console.WriteLine("Сколько чисел вы хотите ввести? ");
Console.Write("-> ");
int number = Convert.ToInt32(Console.ReadLine());
CheckNum(number); //ввели число, проверили число

int[] pozitiveNum = OutputMassive(number);//начали ввод чисел, итог поместили в переменную
PrintArray(pozitiveNum); //вывели массив

Console.WriteLine($" ----> {PozitiveNumber(pozitiveNum)};"); //вывели итог

