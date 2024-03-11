﻿using System.Data.Common;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

//somando dados
int total = roll1 + roll2 + roll3;

//imprime total
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//verificando bônus
if(roll1 == roll2 && roll2 == roll3){
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total+= 6;
} 
else if(roll1 == roll2 || roll1 == roll3 || roll2 == roll3){
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}


//imprime venceu/perdeu
if (total >= 16){
    Console.WriteLine("You win a new car!");
} 
else if (total >= 10){
    Console.WriteLine("You win a new laptop!");
} 
else if (total == 7){
    Console.WriteLine("You win a trip for two!");
} else{
    Console.WriteLine("You win a kitten!");
}