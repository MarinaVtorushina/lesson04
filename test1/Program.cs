
string[,]table = new string[2,5];
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 3; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}


int[,]matrix = new int[3, 4];
void PrintArray(int[,]matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine($"{matrix[i, j]} ");
    }
}
    Console.WriteLine();
}

// void FillArray(int[,]matrix)
// {
// for (int i = 0; i < matrix.GetLenght(0); i++)
// {
//     for (int j = 0; j < matrix.GetLenght(1); j++)
//     {
//         matrix[i,j] = new Random().Next(1,10);
//     }
// }
// }
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);

void Zadacha24()
{
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36 
int number = 7;
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.Write($"{sum} ");
}

Zadacha24();

void Zadacha26()
{
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


    int number = 456;
    int current = number;
    int count = 0;
    while (current > 0)
    {
        current = current /= 10;
        count = count + 1;
    }
    Console.WriteLine($"Количество чисел в {number} = {count}");
}
Zadacha26();

void Zadacha28()
{
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
int number = 7;
int result = 1;
for (int i = 1; i <= number; i++)
{
    result = i * result;
}
Console.Write($"{result} ");
}
Zadacha28();
void Zadacha30()
{
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]
Random random = new Random(); 
int size = random.Next(4, 10);
int[] numbers = new int [size]; //массив создан
Console.WriteLine(size);
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] num)
{

    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
    }
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}
}
Zadacha30();

void Zadacha25()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);
}
Zadacha25();

void Zadacha27()
{
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
}
Zadacha27();
void Zadacha29()
{
//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
}
Zadacha29();