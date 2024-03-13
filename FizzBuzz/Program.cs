using System;

for (int i = 1; i <= 100; i++){
    if (i % 3 == 0)
    {
        if (i % 5 == 0)
        {
            //divisivel por 3 e 5
            Console.WriteLine($"{i} - FizzBuzz");
        }
        else
        {  
            //divisivel apenas por 3
            Console.WriteLine($"{i} - Fizz");
        }
    } 
    else if (i % 5 == 0)
    {
        //divisivel apenas por 5
        Console.WriteLine($"{i} - Buzz");
    }
    else {
        //não é divisível por 3 e nem por 5
        Console.WriteLine(i);
    }
}