//el resultado es un string y los valores se concatenan
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

//el resultado es un int y no puede sumar los valores al no ser numéricos ambos.
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

//Con int.Parse hacemos una conversión explícita de second
// int first = 2;
// string second = "4";
// int result = first + int.Parse(second);
// Console.WriteLine(result);

//Con .toString() convertimos valores numericos a cadena de texto
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

//Con int.Parse(var) convertimos una cadena de texto en valor numérico
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

//Con try catch evaluar errores. El try catch es muy pesado y rompe el flujo
// try{
// string first = "5";
// string second = "a";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
// } 
// catch(SystemException){
//     Console.WriteLine("Número no válido");
// }

//.TryParse(var, out nueva variable). Cuando puede convertir el valor "devuelve" true y hace la suma de los valores, sino false el valor que no se puede cambiar tiene valor 0.
// string first = "5";
// string second = "a";
// int resultado;
// Console.WriteLine(int.TryParse(second, out resultado)); //mostramos el true o false, sino lo imprimimos lo hace por debajo
// int sum = int.Parse(first) + resultado;
// Console.WriteLine(sum);

//Convert.ToInt32
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
