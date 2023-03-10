// Задача:
// Написать программу, которая из имеющигося массива строк  формирует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами

Console.WriteLine("Input Text 1");
string text1 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 2");
string text2 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 3");
string text3 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 4");
string text4 = Console.ReadLine() ?? "";

string[] inputArray = new string[] { text1, text2, text3, text4 };
string[] outputArray= arraySelective(inputArray);
PrintArray(inputArray);
Console.Write($" -> ");
PrintArray(outputArray);

string[] arraySelective(string[] arr1)
{
    string[] resultArray = new string[arr1.Length];
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        string str = arr1[i];
        if (str.Length <= 3)
        {
            resultArray[j] = str;
            j++;
        }
    }
    Array.Resize(ref resultArray, j);
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write($"]");
}