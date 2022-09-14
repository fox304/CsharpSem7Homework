//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.OutputEncoding = System.Text.Encoding.UTF8;
int k = 15; // Колличество строк 
int [,] array = new int [k,k*4]; // Создание матрицы в 4 раза шире (c нулями) , чтобы не вызвать исключения
array[0,k] = 1;
for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[i,j] = array[i-1,j-1] + array [i-1,j+1]; // Заполнение массива числами 
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == 0) Console.Write("     "); // Заполняем пробелами вместо нулей
        else Console.Write("{0,5}",array[i,j]); // Выравниваем и печатаем числа
    }
    Console.WriteLine();
}