/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
int GetNumber(string description){

    int number;
    Console.WriteLine($"{description} => ");

    while(true){
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
    
}
int n = GetNumber("Input number: ");

List<int> list = new List<int>();
list.Add(0);
list.Add(1);

for(int i = 2; i < n; i++){
    list.Add(list[i-1]+list[i-2]);
}

Console.WriteLine($"[{string.Join(", ", list)}]");