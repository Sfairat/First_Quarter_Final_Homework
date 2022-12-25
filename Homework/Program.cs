// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string[] array = {"hello", "2", "word", ":-}"};
int count = 0;
int length = 3;

int ArrayLength(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length)
        {
            count++;
        }
    }
    return count;
}

void ElementSelection(string[] arr, string[] arr1)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length)
        {
            arr1[index] = arr[i];
            index++;
        }
    }
}

void PrintArray(string[] collection)
{
    int count = collection.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        if (position == count - 1)
        {
            Console.Write($"'{collection[position]}']");
            break;
        }
        Console.Write($"'{collection[position]}', ");
        position++;
    }
}

ArrayLength(array);
string[] newArray = new string[count];
ElementSelection(array, newArray);
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);