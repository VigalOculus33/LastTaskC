string[] FilterArrayByLength(string[] inputArray, int maxLength)
    {
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= maxLength)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string item in inputArray)
        {
            if (item != null && item.Length <= maxLength)
            {
               newArray[index] = item;
               index++;
            }
        }
        return newArray;
    }

Console.WriteLine("Введите элементы массива, разделенные пробелом:");
string[] inputArray = Console.ReadLine().Split(' ');
string[] newArray = FilterArrayByLength(inputArray, 3);

Console.WriteLine("Новый массив:");
foreach (string item in newArray)
{
    Console.WriteLine(item);
}
