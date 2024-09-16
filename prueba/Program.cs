string[] numerosFraudulentos = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string numero in numerosFraudulentos){
    if(numero.StartsWith("B")){
        Console.WriteLine(numero);
    }
}