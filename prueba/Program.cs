Random random = new Random();
int daysUntilExpiration = random.Next(21);
int discountPercentage = 0;
 //do{ //bucle do while para que se ejecute el código cada vez que se da a ESC
    Console.Clear();//limpiar el código para que cada vuelta se vea bien
    Console.WriteLine("Show days: " + daysUntilExpiration);
    if(daysUntilExpiration <= 10 && daysUntilExpiration > 5){
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    } else if( daysUntilExpiration <= 5 && daysUntilExpiration > 1 ){
        discountPercentage = 10;
        Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days. 
        Renew now and save {discountPercentage}%!");
    
    } else if(daysUntilExpiration == 1){
        discountPercentage = 20;
        Console.WriteLine(@"Your subscription expires within a day!
    Renew now and save {discountPercentage}%!");
        
    } else if(daysUntilExpiration < 1){
        Console.WriteLine(@"Your subscription has expired.");
    }
//}while(Console.ReadKey(true).Key != ConsoleKey.Escape); //cuando se da a ESC se repite el código

/* ***************** SOLUCIÓN MICROSOFT (MENOR CÓDIGO) ********************** */

// Console.WriteLine("Show days: " + daysUntilExpiration);
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

