// В двумерном массиве n×k заменить четные элементы на противоположные
/*
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k:");
int k = int.Parse(Console.ReadLine());

int [,] myArray = new int [n,k];

for (int row = 0; row < n; row++) 
{
  for (int column = 0; column < k; column++)
  {
    myArray [row, column] = new Random().Next(0,100);
    Console.Write(myArray[row,column] + " "); 
  }
  Console.WriteLine();
}
Console.WriteLine();
for (int row = 0; row < myArray.GetLength(0); row++) 
{
  for (int column = 0; column < myArray.GetLength(1); column++)
  {      
      if (myArray[row,column] % 2 == 0) 
      {
         myArray[row,column] = - myArray[row,column];  
        
        Console.Write(myArray[row,column] + " ");

      }
        
  } 
  Console.WriteLine(); 
}
______________________________________________________________*/
/*
int[,] matr = new int [3,4];
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,10);
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          
            if(matr[i,j] % 2 == 0)  matr[i,j] = -matr[i,j];
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
    _____________________________________________________________*/

void FillArray(int[,] array)
{
    Random rnd = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.Next(-100,101);
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void ChangeEvenElements(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j]%2 == 0) array[i,j] = -array[i,j];
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();      
    }

}
//--------------------------------------------------------------------------------------------+
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()?? "");

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
ChangeEvenElements(array);
PrintArray(array);