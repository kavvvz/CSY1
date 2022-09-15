Random RNG = new Random();
int[] Results = new int[600];
int[] Count = new int[7];
for (int i = 0; i < 600; i++)
{
    int RandomNumber = RNG.Next(1, 7);
    Results[i] = RandomNumber;
}
for (int i = 0; i < 600; i++)
{
    if (i % 100 == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Person " + (i+100)/100);
    }
    Console.Write(Results[i] + "  ");
    if ((i+1)%10 == 0)
    {
        Console.WriteLine("");
    }  
}
for(int i = 0; i < Results.Length; i++)
{
    int num = Results[i];
    Count[num] = Count[num] + 1;
}
for(int i = 1; i < Count.Length; i++)
{
    Console.WriteLine("Number of " + i + "s = " + Count[i]);
}
for(int i = 1; i < Count.Length; i++)
{
    int Number = Count[i];
    if(Number > 125)
    {
        Console.WriteLine("Biased Towards: " + i);
    }
    if (Number < 125 && Number > 100)
    {
        Console.WriteLine("Slightly Biased Towards: " + i);
    }
    if (Number < 100 && Number > 75)
    {
        Console.WriteLine("Slightly Not Biased Towards: " + i);
    }
    if(Number == 100)
    {
        Console.WriteLine("Not Biased(at all)Towards: " + i);
    }
    if(Number < 75)
    {
        Console.WriteLine("Not Biased Towards: " + i);
    }
}
//Extension 1
for(int i = 1; i < Count.Length; i++)
{
    for(int x = 1; x < Count.Length - 1; x++)
    {
        if (Count[x] < Count[x+1])
        {
            int c = Count[x+1];
            Count[x+1] = Count[x];
            Count[x] = c;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Descending Order");
for (int i = 1; i < Count.Length; i++)
{
    Console.WriteLine(Count[i]);
}
//Extension 2
int even = 0;
int odd = 0;
for(int i = 0; i < Results.Length; i++)
{
    if (Results[i]%2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}
Console.WriteLine();
Console.WriteLine("Number of Even = " + even);
Console.WriteLine("Number of Odd = " + odd);
//Extension 3
for(int i = 0; i < Count.Length;i++)
{
    double Number = (double)(Count[i] / (double)Count[1]) * 100;

    for(int x = 1; x <= Number; x++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}