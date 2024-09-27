// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// PrintCircleArea(12);

// void PrintCircleArea(int radius)
// {
//     double pi = 3.14159;
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }
/* ************************** */
// PrintCircleArea(12);

// void PrintCircleArea(int radius)
// {
//     double pi = 3.14159;
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

//Aparecen mensajes de error informando de que los nombres pi y radius no existen en el ámbito actual. Esas variables solo existen dentro del ámbito del método PrintCircleArea.
// PrintCircleArea(12); 
// double circumference = 2 * pi * radius;

/* ***************** */
// void PrintCircleCircumference(int radius)
// {
//     double pi = 3.14159;
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

/* ***************** */
double pi = 3.14159;

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}