Random RNG = new Random();
int Start = 100;
int Bet = 0;
int Number = 0;
string Colour = "";
while (Start !>= 0)
{
    Console.WriteLine("Place your bets, you have " + Start + "$ available");
    string Input = Console.ReadLine();

    Bet = Convert.ToInt32(Input);
    if(Bet > Start || Bet <= 0)
    {
        Console.WriteLine("Invalid");
        break;
    }
    Console.WriteLine("Do you want to choose a number or a color?");
    string Choice = Console.ReadLine();
    if(Choice == "Number" || Choice == "number" || Choice == "NUMBER")
    {
        Console.WriteLine("Enter a number between 0 and 36");
        string Num = Console.ReadLine();
        Number = Convert.ToInt32(Num);
        
    }
    else if(Choice == "colour" || Choice == "Colour" || Choice == "COLOUR" || Choice == "color" || Choice == "Color" || Choice == "COLOR")
    {
        Console.WriteLine("Choose Red or Black");
        Colour = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Invalid");
        break;
    }
    int RandomNumber = RNG.Next(0, 37);
    Console.WriteLine(RandomNumber);
    if(Choice == "colour" || Choice == "Colour" || Choice == "COLOUR" || Choice == "color" || Choice == "Color" || Choice == "COLOR")
    {
        if (Colour == "Black" || Colour == "black" || Colour == "BLACK")
        {

            if (RandomNumber % 2 == 0)
            {
                Start = Bet * 2 + (Start - Bet);
                Console.WriteLine("Money left = " + Start + "$");
            }
            else
            {
                Start = Start - Bet;
                Console.WriteLine("Money left = " + Start + "$");
            }
        }
        else if (Colour == "Red" || Colour == "red" || Colour == "RED")
        {
            if (RandomNumber % 2 == 0)
            {
                Start = Start - Bet;
                Console.WriteLine("Money left = " + Start + "$");
            }
            else
            {
                Start = Bet * 2 + (Start - Bet);
                Console.WriteLine("Money left = " + Start + "$");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
            break;
        }
    }
    else if(Choice == "number" || Choice == "NUMBER" || Choice == "Number")
    {
        if (RandomNumber == Number)
        {
            Start = Bet * 36 + (Start - Bet);
            Console.WriteLine("Money left = " + Start + "$");
        }
        else
        {
            Start = Start - Bet;
            Console.WriteLine("Money left = " + Start + "$");
        }
    }


    if (Start == 0)
    {
        break;
    }
}