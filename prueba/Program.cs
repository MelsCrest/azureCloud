// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");
// /* ******************** */
// Random moneda = new Random();
// Console.WriteLine((moneda.Next(0, 2) == 0) ? "heads" : "tails");
// /* ******************** */
Console.WriteLine(new Random().Next(0,2) < 1 ? "cara" : "cruz");Console.ReadKey();
