// Вид 1 (Не принивают, не возвращает)
void Method1()
{
    Console.WriteLine("Автор ...");

}
//Method1();

// Вид 2 (Принемает, не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

// Вид 2.1  
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", 4);

// Вид 3 (Не принимает, возвращает)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4 (Принимает, водвращает)
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Denis ");
//Console.WriteLine(res);


// Цикл for
string Method4(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(3, "Denis ");
//Console.WriteLine(res);

// Таблица умножения
// for(int i = 2; i < 10; i++)
// {
//     for(int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }

// Замена знаков (char) в тексте на другие 

// string text = "Светочи, светочи, светочи –"
//             + "В золоте зимний закат."
//             + "Весточки, весточки, весточки"
//             + "С неба: снежинки летят.";

// string Replace(string text, char oldLetter, char newLetter)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldLetter)
//         result = result + $"{newLetter}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string NewText = Replace(text, ' ', '|');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'к', 'k');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'о', '0');
// Console.WriteLine(NewText);


//   Сортируем массив 

int[] arr = { 1, 5, 4, 7, 6, 4, 1, 8};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array[minPosition]; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);