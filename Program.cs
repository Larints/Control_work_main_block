// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размерность массива: ");
int N = int.Parse(Console.ReadLine()!);

string[] someArray = new string[N];
FillArray(someArray);
Console.WriteLine($"Первоначальный массив -> [{String.Join(",", someArray)}]");
ResultArray(someArray);
string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение для элемента {i}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void ResultArray(string[] array)
{
    int length = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            length++;
        }
    }

    string[] resultArray = new string[length];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    Console.WriteLine($"Итоговый массив -> [{String.Join(",", resultArray)}]");
}