// Показать двумерный массив размером m×n заполненный целыми числами

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());

int [,] myArray = new int [n,m];

for (int row = 0; row < n; row++) 
{
  for (int column = 0; column < m; column++)
  {
    myArray [row, column] = new Random().Next(0,100); 
  }
}
for (int row = 0; row < myArray.GetLength(0); row++) 
{
  for (int column = 0; column < myArray.GetLength(1); column++)
  {
      Console.Write(myArray[row,column] + "\t");  
  } 
  Console.WriteLine(); 
}
______________________________________________________________
// так код лучше не писать, каждый блок должен выполнять свою логику
Console.Clear();
Console.Write("Введите кол-во строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(-10,11);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}
___________________________________________________________________

void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }  
    }
} 
Console.WriteLine("Введите число m, n: ");
int m = int.Parse(Console.ReadLine()??"0");
int n = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [m,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
