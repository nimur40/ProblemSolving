
/*
 input number: 5
even number is= 1 3 5 
total sum= 9
 */

Console.Write("input number: ");
int n=Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i=1;i<=n;i++)
{
    if(i%2==1)
    {
        Console.Write("{0} ", i);
        sum = sum +i;
    }
}
Console.WriteLine("total sum= {0}",sum);