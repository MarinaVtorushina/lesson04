
// string[,]table = new string[2,5];
// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 2; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// void PrintArray(int[,]matrix)
// {
// int[,]matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLenght(0); i++)
// {
//     for (int j = 0; j < matrix.GetLenght(1); j++)
//     {
//         Console.WriteLine($"{matrix[i, j]} ");
//     }
// }
//     Console.WriteLine();
// }

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

}