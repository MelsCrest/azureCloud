String nombreIntroducido = "Melisa";
int edadIntroducida = 21; 
SayHello(nombreIntroducido, edadIntroducida);

void SayHello(String nombre, int edad)
{
    Console.WriteLine("Hola " + nombre + ", tu edad es " + edad);
};

Console.Clear();

int num1 = 5, num2 = 7, num3 = 8;
int resultadoS = 0, resultadoR = 0, resultadoM = 0;
Suma(num1, 9);
Resta(num3, num2);
Multiplica(num3, 1);
ImprimirResultado(resultadoS);
ImprimirResultado(resultadoR);
ImprimirResultado(resultadoM);

void Suma(int a, int b)
{
    resultadoS = a + b;
};

void Resta(int a, int b){
    resultadoR = a - b;
};

void Multiplica(int a, int b){
    resultadoM = a * b;
};

void ImprimirResultado(int resultado){
    Console.WriteLine(resultado);
}

Console.Clear();

int[] a = {1,2,3,4,5};
int[] b = {6,7,8,9,10};
Console.WriteLine("Contents of Array:");
PrintArray(a);
PrintArray(b);

void PrintArray(int[] array)
{
    foreach (int x in array)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
