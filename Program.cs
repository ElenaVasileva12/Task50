// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

//двумерный массив с случайным вводом (универсальный)
int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
  
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j=0;j<matrix.GetLength(1); j++)    //или columns
        {
        matrix[i,j] = i+j;
        }
    }
    return matrix;
}

//вывод массива на экран (универсальный)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j=0;j<matrix.GetLength(1); j++)    //или columns
        {
            Console.Write($"{matrix[i, j], 3}");  //5 это чтобы разделять числа
        }
        Console.WriteLine();
    }
}

int ElementRows()
{
    Console.WriteLine("Введите строку позиции: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    if (rows>= 0) return rows; 
    else return -1;
}

int ElementColums()
{
    Console.WriteLine("Введите столбец позиции: ");
    int colums =Convert.ToInt32(Console.ReadLine());
    if (colums >= 0)  return colums; 
    else  return -1;
}

void ElementPosition(int[,] matrix,int rows, int colums)
{
    if (matrix.GetLength(0) >= rows && matrix.GetLength(1) >= colums)
    {
       Console.WriteLine($"({rows},{colums}) -> такой элемент присутсвует в массиве");
    }
    else Console.WriteLine($"({rows},{colums}) -> такого элемента нет в массиве");
}



int[,] array2d=CreateMatrixRndInt(3,4);
PrintMatrix(array2d);

int rows = ElementRows();
int colums = ElementColums();

if (colums == -1 || rows == -1)
{
    Console.WriteLine("Ошибка, позиция элемента не может быть меньше нуля");
    return;
}

ElementPosition(array2d,rows,colums);

