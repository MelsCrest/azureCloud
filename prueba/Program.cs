//var dados = new Random(); //instanciar
//Random dados = new(); //otra manera de instanciar 
//int roll = dados.Next(1,7);
//Console.WriteLine(roll);

//El código de arriba tiene más información sobre lo que está pasando que la refactorización

//refactorizacion
//Console.WriteLine(new Random().Next(1,7));


Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


