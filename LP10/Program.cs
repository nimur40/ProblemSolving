/*
 * 11. Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
The pattern like :

1
22
333
4444
 */

int i, j;
for(i=1;i<=4;i++)
{
    for(j=1;j<=i;j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}