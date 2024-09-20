// INDEXOF() - .IndexOf('caracter') - Mostrará la posición en la cadena de ese caracter. Empezará a contar desde 0.
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
/* ************************************ */

// SUBSTRING() - .Substring(var, var); - Mostrará lo que se encuentre dentro de esas variables que contienen .IndexOf() que indican la posición.
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

/* ************************************ */
// INDEXOF() Y SUBSTRING()
// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

/* ************************************ */
// INDEXOF() Y LASTINDEXOF() - IndexOf - LastIndexOf -- Primer y ultimo caracter
// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

/* ************************************ */
// REMOVE() - Remove(inicio, final) - Elimina todo aquello que se encuentre dentro de los valores indicados como parámetros. La longitud a borrar a de coincidir con el tamaño del string
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

/* ************************************ */
// REPLACE() - Replace("esto", "por esto") - Reemplaza un dato que indicamos como primer parámetro por el dato que indicamos como segundo parámetro
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);