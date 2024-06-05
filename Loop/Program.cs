﻿
/*7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
Test Data :
Input upto the table number starting from 1 : 8
Expected Output :
Multiplication table from 1 to 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
 */


Console.WriteLine("input number: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("fixed number: ");
int m=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=n; i++)
{
    for(int j=1;j<=m;j++)
    {
        Console.WriteLine("{0}x{1}={2}",i,j,i*j);
    }
    Console.WriteLine("");
}
