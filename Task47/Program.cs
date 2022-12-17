// Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
// m = 3, n = 4.

Console.WriteLine("Создаем двумерный массив, элементы которого нужно будет ввести Вам. Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[m,n];

FillArray(array);
PrintArray(array);

double[,] FillArray(double[,] array)                    
{
    for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите элементы {i+1} строки через пробел(' '). Их должно быть ровно {n}!");
            double[] array1 = Console.ReadLine().Split(' ').Select(х => double.Parse(х)).ToArray();
            if (array1.Length != n) 
            { 
                Console.WriteLine("Вы ввели неверное количество элементов.");
                break;
            }
            else 
            {
                int index = 0;
                for (int j = 0; j < n; ++j)
                {
                    array[i,j] = array1[index];
                    index++;
                }
            }
        }
    return array;
}

void PrintArray(double[,] array) 
{
    Console.WriteLine("Введенный массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
}
