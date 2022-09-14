// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// В программе ведётся поиск всех минимальных элементов и удаление строк и столбецов, 
// на пересечении которых расположены наименьшие элементы.

Console.OutputEncoding = System.Text.Encoding.UTF8;

void FillPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write("{0,5}", arr[i, j]);
        }
        Console.WriteLine();
    }
}

void FindMinElement(int[,] arr, int[] minelementindex)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minelementindex[0])
            {
                minelementindex[0] = arr[i, j];
            }
        }
    }
}

void ReplaceIndexPositionsMinElements(int[,] arr, int[] minelementindex)// Подмена элементов на минус один ,
                                                                       // т.е. вычёркиваем столбцы и строки , которые связаны с минимумом
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == minelementindex[0]) continue;
            if (i == minelementindex[1] || j == minelementindex[2]) arr[i, j] = -1;     
        }
    }
    arr[minelementindex[1], minelementindex[2]] = -1;
}

void IsMinElement(int[,] arr, int[] minelementindex) // Поиск ещё одинаковых минимумов
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == minelementindex[0])
            {
                minelementindex[1] = i;
                minelementindex[2] = j;
                ReplaceIndexPositionsMinElements(arr, minelementindex);
            }
        }
    }
}

void PrintOutcome(int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == -1) continue;
            Console.Write("{0,5}", arr[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] massive = new int[15, 7];
int min = 10000;                        // Завысим  значение минимального элемента: min = 10000;
int[] minelementindex = { min, 0, 0 }; // Создадим массив с 3 элементами : 
                                      // 1-ый минимальное значение элемента
                                     // 2-ой индекс по горизонтали минимального значения элемента
                                    // 3-ий индекс по вертикали минимального значения элемента

Console.WriteLine("Итак , наш исходный массив такой ");
FillPrintArray(massive);                 // Печать исходного массива
Console.WriteLine(new String('*', 50));

FindMinElement(massive, minelementindex); // Поиск минимума

IsMinElement(massive, minelementindex);  // Поиск повторяющихся минимальных элементов
Console.WriteLine($"После удаления строк и столбцов, на пересечении которых расположены наименьшие элементы {minelementindex[0]} будет так");
PrintOutcome(massive);
