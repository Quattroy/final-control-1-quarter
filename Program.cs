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
int arrayLenght = GetLenght("Введите длину массива: ","Ошибка ввода! Введите новое значение: ");
string[] array = GetArray(arrayLenght);
string[] arrayResult = GetResult(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
Console.WriteLine($"[{string.Join(",  ", arrayResult)}]");


// Пользователь задает длинну массива
int GetLenght(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}
// Формируем массив из введенных пользователем элементов
string[]GetArray(int arrayLenght)
{
    string[]arr = new string[arrayLenght];
    int index = 0;
    while(index < arrayLenght)
    {
        Console.Write($"Введите {index} элемент: ");
        arr[index] = Console.ReadLine() ?? "";
        index++;
    }
    return arr;
}

string[] GetResult(string[]array)
{
    string[] arrayResult = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arrayResult[i] = array[i];
        }

    }
    return arrayResult;
}