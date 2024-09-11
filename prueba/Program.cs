//Variables y concatenaciones
//Opcion 1
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!"; //guardamos la concatenación con las variables en una variable que luego imprimimos
Console.WriteLine(message);
//Opcion 2
Console.WriteLine(greeting + " " + firstName + "!"); //concateno las variables e imprimo directamente
//Opcion 3
string message1 = $"{greeting} {firstName}!"; //uso $"" para escribir dentro el mensaje y meto las variables entre llaves {}. Se guarda en una variable que luego se imprime
Console.WriteLine(message1);
/*Se modifica el mensaje de la primera variable "mensaje" al quitar String
message = $"{greeting} {firstName}!"; //uso $"" para escribir dentro el mensaje y meto las variables entre llaves {}. Se guarda en una variable que luego se imprime
Console.WriteLine(message);*/

Console.Clear(); //Hace que todo el código anterior no aparezca
int version = 11;
string updateText = "Update to Windows";
message = $"{updateText} {version}";
Console.WriteLine(message);

Console.Clear();
string projectName = "First-Project";
var path = $@"C:\Output\{projectName}\Data"; //guardas en una variable la ruta
Console.WriteLine(path);