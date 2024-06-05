/*
 Write a program in C# Sharp to display a right angle triangle with an asterisk.

Sample Output:

*
**
***
****

 */

int i, j;
for(i=1;i<=4;i++)
{
    for(j=1;j<=i;j++)
    {
        Console.Write(j);//*
    }
    Console.WriteLine("");
}