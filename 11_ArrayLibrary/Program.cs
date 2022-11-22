﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
    int index = collection.Length;
    int count = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
             position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int pos = IndexOf(array, 4);
Console.WriteLine(pos);