using System;

int heroHealth = 10;
int monsterHealth = 10;

int damage = 0;
Random attack = new Random();

do
{
    //hero attack
    damage = attack.Next(11);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
    if(monsterHealth <= 0)
    {
        Console.WriteLine("Hero Wins!");
        continue;
    }

    //hero attack
    damage = attack.Next(11);
    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
    if(heroHealth <= 0)
    {
        Console.WriteLine("Monster Wins.");
        continue;
    }

} while (heroHealth > 0 && (monsterHealth > 0));

//um pouco redundante, mas usei as estruturas solicitadas pelo exercicio