//Function 1
//SayHello();
//void SayHello()
//{
//    Console.WriteLine("Hello");
//}

//Function 2
//SayHello("Bob");
//void SayHello(string Name)
//{
//    Console.WriteLine("Hello " + Name);
//}

//Function 3
//SayHello("Bob", "Smith");
//void SayHello(string FirstName, string SecondName)
//{
//    Console.WriteLine("Hello " + FirstName + " " + SecondName);
//}

//Function 4
//FindHighest(5, 9, 12);
//void FindHighest(int a, int b, int c)
//{
//    int Highest = a;
//    if (b > Highest)
//    {
//        Highest = b;
//    }
//    if (c > Highest)
//    {
//        Highest = c;
//    }
//    Console.WriteLine(Highest);
//}

//Funtion 5
//int Answer = Sum(4, 7);
//Console.WriteLine(Answer);
//int Sum(int a, int b)
//{
//    int c = a + b;
//    return c;
//}

//Function 6
//int Answer = Sum(8, 2, 3, 0, 7);
//Console.WriteLine(Answer);
//int Sum(int a, int b, int c, int d, int e)
//{
//    int f = a + b + c + d + e;
//    return f;
//}

//Function 7
//int[] Numbers = { 8, 2, -3, -1, -7 };
//int Answer = MultiplyArray(Numbers);
//Console.WriteLine(Answer);
//int MultiplyArray(int[] Numbers)
//{
//    int product = 1;
//    for(int i = 0; i < Numbers.Length; i++)
//    {
//        product = product * Numbers[i];
//    }
//    return product;
//}

//Function 8
//string Reversed = Rev("1234abcd");
//Console.WriteLine(Reversed);
//string Rev(string ToReverse)
//{
//    string NewReverse = "";
//    char Characters = ' ';
//    for (int i = ToReverse.Length - 1; i >= 0; i--)
//    {
//        Characters = ToReverse[i];
//        NewReverse = NewReverse + Characters;
//    }
//    return NewReverse;
//}

//Function 9
//bool InRange = IsInRange(8, 0, 100);
//Console.WriteLine(InRange);
//bool IsInRange(int x, int y, int z)
//{
//    if (x > y && x < z)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//Function 10
int[] Answer = new int[2];
int UpperLower = CountLowerAndUpperCase("The quick Brown Fox");
Console.WriteLine(Answer);
int CountLowerAndUpperCase(string example)
{
    int[] UpperAndLower = new int[2];
    int c = 0;
    int CounterUpperCase = 0;
    int CounterLowerCase = 0;
    for (int i = 0; i < example.Length; i++)
    {
        c = (int)example[i];
    }
    if(c >= 65 && c < 91)
    {
        CounterUpperCase++;
    }
    else if(c >= 97 && c < 123)
    {
        CounterLowerCase++;
    }
    for(int i = 0; i < 1; i++)
    {
    UpperAndLower[i] = CounterUpperCase;
    }
    for (int i = 1; i < 2; i++)
    {
        UpperAndLower[1] = CounterLowerCase;
    }
    for(int i = 0; i < UpperAndLower.Length; i++)
    {
        return UpperAndLower[i];
    }
    return UpperAndLower[];
}
