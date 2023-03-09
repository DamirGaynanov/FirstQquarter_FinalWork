// Задача:
// Написать программу, которая из имеющигося массива строк  формирует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// оучге рьрйиист исключительно массивами
Console.WriteLine("Input Text 1");
string text1 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 2");
string text2 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 3");
string text3 = Console.ReadLine() ?? "";
Console.WriteLine("Input Text 4");
string text4 = Console.ReadLine() ?? "";

string[] arrText = { text1, text2, text3, text4 };
PrintArray(arrText);


void PrintArray(string[] arrayText)
{
    Console.Write($"[{text1}, {text2}, {text3}, {text4}] -> [");
    for (int i = 0; i < arrayText.Length; i++)
    {
        string str = arrayText[i];
        if (i < arrayText.Length - 2)
        {
            if (str.Length <= 3) Console.Write($"{arrayText[i]},");
        }
        else
        {
            if (str.Length <= 3) Console.Write($"{arrayText[i]}");
        }
    }
    Console.Write("]");
}