/*
Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/

int[] CreateArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int[] array = CreateArray(5, 0, 10);
Console.WriteLine($"Our list [{string.Join(", ", array)}]");


int[] CopyArray (int[] array){
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] copyArray = CopyArray(array);
Console.WriteLine($"Copy list[{string.Join(", ", copyArray)}]");