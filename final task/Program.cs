//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
//  алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] array = new string [5];
FillStringArray(array);
PrintArray(array);

string [] newArray = GetResultArray(array);
PrintArray(newArray);


string [] FillStringArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
       Console.WriteLine("Введите элементы массива строк: ");
       array[i]= Console.ReadLine();
    }
    return array;
}

void PrintArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int NumbersOfArrayWithThreeElements(string [] array) 
{
int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            n++;
        }
    }
    return n;
}

string [] GetResultArray(string [] array)
{
    int n = NumbersOfArrayWithThreeElements(array);
    string [] result = new string [n];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
             result[j] = array[i];
             j++;
        }
    }
    return result;
}
