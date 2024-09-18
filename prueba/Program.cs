
// for(int i=1;i<=100;i++){
//     if(i % 3 == 0){
//         Console.WriteLine(i + " Fizz");
//     }else if(i % 5 == 0){
//         Console.WriteLine(i + " Buzz");
//     }else if(i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine(i + " FizzBuzz");
//     }else{
//         Console.WriteLine(i);
//     }
// }
// Opción 2
for(int i=1;i<=100;i++){
    //var resultado = i.ToString;
    var resultado = (i % 3 == 0 && i % 5 == 0) ? " FizzBuzz":
                    (i % 3 == 0) ? " Fizz":
                    (i % 5 == 0) ? " Buzz" : "";

                    Console.WriteLine(i + resultado);
}
//var resultado = i.toString; de esta manera a "var" le decimos que su tipo sea "String", es una declaración explicita. Y String, porque lo que imprimimos por pantalla es una cadena de texto.
