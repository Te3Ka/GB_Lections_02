void FillArray(int[] arrayRandom)
{
    int length = arrayRandom.Length;
    int index = 0;
    while (index < length)
    {
        arrayRandom[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] arrayPrint)
{
    int length = arrayPrint.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(arrayPrint[index] + " ");
        index++;
    }
}

int IndexOf(int[] arraySearchPoition, int find)
{
    int length = arraySearchPoition.Length;
    int index = 0;
    int position = -1;

    while (index < length)
    {
        if (arraySearchPoition[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 10);
Console.WriteLine(pos);