string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

//Console.WriteLine("The final name is: " + students[studentCount]); //Al ejecutar dará error porque la longitud del array es mayor que los elementos, uno empieza por 1, el otro empieza por 0.

//Console.WriteLine("The final name is: " + students[studentCount - 1]); //para empezar a recorrer el array desde 0 y no 1

//Se puede usar un try catch para evaluar errores CIRCUIT BREAK
//Patrón de Retry, de reintentos. Se estipula cuántos intentos y cada cuánto tiempo
//Usar el Circuit Break y el patrón Retry combinados.
//Cuidado con el uso de estos ya que ralentiza la app.

try{
    Console.WriteLine("The final name is: " + students[studentCount]);
}catch(System.Exception ex){
    Console.WriteLine(ex.Message);
}
//Cuidado porque mostrará al "público" el error