//Crear un array de nombres
string[] alumnos = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Laura" };

//Crear un array de arrays de enteros
int[][] notas = new int[alumnos.Length][];
notas[0] = new int[] { 90, 86, 87, 98, 100};
notas[1] = new int[] { 92, 89, 81, 96, 90};
notas[2] = new int[] { 90, 85, 87, 98, 68};
notas[3] = new int[] { 90, 95, 87, 88, 96};
notas[4] = new int[] { 92, 77, 90, 80, 91};

var indiceAlumno = 0;
decimal sumaValores = 0;

//Mostrar los nombres y sus valores asociados
foreach (var alumno in alumnos){

    //Calcular la suma de notas utilizando un array.sum
    sumaValores = notas[indiceAlumno].Sum();

    //Calcular la suma de notas con foreach
        // foreach (var nota in notas[indiceAlumno]){
        //  sumaValores = sumaValores + nota;   
        // }
    var media = sumaValores / (notas[0].Length);
    indiceAlumno++;
    sumaValores = 0;
    var notaLetra = "";

    if(media >= 97){ notaLetra = "A+";}
    else if(media >= 93){ notaLetra = "A";}
    else if(media >= 90){ notaLetra = "A-";}
    else if(media >= 87){ notaLetra = "B+";}
    else if(media >= 83){ notaLetra = "B";}
    else if(media >= 80){ notaLetra = "B-";}
    else if(media >= 77){ notaLetra = "C+";}
    else if(media >= 73){ notaLetra = "C";}
    else if(media >= 70){ notaLetra = "C-";}
    else if(media >= 67){ notaLetra = "D+";}
    else if(media >= 63){ notaLetra = "D";}
    else if(media >= 60){ notaLetra = "D-";}
    else { notaLetra = "F";}

    Console.WriteLine($"Nombre: {alumno}\t Valores: {media} \t {notaLetra}");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();