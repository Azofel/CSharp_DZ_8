Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void Mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
        randomArray[i,j] = rand.Next(1,9);
        }
    }
}

void PrintM(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
            {
            Console.Write($"{array[i,j]} ");
            }
        Console.WriteLine();
    }
}

Mas(m,n);
Console.WriteLine("Исходный массив: ");
PrintM(randomArray);

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
    {
        if (sum > SumLine(randomArray, i))
        {
            sum = SumLine(randomArray, i);
            minSum = i+1;
        }
    }
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");