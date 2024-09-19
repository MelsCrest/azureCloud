string value = "abc123";
char[] valueArray = value.ToCharArray(); //Convierte un string en caracteres
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray); 
//.Join(caracter, array) Añade un caracter después de cada valor del array, como si hiciera un bucle
Console.WriteLine(result);

string[] items = result.Split(',');
//.Split(caracter) Se utiliza el caracter como divisor del array (elemento que parte el array)
foreach (string item in items)
{
    Console.WriteLine(item);
}