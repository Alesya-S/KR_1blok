/* Написать программу, которая из имеющего массива строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа. Первоначалный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"] 
["Russia", "Denmark", "Kazan"] -> [] */


int n = 3;
int size = 6;
string[] array1 = new string [size];
Console.WriteLine($"Введите символы, обозначающие массив {size} раз через ентер, без пробелов");
Fillarray (array1);
Console.Clear();
Printarray (array1);
Console.WriteLine();
Console.WriteLine("Новый массив: ");

if (GetSizeOfSecondArray(array1) == 0)
{
    Console.WriteLine("Искомых элементов массива для переноса - нет");
}
else
{
    string[] array2 = TransferElements(array1);
    Printarray (array2);
}

void Fillarray (string[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine()?? "";
    }
}

void Printarray (string[] array)
{
    int arrLeng = array.Length;
    Console.Write("[");
    for (int i = 0; i < arrLeng; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

int GetSizeOfSecondArray (string[] array)
{
    int secondsize = 0;
    for (int i = 0; i < size; i++)
    {
      if (array[i].Length <= n)
        {
           secondsize++;
        }
    }
    return secondsize;
}

string[] TransferElements (string[] array)
{
    string[] array2 = new string[GetSizeOfSecondArray(array1)];
    for (int i = 0;  i < size; i++){
        for (int j = 0;  i < size; i++){
          if (array1[i].Length <= n)
          {
              array2[j] = array1[i];
              j++;
          }
        }
    }
    return array2;
}

