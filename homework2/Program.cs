// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.OutputEncoding = System.Text.Encoding.UTF8;

{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
            Console.Write("{0}  ",arr[i,j]);
}
Console.WriteLine();


string FindMinElement(int [,] arr)
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












