// Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или же указание, что такого элемента нет. Если элементов несколько, то выводим позицию каждого. 
// Двумерный массив задаётся на ваш выбор.
Console.WriteLine("Создаем двумерный массив, элементы которого будут заполнены случайными натуральными числами до 10.");
Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение элемента, который будем искать (от 1 до 10):");
int x = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[m,n];
int count = 0;

FillArrayRandom(array);
Console.WriteLine("В созданном массиве:");
PrintArray(array);
FindArray(x,array);

int[,] FillArrayRandom(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1,11);
        }

    }
    return array;
}
void PrintArray(int[,] array) 
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

void FindArray(int x, int[,] array)
{
    int a = x;
    int count = 0;
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
            {
                if (array[i,j]==x)
                {
                    count++;
                    Console.WriteLine($"Индекс {count} элемента {a} : [{i},{j}]");
                }
            }
    }
    if (count == 0)
    {
       Console.WriteLine("Такого числа в массиве нет"); 
    }
}