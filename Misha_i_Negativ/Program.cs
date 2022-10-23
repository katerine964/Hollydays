Console.Clear();
void InputChMatrix(int[,] matrix, char[,] chmatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 2);
            if(matrix[i,j]==0)
            chmatrix[i, j] = 'b';
            else
            chmatrix[i,j]='w';
            Console.Write($"{chmatrix[i, j]} \t");

        }
    Console.WriteLine();
    }
}
int Func (int[,]matrix1, int[,]matrix2)
{
    int count=0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if(matrix1[i,j]==matrix2[i,j])
            {
                count++;
            }    
        }
    }
    return count;

}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix1 = new int [n, m];
char [,] chmatrix1 = new char [n, m];
int [,] matrix2 = new int [n, m];
char [,] chmatrix2 = new char [n, m];
Console.WriteLine();
Console.WriteLine("Исходное изображение:");
InputChMatrix(matrix1, chmatrix1);
Console.WriteLine("Сформированный негатив:");
InputChMatrix(matrix2, chmatrix2);
Console.WriteLine("Число неправильных пикселей:");
Console.WriteLine(Func(matrix1,matrix2));