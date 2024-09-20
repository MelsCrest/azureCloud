using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($@"Dear {customerName}, 
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.
Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.
Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.
Here's a quick comparison:
");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
//Para no crear variables que almacenen todos los datos modificados (P, N, C) y luego añadirle el PadRight();
//Con String.Format("cadena de formato", argumentos);
//String.Format("{0:P}, currentReturn) -- 0  será sustituido por 'currentReturn' al que se le aplicará ':P'
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
//comparisonMessage += $"currentProfit.toString(:C).PadRight(20)";
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);