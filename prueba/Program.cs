string pangram = "The quick brown fox jumps over the lazy dog";

// string[] mensaje = pangram.Split(' '); //Separa por palabras
// string[] newMensaje = new string[mensaje.Length];

// for (int i = 0; i < mensaje.Length; i++){
//     char[] letras = mensaje[i].ToCharArray();
//     Array.Reverse(letras);
//     newMensaje[i] = new string(letras);
// }

// string resultado = String.Join(" ", newMensaje);
// Console.WriteLine(resultado);

/* ******************************* */
string[] resultado = pangram.Split(" ");
string[] reverse = new string[resultado.Length];
string final = string.Empty;

for (int i = 0; i < resultado.Length; i++){
    // string palabra = resultado[i];
    // string palabraInvertida = string.Join("", palabra.ToCharArray().Reverse());
    // reverse[i] = palabraInvertida;
    final += string.Join("", resultado[i].ToCharArray().Reverse()) + " ";
}
   //Console.WriteLine(string.Join(" ", reverse));
   Console.WriteLine(final);
