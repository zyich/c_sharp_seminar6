/* Напишите программу которая перевернет
 одномерный массив 
 [1 2 3 4 5 ] -> [5 4 3 2 1 ]
*/

int [] CreateArray(int size, int min, int max)

{
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max+1);
    }
    return array;
}

string Print(int [] array )
{
    return string.Join(", ", array);
}

void Reverse (int[] array)
{
    int size = array.Length;

    for (int i = 0, j = size -1; i < j; i++,j--)
    {
        (array[i], array[j]) = (array[j], array[i]);// кортеж
    }
}

int [] array = CreateArray(7, -9, 9 );
Console.WriteLine($"Init array is [{Print(array)}]");
Reverse(array);
Console.WriteLine($"reverse array is [{Print(array)}]");
