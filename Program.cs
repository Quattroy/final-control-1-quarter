// //Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не 
//  рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
int arrayLenght = GetLenght("Введите длину массива: ", "Ошибка ввода! Введите новое значение: ");
string[] array = GetArray(arrayLenght);
int newLenght = GetNewLenght(array);
string[] arrayResult = GetResult(array, newLenght);
Console.WriteLine($"[{string.Join(",  ", array)}] => [{string.Join(",  ", arrayResult)}]");

/////////////////////////////////////////////////////////////////////////////////////////////////////////

int GetLenght(string message, string error)// Пользователь задает длинну массива
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

string[] GetArray(int arrayLenght) // Формируем массив из введенных пользователем элементов
{
    string[] arr = new string[arrayLenght];
    int index = 0;
    while (index < arrayLenght)
    {
        Console.Write($"Введите {index} элемент: ");
        arr[index] = Console.ReadLine() ?? "";
        index++;
    }
    return arr;
}

int GetNewLenght(string[] array) //ищем длину для нового массива
{
    int lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lenght++;
        }
    }
    return lenght;
}


string[] GetResult(string[] array, int newLenght)//формируем и заполняем новый массив, включая в него элементы длина которых меньше, либо равна 3 символам
{
    string[] arrayResult = new string[newLenght];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[index] = array[i];
            index++;
        }
    }
    return arrayResult;
}