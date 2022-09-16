//Challenge 1
//string Name = "Kav";
//Console.WriteLine("Hello" + Name);

////Challenge 3
//string Name = Console.ReadLine();
//Console.WriteLine("Hello" + Name);

////Challenge 4
//int x = 7;
//int y = 3;
//int sum = x + y;
//Console.WriteLine(sum);

//Challenge 5
//double x = 5;
//double y = 2;
//double q = x / y;
//Console.WriteLine(q);

//Challenge 6
//double TemperatureC = 32.5;
//double TemperatureF = (TemperatureC * 9 / 5) + 32;
//Console.WriteLine(TemperatureF);

//Challenge 7
//Console.WriteLine("Please enter your age");
//string Input = Console.ReadLine();
//int Age = Convert.ToInt32(Input);
//if(Age > 18)
//{
//    Console.WriteLine("You are OLD");
//}
//else
//{
//    Console.WriteLine("You are young");
//}

//Challenge 8
//Console.WriteLine("Please enter a number");
//string a = Console.ReadLine();
//int x = Convert.ToInt32(a);
//Console.WriteLine("Please enter another number");
//string b = Console.ReadLine();
//int y = Convert.ToInt32(b);
//if (x > 0 && y < 0 || x < 0 && y > 0)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Challenge 9
//Console.WriteLine("Please enter a number");
//string input1 = Console.ReadLine();
//int num1 = Convert.ToInt32(input1);
//Console.WriteLine("Please enter a number");
//string input2 = Console.ReadLine();
//int num2 = Convert.ToInt32(input2);
//if((num1 >= -10 && num1 <= 10 ) || (num2 >= -10 && num2 <= 10))
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine ("False");
//}

//Challenge 10
//for(int i = 1; i < 100; i++)
//{
//    Console.WriteLine(i);
//}

//Challenge 11
//for(int i = 1; i <50; i = i+2)
//{
//    Console.WriteLine(i);
//}

//Challenge 11.2
//for(int i = 1; i < 50; i++)
//{
//    if(i%2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}

//Challenge 12
//for(int i = -300; i <= -30; i += 3)
//{
//    Console.WriteLine(i);
//}

//Challenge 13
//int magic = 6;
//int i = 1;
//while (i != 6)
//{
//    Console.WriteLine("Enter a number");
//    string a = Console.ReadLine();
//    int x = Convert.ToInt32(a);
//    if (x == 6)
//    {
//        break;
//    }
//}

//Challenge 14
//Console.WriteLine("Who brings presents at Christmas?");
//string FirstName = "";
//string Surname = "";
//while(FirstName != "Santa" || Surname != "Claus")
//{
//    FirstName = Console.ReadLine();
//    Surname = Console.ReadLine();
//}

//Array 1
//string[] students = { "PanPan", "Mahi", "Kav", "Kylen", "Nehchal" };
//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine(students[i]);
//}

//Array 2
//int[] nums = { 3, 5, 7, 9, 2 };
//Console.WriteLine(nums[0]);
//Console.WriteLine(nums[4]);

//Array 3
//int[] nums = { 9, 7, 5, 3, 1, 2, 4, 6, 8, 0 };
//for(int i = nums.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(nums[i]);
//}

//Array 4
//int[] numbers = { 5, 6, 3, 9, 1};
//int Total = 0;
//for(int i = 0; i < numbers.Length; i++)
//{
//    Total = Total + numbers[i];
//}
//double Avg = (double) Total / numbers.Length;
//Console.WriteLine(Avg);

//Array 5
//string[] Students = new string[5];
//for (int i = 0; i < Students.Length; i++)
//{
//    Students[i] = Console.ReadLine();
//}
//for(int x = 0; x < Students.Length; x++)
//{
//    Console.WriteLine(Students[x]);
//}

//Array 6
//Random RNG = new Random();
//int[] Numbers = new int[50];
//for (int i = 0; i < Numbers.Length; i++)
//{
//    int RandomNumber = RNG.Next(-100, 101);
//    Numbers[i] = RandomNumber;
//}

//int Highest = Numbers[0];
//for(int i = 0; i < Numbers.Length; i++)
//{
//    if (Numbers[i] > Highest)
//    {
//        Highest = Numbers[i];
//    }
//}
//Console.WriteLine(Highest);
//int Lowest = Numbers[0];
//for(int i = 0; i < Numbers.Length; i++)
//{
//    if (Numbers[i] < Lowest)
//    {
//        Lowest = Numbers[i];
//    }
//}
//Console.WriteLine(Lowest);

//Array 7
//string[] Names = { "PanPan", "Kav", "Kylen", "Mahi", "Nehchal" };
//Console.WriteLine("Enter a name");
//string SearchFor = Console.ReadLine();
//Boolean Found = false;
//for(int i = 0; i < Names.Length; i++)
//{
//    if (Names[i] == SearchFor)
//    {
//        Found = true;
//    }

//}
//if(Found == true)
//{
//    Console.WriteLine("Found");
//}
//else
//{
//    Console.WriteLine("Not Found");
//}

//Array 8
//string[] Names = { "Alan", "Bob", "Chris", "Dave", "Ed" };
//Console.WriteLine("Enter two names");
//string NameOne = Console.ReadLine();
//string NameTwo = Console.ReadLine();
//bool Found = false;
//for(int i = 0; i < Names.Length - 1; i++)
//{
//    if (Names[i] == NameOne && Names[i + 1] == NameTwo)
//    {
//        Found = true;
//    }
//}
//if (Found == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

////Array 9
//int[] Numbers = new int[100];
//Random RNG = new Random();
//for(int i = 0; i < Numbers.Length; i++)
//{
//    int RandomNumber = RNG.Next(1, 101);
//    Numbers[i] = RandomNumber;
//    if (Numbers[i] <= 60 && Numbers[i] > 30)
//    {
//        Console.WriteLine(Numbers[i]);
//    }
//}

//Array 10
//string[] Places = { "Thailand", "Germany", "Switzerland", "Berlin", "Thailand", "India", "Berlin" };
//string[] Duplicates = new string[100];
//for(int i = 0; i < Places.Length ; i++)
//{
//    for(int x = i + 1; x < Places.Length; x++)
//    {
//        if (Places[i] == Places[x])
//        {
//            Console.WriteLine(Places[i]);
//        }
//    }
//}

//Array 11
//string[] Names = { "Alan", "Bob", "Chris", "Dave", "Ed" };
//Console.WriteLine("Alan"+ " Bob"+ " Chris"+ " Dave"+ " Ed");
//Console.WriteLine("Enter a name");
//string DeleteName = Console.ReadLine();
//for (int i = 0; i < Names.Length; i++)
//{


//    if (Names[i] == DeleteName)
//    {
//        for (int x = i; x < Names.Length - 1; x++)
//        {
//            Names[x] = Names[x + 1];
//        }
//        Names[Names.Length - 1] = "";

//    }
//    Console.WriteLine(Names[i]);
//}

//Array 12
//for (int number = 2; number < 30; number++)
//{
//    bool isprime = true;
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            isprime = false;
//        }
//    }
//    if (isprime == true)
//    {
//        Console.Write(number + ", ");
//    }
//}