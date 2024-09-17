//operador ternario
string permission = "Manager"; //Elegir entre Admin o Manager
int level = 55;

string message = permission.Contains("Admin") 
    ? (level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.")
    : (permission.Contains("Manager") 
        ? (level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")
        : "You do not have sufficient privileges.");

Console.WriteLine(message);

/* ********************** */
//con if else if else

// string permiso = "Admin|Manager"; //Elegir entre Admin o Manager
// int nivel = 53;

// if (permiso.Contains("Admin"))
// {
//     if (nivel > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permiso.Contains("Manager"))
// {
//     if (nivel >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }