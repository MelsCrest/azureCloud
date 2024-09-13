Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// var total = 0;
// var tirada = 1;

// Console.Write("Dice roll:");
// for (int i = 0;i < 2; i++){ 
//     tirada=dice.Next(1,7);
//     Console.Write($" {tirada} +");
//     total += tirada;
// }
//     tirada=dice.Next(1,7);
//     Console.Write($" {tirada} ");
//     total += tirada;
// Console.WriteLine($"Total {total}");

// //para evitar que se repita el "+" al final hacemos que el bucle se repita 2 veces y luego fuera hacemos la 3º tirada

// if (total <= 9){
//     Console.WriteLine(" Sorry, you lose.");
// }else{
//     Console.WriteLine(" You win!");
// }
/*------------------------------------------------------------------*/
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
/*------------------------------------------------------------------*/

var total = 0;
int[] tirada = new int[3];
Console.Write("Dice roll: ");
for (int i = 0; i < 3; i++){
    tirada[i] = dice.Next(1,7);
    Console.Write($"{tirada[i]} {(i<2?"+ ":"")}");
    total += tirada[i];
}

// if (total <= 9){
//      Console.WriteLine(" Sorry, you lose.");
// }else{
//      Console.WriteLine(" You win!");
// }

// if ((tirada[0] == tirada[1]) || (tirada[1] == tirada[2]) || (tirada[0] == tirada[2]))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// Console.WriteLine($"Total: {total}");

if ((tirada[0] == tirada[1]) && (tirada[1] == tirada[2])) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

Console.WriteLine($"Total: {total}");