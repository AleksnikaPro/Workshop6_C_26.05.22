// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
/*
Console.Clear();
Console.WriteLine("В двумерном массиве показать позицию числа, заданного пользователем"
    +"или указать, что такого элемента нет");
Console.Write("Введите количество столбцов: ");
int sizeColumn = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeRow =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите искомое число: ");
int Number =  int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[sizeRow,sizeColumn];
bool isHas = false;

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        array[i,j] = new Random().Next(0,10);


for (int i=0; i<sizeRow; i++)
{
    Console.WriteLine();
    for (int j=0; j<sizeColumn; j++)
        Console.Write($"{array[i,j]} ");
}

Console.WriteLine();

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        if (array[i,j] == Number)
        {
            Console.WriteLine($"Число {Number} есть в заданном массиве в {j+1} строке, в {i+1} столбце");
            isHas = true;
        }
if (!isHas) Console.WriteLine($"Числа {Number} нет в заданном массиве");
_______________________________________________________________________________________*/
/*
void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
    
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}
(int,int)? IndexOf(int[,] matrix, int value)
{
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value)
                return (i,j);
    return null;
}
Console.Write("Enter amout of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix elements: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix:");
PrintMatrix(matrix);
Console.Write("Enter value to find in matrix: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int,int)? position = IndexOf(matrix,value);
if(position==null)
    Console.WriteLine("There is no value in matrix");
else
    Console.WriteLine($"Position of element: {position.Value.Item1} {position.Value.Item2}");
_________________________________________________________________*/

// Второй вариант
/*
void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
    
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}
(int,int)? IndexOf(int[,] matrix, int value)
{
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value)
                return (i,j);// возвращает координаты // и сразу прерывает код, когда находит то что нам надо
    return null;// если ничего не нашли
}
Console.Write("Enter amout of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix elements: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix:");
PrintMatrix(matrix);
Console.Write("Enter value to find in matrix: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int,int)? position = IndexOf(matrix,value);
Console.WriteLine(position != null 
    ? $"Position of element: {position.Value.Item1} {position.Value.Item2}" // да
    : "There is no value in matrix");// нет
    ________________________________________________________________________*/

void FillArray(int[,] array)
{
    Random rnd           = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.Next(0,2);
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void SearchElement(int[,] array, int number)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    bool   found         = false;
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j] == number)
            {
             Console.WriteLine($"Элемент {number} находится на позиции [{i},{j}]");
             found = true;
            }
        }       
    }
    if(!found) Console.WriteLine($"Элемент {number} не найден в массиве!");
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
Console.Write("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine()?? "");

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
SearchElement(array,number);
