Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration == 0){
    //assinatura expirou
    Console.WriteLine("Your subscription has expired.");
}
else if(daysUntilExpiration == 1){
    //expira em 1 dia
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5){
    //expira em menos de 5 dias
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10){
    //expira em menos de 10 dias
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} 

//informar desconto
if(daysUntilExpiration >= 1 && daysUntilExpiration <= 5){
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
