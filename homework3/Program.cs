// Сформировать трехмерный массив c не повторяющимися двузначными числами ,
// показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i,j,k] = new Random().Next(10,100);
            }
        }
    }
}

void PrintArray(int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write("massive[i,j,k] = {0}: i = {1} , j = {2}, k = {3} ;      ",arr[i,j,k],i,j,k);
            }
            Console.WriteLine();
        }
    }
}


int [,,] massive = new int [2,6,3];
FillArray(massive);
PrintArray(massive);



