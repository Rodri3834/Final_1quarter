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

// 4. Метод определения количества элементов массива заданной длины
int CountItems(string[] text, int maxLengthItem)
{
    int size = text.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (text[i].Length <= maxLengthItem)
            count++;
    }
    return count;
}

// 5. Метод заполнения массива элементами нужной длины 
void FillResultStringArray(string[] primary, string[] result, int maxLengthItem)
{
    int size = primary.Length;
    int countItem = 0;
    for (int i = 0; i < size; i++)
    {
        if (primary[i].Length <= maxLengthItem)
        {
            result[i - countItem] = primary[i];
        }
        else countItem++;
    }
}


string chars = "AaBbCcDdEeFfGgHhIiGgKkLlNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789!@#$%^&*()-=+_[]{}";

string[] text = CreateArrayStrings(7);
FillArrayStrings(text, chars, 1, 6);
PrintArrayStrings(text, ", ");

int maxLength = 3;
int count = CountItems(text, maxLength);
Console.WriteLine($"Количество элементов массива с длинной не более трёх символов - {count}");

string[] result = CreateArrayStrings(count);
FillResultStringArray(text, result, maxLength);
PrintArrayStrings(result, ", ");