using System;

Random random = new Random();
int current = 0;

do
{
    current = random.Next(11);
    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

