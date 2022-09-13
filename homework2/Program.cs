// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.OutputEncoding = System.Text.Encoding.UTF8;
int [,] massive = new int [5,7];
int minelement = 0;
int indexminelementstring = 0 ,indexminelementcolumn = 0;
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i,j] = new Random().Next(20);
        Console.Write("{0}  ",massive[i,j]);
    }
}
Console.WriteLine();


Console.WriteLine(new String('*',10));
Console.WriteLine();

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        if (massive[i,j] < minelement) 
        {
            minelement = massive[i,j];
            indexminelementstring = i;
            indexminelementcolumn = j;
        }
    }      
}
Console.WriteLine("minelement={0} indexminelementstring={1} indexminelementcolumn{2}",
                   minelement,    indexminelementstring,    indexminelementcolumn);

for (int i = 0; i < massive.GetLength(0); i++)
{
    if (i == indexminelementstring) continue;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        if (j == indexminelementcolumn) continue;
        Console.Write("{0}  ",massive[i,j]);
    }
    Console.WriteLine();
}












