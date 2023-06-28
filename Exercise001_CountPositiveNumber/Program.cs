// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputCount (string text) 
{     
    System.Console.Write(text);     
    return Convert.ToInt32(Console.ReadLine()); 
} 

void InputNumbers(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) 
        count +=1;
    }
    Console.WriteLine($"Введено положительных чисел: {count}");
}

int num = InputCount ("Введите количество чисел для вычисления: ");
InputNumbers(num);