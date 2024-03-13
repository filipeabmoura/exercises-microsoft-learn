using System;

int num = 0;
string? entrada;

do
{
    Console.WriteLine("Digite um número inteiro entre 5 e 10:");
    entrada = Console.ReadLine();
    num = int.Parse(entrada);
} while (num < 5 || num > 10);

Console.WriteLine(num);