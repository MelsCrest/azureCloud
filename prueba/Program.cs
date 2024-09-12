int firstNumber = 3;
int secondNumber = 7;
// int firstNumber = 3, secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); //El 7 se concatena
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); //Se realiza la suma de valores

Console.Clear();

//OPERACIONES MATEMÁTICAS
firstNumber = 21;
secondNumber = 13;

var suma = firstNumber + secondNumber;
var resta = firstNumber - secondNumber;
var multiplicacion = firstNumber * secondNumber;
var division = firstNumber / secondNumber;

Console.WriteLine($@"El resultado de la suma es {suma}.
El resultado de la resta es {resta}.
El resultado de la multiplicacion es {multiplicacion}.
El resultado de la división es {division}.");

decimal thirdNumber = 12.5m;
decimal fourthNumber = 3.6m;
var divisionDecimales = thirdNumber / fourthNumber;
Console.WriteLine($@"El resultado de la division de decimales es {divisionDecimales}.");

decimal division2 = (decimal)firstNumber / (decimal)secondNumber;
Console.WriteLine($@"El resultado de la división con decimales es {division2}");

var resto = firstNumber % secondNumber;
Console.WriteLine($@"El resto de la división entera es {resto}");

Console.Clear();

//OTRA MANERA DE HACERLO CON MENOS LÍNEAS
var firstNum = 10m; //decimal
var secondNum = 7; //entero

Console.WriteLine("Resultado de la suma: " + (firstNum + secondNum));
Console.WriteLine("Resultado de la resta: " + (firstNum - secondNum));
Console.WriteLine("Resultado de la multiplicacion: " + (firstNum * secondNum));
Console.WriteLine("Resultado de la division de enteros: " + ((int)firstNum / secondNum)); //convertimos el número decimal en entero
Console.WriteLine("Resultado de la division de decimales: " + (firstNum / (decimal)secondNum)); //convertimor el número entero en decimal
Console.WriteLine("Resultado del resto de la division de enteros: " + (firstNum % secondNum));
/***************************/
Console.Clear();
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
/***************************/
Console.Clear();
int value1 = 1;
value1++;
Console.WriteLine("First: " + value1);
Console.WriteLine($"Second: {value1++}");
Console.WriteLine("Third: " + value1);
Console.WriteLine("Fourth: " + (++value1));
