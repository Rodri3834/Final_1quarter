// **Решение:**
// 
// 1. Создать массив строк.
// 2. Заполнить заданный массив случайными символами.
// 3. Распечатать полученный массив.
// 4. Посчитать количество элементов массива, длина которых меньше или равна 3м символам.
// 5. Создать новый массив строк.
// 6. Заполнить новый массив элементами из первоначального массива, длина которых меньше или равна 3м символам.
// 7. Распечатать полученный массив.
// 

// 1. Метод создания массива строк
string[] CreateArrayStrings(int size)
{
    return new string[size];
}

// 2. Метод заполнения массива случайными символами
void FillArrayStrings(string[] text, string selectChar, int lengthItemMin, int lengthItemMax)
{
    int size = text.Length;
    int count = selectChar.Length;
    for (int i = 0; i < size; i++)
    {
        int lengthItem = new Random().Next(lengthItemMin, lengthItemMax + 1);
        for (int j = 0; j < lengthItem; j++)
        {
            text[i] += selectChar[new Random().Next(0, count)];
        }
    }
}

// 3. Метод печати массива строк через разделитель
void PrintArrayStrings(string[] text, string separator)
{
    int size = text.Length;
    Console.Write('[');
    if (size > 0)
    {
        for (int i = 0; i < size - 1; i++)
        {
            Console.Write('"' + text[i] + '"' + separator);
        }
        Console.WriteLine('"' + text[size - 1] + '"' + ']');
    }
    else Console.WriteLine(']');
}
