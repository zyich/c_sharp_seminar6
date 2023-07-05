/* 
Задача 40: Напишите программу, которая принимает
 на вход три числа и проверяет, может 
 ли существовать треугольник 
 с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона 
треугольника меньше суммы двух других сторон.
(теорема о неравенстве треугольника : каждая сторона треугольника 
меньше суммы двух других сторон)
*/


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
int a = GetNumber("Input number: ");
int b = GetNumber("Input number: ");
int c = GetNumber("Input number: ");

bool FindTriangle(int a, int b, int c){
    if((a < b+c) && (b < a+c) && (c < a+b)) return true;
    else return false;
}

string answer = FindTriangle(a, b, c) ? "Yes" : "No";
Console.WriteLine(answer);
