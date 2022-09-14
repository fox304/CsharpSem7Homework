// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.OutputEncoding = System.Text.Encoding.UTF8;



void FillPrintArray(int [,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
            Console.Write("{0}  ",arr[i,j]);
}
Console.WriteLine();

    }
}

int FindMinElement(int [,] arr)
{
    int minelement = 10000;
    for (int i = 0;i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < minelement) minelement = arr[i,j];      
        } 
    }
    return  minelement;
}

void FindIndexAllMinElements(int [,] arr,int [] indexminelements,int min)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j] == min)
                {
                    indexminelements[0] = i;
                    indexminelements[1] = j;
                    InsertMinesOne(arr,indexminelements);
                }
                
                
            }      
    }
}

void InsertMinesOne(int [,] arr,int [] indexminelements)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == indexminelements[1] || i == indexminelements[0]) arr[i,j] = -1;
        }
    }
    Print(arr);
    Console.WriteLine();
}

void PrintOutcome(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == -1) continue;
            Console.Write("{0}  ",arr[i,j]);
        }
        Console.WriteLine();
    }

}
void Print(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            Console.Write("{0} \t",arr[i,j]);
        }
        Console.WriteLine();
    }

}




int [] indexminelements = new int [2];
int [,] massive = new int [5,7];

FillPrintArray(massive);
Console.WriteLine(new String('*',10));

int min = FindMinElement(massive);


FindIndexAllMinElements(massive,indexminelements,min);






Console.WriteLine();





