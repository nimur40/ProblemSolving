/*
 * 8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100
 */
Console.Write("input number: ");
int n=Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;
for (i=1;i<=n;i++)
{
    
    Console.Write("output: ");
    int s=Convert.ToInt32(Console.ReadLine());
    if(s%2==0)
    {
        sum = sum + s;
    }
}
Console.WriteLine("input odd number={0} and sum is= {1}",i,sum);


