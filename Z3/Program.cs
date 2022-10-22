// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i%2==0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = j+i*matrix.GetLength(1);
                Console.Write($"{matrix[i, j]} \t");
            }
        }
        if(i%2==1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] =(i+1)*matrix.GetLength(1)-(j+1);
                Console.Write($"{matrix[i, j]} \t");
            }
        }
        
        Console.WriteLine();
        
    }
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);