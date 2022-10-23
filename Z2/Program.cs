// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}
int Max(int [,] matrix)
{
    int max=matrix[0,0];
    int i1=0;
    int i2=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]>max)
            { 
                max=matrix[i,j];     
            }
            else
                max=max;     
        }
        
    }
    return max;
}
int Count(int[,] matrix, int a)
{
   int count=0;
   for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if(matrix[i,j]==a)
                {count++;
                break;}
        }
        
    }
    return count;             
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Наибольший элемент: "+Max(matrix));
Console.WriteLine();
Console.WriteLine ("Количество строк, в которых он присутствует: "+Count(matrix, Max(matrix)));
onsole.WriteLine();