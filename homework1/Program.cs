// Найти произведение двух матриц
/*

            | x1 x2 x3 |   | a1 a2 a3 |   | (x1*a1+x2*b1+x3*c1) (x1*a2+x2*b2+x3*c2) (x1*a3+x2*b3+x3*c3) |
            | y1 y2 y3 | * | b1 b2 b3 | = | (y1*a1+y2*b1+y3*c1) (y1*a2+y2*b2+y3*c2) (y1*a3+y2*b3+y3*c3) |
            | z1 z2 z3 |   | c1 c2 c3 | = | (z1*a1+z2*b1+z3*c1) (z1*a2+z2*b2+z3*c2) (z1*a3+z2*b3+z3*c3) |

            Длина столбцов первой матрицы должна быть равна длине строк второй матрицы!
                           

*/

Console.OutputEncoding = System.Text.Encoding.UTF8;

void FillMatrix1and2 (int [,] array1,int [,] array2)
{

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = new Random().Next(1,5);
        }
    }
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i,j] = new Random().Next(1,5);
        }
    }

}

void PrintMatrix1and2(int [,] array1,int [,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i,j]}  ");
        }
        Console.WriteLine();
    }
}


void ProductMatrix1and2(int [,] array1,int [,] array2,int [,] array3)
{

    int temporary = 0;
    for (int m = 0; m < array1.GetLength(0); m++)
    {   
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                temporary += array1[m,j]*array2[j,n];
            }
            array3[m,n]= temporary;
            temporary = 0;
        }
    }
}



void PrintMatrix3 (int [,] array3)
{


    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write($"{array3[i,j]}  ");
        }
        Console.WriteLine();
    }

}


Console.WriteLine("Введите размеры первой матрицы A1(x1,y1): ");
Console.WriteLine("Введите значение \" x1 \" для первой матрицы A1(x1,y1): ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Введите значение \" y1 \" для первой матрицы A1({x1},y1): ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Введите размер второй матрицы A2({y1},y2): ");
Console.WriteLine($"Введите значение \" y2 \" для второй матрицы A2({y1},y2): ");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Вы ввели матрицу A1({x1},{y1}) и матрицу A2({y1},{y2}): ");

int [,] arr1 = new int [x1,y1]; //  Первый множитель (двумерная матрица)
int [,] arr2 = new int [y1,y2]; //  Второй множитель (двумерная матрица)
int [,] arr3 = new int [x1,y2]; //  Произведение (третья двумерная матрица - изначально с нулями)

FillMatrix1and2(arr1,arr2);
PrintMatrix1and2(arr1,arr2);
ProductMatrix1and2(arr1,arr2,arr3);

Console.WriteLine();
Console.WriteLine("Произведением  A1(x1,y1) на А2(х2,у2)  будет следующая матрица: ");
Console.WriteLine();
PrintMatrix3(arr3);

