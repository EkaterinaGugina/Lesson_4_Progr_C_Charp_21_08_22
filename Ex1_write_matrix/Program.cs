// Сздание пустой (заполненной нулями) матрицы размера (2, 5) и заполнение её случайными числами
// String.Empty - пустые строковые значения
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
// string[,] table = new string[2,5];
// table[1, 2] = "слово";

 //создание пустой (из нулей) матрицы
void FillArray(int[,] matr)
{
for (int rows = 0; rows < matr.GetLength(0); rows++)
{
 for (int columns = 0; columns < matr.GetLength(1); columns++)
 {
 Console.Write($"{matr[rows, columns]}");
 }
 Console.WriteLine();
}
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);    // заполняем числами из [1; 10)
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
