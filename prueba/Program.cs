Random random = new Random(); //instanciar la clase Random
numerosRandom();

void numerosRandom(){
    for (int i = 0; i < 5; i++){
        // int numero = random.Next(1, 100);
        // Console.Write(numero + " ");
        Console.Write(random.Next(1, 100) + " ");
    }
    Console.WriteLine();
}

