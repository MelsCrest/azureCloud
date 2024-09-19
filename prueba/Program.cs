//Clear(array, inicio, cuanto a borrar) borra los valores almacenados en los elementos del array, pero no el espacio en el array
//Dependiendo del tipo de array al espacio vacío devolverá cadena vacía, 0, false, null...
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}"); //sigue siendo un array de 4 espacios aunque se le hayan quitado los valores primero y segundo
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//Resize(ref array, número de espacios total en la variable) para variar (aumentar, disminuir) el tamaño de un array
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");//hay 4 espacios los dos primeros sin informacion
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); //aumentamos el tamaño de los espacios de 4 a 6.
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}