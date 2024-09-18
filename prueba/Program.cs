// Random dado = new Random();
// int heroe = 10;st
// int monstruo = 10;
// int tirada = 0;

// do
// {
//     //tirada del héroe
//     tirada = dado.Next(1, 11);
//     monstruo -= tirada;
//     Console.WriteLine($@"El monstruo ha sido herido y ha perdido {tirada} de salud y ahora tiene {monstruo} de vida.");

//     if(monstruo <= 0){ 
//     continue;
//     };

//     //tirada del monstruo
//     tirada = dado.Next(1, 11);
//     heroe -= tirada;
//     Console.WriteLine($@"El héroe ha sido herido y ha perdido {tirada} de salud y ahora tiene {heroe} de vida.");

// } while (heroe > 0 && monruo > 0);

// Console.WriteLine(heroe > monstruo ? "El héroe gana!" : "El monstruo gana!");

//OPCIÓN CON FLAGS
Random dado = new Random();
int heroe = 10;
int monstruo = 10;
int tirada = 0;
var isHero = true;

do{
    tirada = dado.Next(1,11);
    if(isHero){
        monstruo-= tirada;
        Console.WriteLine($@"El monstruo ha sido herido y ha perdido {tirada} de salud y ahora tiene {monstruo} de vida.");
    } else {
        heroe-= tirada;
        Console.WriteLine($@"El héroe ha sido herido y ha perdido {tirada} de salud y ahora tiene {heroe} de vida.");
    }
    isHero = !isHero;
}while (heroe > 0 && monstruo > 0);
Console.WriteLine(heroe > monstruo? "El héroe gana!" : "El monstruo gana!");