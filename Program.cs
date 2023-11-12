/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
int num = NumberKeyboard("Введите длину массива: ");
string [] Array = new string [num];
StringKeyboard(Array);
Console.Clear();
System.Console.WriteLine("Укажите максимальную длину строки");
int Digits = NumberKeyboard("для поиска в заданном массиве: ");

int size = CountOfArray (Array, Digits);
string [] newArray = new string [size];
ThreeDigitsArray(Array, Digits);

System.Console.WriteLine($"Задан массив из {Array.Length} элементов");
Print(Array);
System.Console.WriteLine();
System.Console.WriteLine($"Новый массив из {newArray.Length} элементов: ");
Print(newArray);

Console.ReadKey();

int NumberKeyboard(string word)  //  Метод "ввода числа с клавиатуры"
{
    Console.Write(word);
    int number = System.Int32.Parse(Console.ReadLine());
    return number;
}

void StringKeyboard(string [] elements)  //  Метод "заполнение одномерного массива с клавиатуры"
{
    int length = elements.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("Введите элемент: ");
        elements[i] = Console.ReadLine();
    }
    return;
}

int CountOfArray (string [] array, int Digits) // Метод для определения количества элементов в массиве с длиной строки не больше заданного количества символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= Digits)
                count++;
        }    
    }
    return count;
}

string [] ThreeDigitsArray (string [] array, int Digits) //  Метод для записи элементов длиной не больше заданного количества символов в новый массив
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= Digits)
            {
                newArray[j] = array[i];
                j++;
            }    
        }    
    }
    return newArray;
}

void Print(string [] array)  // Метод печати массива
{
    if (array.Length == 0) {
        System.Console.WriteLine("[]");
        return;
    }    
    System.Console.WriteLine($"['{string.Join("', '", array)}']");
    return;
}