/*
12. Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
The pattern like :

1
2 3
4 5 6
7 8 9 10  
*/
int i, j;
for (i = 1; i <= 4; i++)
{
    for (j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}
