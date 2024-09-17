// //operador igualdad ==
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");
/* ************************ */
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

/* ************************ */
// //operador desigual !=
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue2 = "a";
// Console.WriteLine(myValue2 != "a");

/* ******************** */
// //negacion lógica !var
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

/* ******************** */
//operador ternario
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
// si el saldo es mayor a 1000 imprime 100 sino imprime 50 
Console.WriteLine($"Discount: {discount}");