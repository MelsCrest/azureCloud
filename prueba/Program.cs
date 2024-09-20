const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = input.Substring(input.IndexOf("5000"),4);
string output = input.Substring(input.IndexOf("<div>")+5,input.Length - 11).Replace("&trade", "&reg");

Console.WriteLine(quantity);
Console.WriteLine(output);

//IndexOf() le permitía identificar la posición de un carácter o cadena dentro de otra cadena.
//IndexOfAny() para buscar la posición de cualquier valor de una matriz de char especificada