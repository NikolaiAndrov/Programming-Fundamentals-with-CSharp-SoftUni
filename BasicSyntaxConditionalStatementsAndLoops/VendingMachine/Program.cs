﻿string input = (Console.ReadLine());
double sum = 0;

while (input != "Start")
{
    double coin = double.Parse(input);

    if (coin == 0.1)
    {
        sum += coin;
    }
    else if (coin == 0.2)
    {
        sum += coin;
    }
    else if (coin == 0.5)
    {
        sum += coin;
    }
    else if (coin == 1)
    {
        sum += coin;
    }
    else if (coin == 2)
    {
        sum += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }

    input = (Console.ReadLine());
}


string product = Console.ReadLine();

while (product != "End")
{
    if (product == "Nuts")
    {
        if (sum >= 2)
        {
            sum -= 2;
            Console.WriteLine("Purchased nuts");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Water")
    {
        if (sum >= 0.7)
        {
            sum -= 0.7;
            Console.WriteLine("Purchased water");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Crisps")
    {
        if (sum >= 1.5)
        {
            sum -= 1.5;
            Console.WriteLine("Purchased crisps");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Soda")
    {
        if (sum >= 0.8)
        {
            sum -= 0.8;
            Console.WriteLine("Purchased soda");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Coke")
    {
        if (sum >= 1)
        {
            sum -= 1;
            Console.WriteLine("Purchased coke");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }

    product = Console.ReadLine();
}

Console.WriteLine($"Change: {sum:F2}");