//Console.WriteLine(DateTime.Now.ToLongTimeString()); //Hora de aquí
//Console.WriteLine(DateTime.UtcNow.ToLongTimeString()); //Hora meridiano de 
/* ******* 
Importante al programar usar el meridiano de Greenwich.
Al final se usará la hora del usuario.
******* */
// Console.WriteLine(DateTime.UtcNow.ToShortDateString()); //Fecha
// Console.WriteLine(DateTime.Now); //hora y 
// Console.WriteLine(DateTime.Now.ToString("dd-MM-yy HH:mm:ss.ff"));

//Para añadir o quitar usar los ADD
//Para comparar usar los Get??

// var hoy = DateTime.UtcNow;

// Console.WriteLine(hoy.AddMonths(1).AddDays(30));


var hoy = new DateTime(2024,05,31);
//Console.WriteLine(hoy.AddMonths(1));

Console.WriteLine(hoy.AddMonths(1).Ticks); //Ticks muestra desde el 1/01/70 muestra todos los milisegundos que han pasado. Se trabaja con ello para obtener más precisión que con DateTime.

//TimeSpan para sacar un intervalo de fechas desde un punto a otro.

Thread.Sleep(1000); //marca una pausa con el tiempo que indiquemos
