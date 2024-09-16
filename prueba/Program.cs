// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; //si metemos una matriz más (llegando a 4) una vez declarado el tamaño de la matriz (que es 3), da un error = "System.IndexOutOfRangeException: Index was outside the bounds of the array".

//Console.WriteLine(fraudulentOrderIDs[2]);
// Console.WriteLine($@"El tamaño del array es {fraudulentOrderIDs.Length}");

// for (int i = 0; i < fraudulentOrderIDs.Length; i++){ //para mostrar la longitud del array
//     Console.WriteLine(fraudulentOrderIDs[i]);
// };

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
foreach (var item in fraudulentOrderIDs){ //recorrer un array con foreach
    Console.WriteLine(item);
}