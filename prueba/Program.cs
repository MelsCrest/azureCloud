//cambiar el idioma
// using System.Globalization;
// CultureInfo.CurrentCulture=(new CultureInfo("en-US"));
//si se hiciera en una app de escritorio habría que confirmar que el lenguaje es el apropiado para que no de error al seleccionar el idioma y que aparezcan los símbolos


// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");//:C muestra el formato de la moneda correspondiente a sistema de referencia cultural que tenga nuestro ordenador

// measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N4} units");//:N muestra 2 decimales después de la coma . Si a continuación ponemos un número :N4 saldrán 4 decimales después de la coma.
//Sin el System.Globalization

//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P1}"); //:P da formato de los porcentajes. El número que se ponga a continuación mostrará el número de valores que saldrán como decimales.

//string input = "Pad this";
//string input2 = "Pad this too, please";
//Console.WriteLine(input.PadLeft(25, '-')); //PadLeft(número de caracteres que se quieren, qué se quiere añadir) Añade espacios, o en este caso -, a la izquierda hasta completar 12 caracteres contando los caracteres del String
//Console.WriteLine(input2.PadRight(25, '-'));//PadRight lo mismo pero en el lado derecho
//Esto permite que todos los datos que se imprimen queden alineados

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine); //se crea una variable "formattedLine" para almacenar todos los valores del Pad y conseguir una cadena de texto de 40 caracteres hecha con 3 variables distintas. En la primera y la última se pondrá la dirección (Left o Right) que corresponda. 