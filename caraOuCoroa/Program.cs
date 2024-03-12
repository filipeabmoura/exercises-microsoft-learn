using System;


Random coin = new Random();
int flip = coin.Next(2);
string result = flip == 0 ? "heads" : "tails";

Console.WriteLine(result);