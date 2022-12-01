string[] ArrayLessThreeSymbol(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3) counter++;
    string[] newArray = new string[counter];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string? str;
Console.WriteLine($"Введите массив строк. Пример: Hello 2 World");
while ((str = Console.ReadLine()) == null) str = Console.ReadLine();
string[] massive = str.Split(' ');
string[] newMassive = ArrayLessThreeSymbol(massive);
Console.WriteLine($"[{String.Join(", ", newMassive)}]");