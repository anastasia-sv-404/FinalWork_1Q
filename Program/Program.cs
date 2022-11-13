Console.WriteLine("Введите первый строковый элемент массива: ");
string firstElement = Console.ReadLine()!;

Console.WriteLine("Введите второй строковый элемент массива: ");
string secondElement = Console.ReadLine()!;

Console.WriteLine("Введите третий строковый элемент массива: ");
string thirdElement = Console.ReadLine()!;

Console.WriteLine("Введите четвертый строковый элемент массива: ");
string fourthElement = Console.ReadLine()!;

string[] array = { firstElement, secondElement, thirdElement, fourthElement };

Console.WriteLine();
Console.Write($"Исходный массив строк - это [{String.Join(", ", array)}].");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Введите искомую длину элемента исходного массива (значение меньше или равно заданного): ");
int count = int.Parse(Console.ReadLine()!);

string[] arrayNew = getNewArray(array, count, getNewArrayLength(array, count));

Console.WriteLine();
Console.Write($"Новый массив строк - это [{String.Join(", ", arrayNew)}].");




int getNewArrayLength(string[] collection, int searchCount) // найти длину нового массива при выборе из исх.массива элементов с длиной меньше либо равно заданной
{
    int lgth = 0;

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length == searchCount || collection[i].Length < searchCount)
        {
            lgth++;
        }
    }

    return lgth;
}

string[] getNewArray(string[] collection, int searchCount, int lgth) // заполнить строковый массив нужной длины
{

    string[] collectionNew = new string[lgth];

    for (int i = 0, j = 0; i < collection.Length; i++)
    {
        if (collection[i].Length == searchCount || collection[i].Length < searchCount)
        {
            collectionNew[j] = collection[i];
            j++;
        }
    }

    return collectionNew;
}

