/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу
 которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */


Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
PrintArray(matrix);
NumRowMinSumEl(matrix);


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    int minValue = sum;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    
}













 void PrintArray(int[,] matr)          //метод создания массива чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    } 


}
void NumRowMinSumEl(int[,] matr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        minRow += matr[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumRow += matr[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка с минимальной суммой элеметов");
}