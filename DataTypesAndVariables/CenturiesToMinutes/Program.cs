﻿short centuries = short.Parse(Console.ReadLine());
int years = centuries * 100;
int days = (int)(years * 365.2422m);
long hours = days * 24;
long minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");