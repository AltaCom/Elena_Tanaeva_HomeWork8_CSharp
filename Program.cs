/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного 
массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8


int[,] CreatRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

        }
return newArray;
}

void Show2dArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();

}
   Console.WriteLine();
}

int[,] Decrease2D (int[,] array)
{   
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    { 
        if (array[i,j] < array[i,j+1])
        { int temp = array[i, j+1];
        array[i,j+1] = array[i,j];
        array[i,j] = temp;           
        }  
    }
    }
}
return array;
}
    
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = CreatRandom2dArray(m, n, min, max);
Show2dArray(userArray);
int[,] finalArray = Decrease2D(userArray);
Show2dArray(finalArray);
*/


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[] MinSum (int[,] array)
{
int[] newArray = new int[array.GetLength(0)];
              
        
for (int i = 0; i < array.GetLength(0); i++)
    { 
        int sum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
                
        }
        newArray[i] = sum;                   
        
    }
return newArray;
}

void Index (int[] array)
{
         
    int iMin = 0;
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {               
        if (array[i] < array[iMin]) 
        i = iMin; 
        number = iMin + 1;      
        
    }
    Console.Write($"The minvalue row in {number}.");
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[,] userArray = CreateArray(m, n, min, max);
Show2DArray (userArray);
MinSum(userArray);
Index(MinSum(userArray)); 
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49

int[,] Multi (int[,] array1, int[,] array2)
{
    
    int a = array1.GetLength(0);
    int b = array1.GetLength(1);
    int c = array2.GetLength(0);
    int d = array2.GetLength(1);
    int [,] newArray3 = new int [a, d];

    if (b != c)  
    Console.Write("The false multiplication!");
     
    for (int i = 0; i < a; i++)
    {   
        for (int l = 0; l < d; l++)
        {       
            for (int j = 0; j < b; j++)
                {  
                    newArray3[i, l] += array1[i, j] * array2[j, l];                                   
                }                                 
        }
    }    
    return newArray3;
}

Console.Write("Input number of Array1 rows: ");
int m1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of Array1 columns: ");
int n1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input Array1 minValue: ");
int min1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input Array1 maxValue: ");
int max1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input number of Array2 rows: ");
int m2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of Array2 columns: ");
int n2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input Array2 minValue: ");
int min2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input Array2 maxValue: ");
int max2 = Convert.ToInt32(Console.ReadLine()); 

int[,] userArray1 = CreateArray(m1, n1, min1, max1);
Show2DArray (userArray1);
int[,] userArray2 = CreateArray(m2, n2, min2, max2);
Show2DArray (userArray2);
int[,] userArray3 = Multi(userArray1, userArray2);
Show2DArray(userArray3);
*/


/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

bool UniqueElements (int [ , , ] array, int element)
{
int count = 0;
for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                if (array[m, n, l] == element) count++;                
            }            
        }
    }
    if (count > 0) return true;
    else return false;
}


int[, ,] Create3DArray(int rows, int columns, int pages)
{
int[, ,] new3DArray = new int[rows, columns, pages]; 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
            int checknumber = new Random().Next(10, 100);
            while (UniqueElements(new3DArray, checknumber) == true) 
            checknumber = new Random().Next(10, 100);   
            new3DArray[i, j, k] = checknumber;
            }
        }    
     }
    return new3DArray;
}

void ShowUniqueMas (int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                
                Console.Write(array[i, j, k] + $"[{i}, {j}, {k}] ");
            }
               Console.WriteLine();
        }  
    }
}
   
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of pages: ");
int k = Convert.ToInt32(Console.ReadLine()); 

int[, ,] userArray = Create3DArray(m, n, k);
ShowUniqueMas(userArray);
*/




