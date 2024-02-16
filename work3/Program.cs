// Задача 3.
// Напишите программу, которая 
// Перевернёт одномерный массив 
// (Первый элемент станет последним, воторой - предпоследним и т.д)

// [1 3 5 6 7 8] => [8 7 6 5 3 1]



int[] GetArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(15);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("] => ");
}

void TurnOverToArray(int[] array)
{
    Console.Write("[ ");
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[array.Length - 1 -i];  
        Console.Write(newArray[i] + " ");    
    }
    Console.Write("]");
}


Console.Write("Ввидите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = GetArrayRndInt(size);
PrintArray(array); 
TurnOverToArray(array);
