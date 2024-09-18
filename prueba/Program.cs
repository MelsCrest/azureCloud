// #region prueba de lo que es un region
// //si es solo una línea de código se puede escribir todo junto
// if(true){Console.WriteLine("Hola mundo");};
// #endregion

// //No usar un "break" usar otra condición en el for o usar otro tipo de bucle. Se puede usar porque no es buena práctica. Un break interrumpe el flujo del código.
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// //los foreach son solo de lectura (solo recuperan datos). No se puede escribir en ellos
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names) //leerá toda la lista de nombres
{
    if (name == "David") names[2] = "Sammy";
    Console.WriteLine(name);
}
    Console.WriteLine(names[2]); //una vez terminado el bucle de lectura es cuando hace el cambio de David a Sammy

