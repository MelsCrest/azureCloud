/*
//SECUENCIAS DE ESCAPE
Console.WriteLine("Hello\nWorld!"); //Salto de línea
Console.WriteLine("Hello\tWorld!"); //Tabulador
Console.WriteLine(@"Hello\nWorld!"); //Con la @ no necesitas usar \. Aquí aparecería \n al imprimir
Console.WriteLine(@"Hello World!"); //La @ respeta el espacio
Console.WriteLine("Hello \"World\""); // \"\" para escribir las comillas a World
Console.WriteLine(@"c\source\repos"); // Con la @ respeta las \ sin entenderlas como secuencia de escape
Console.WriteLine("c\\source\\repos"); //\\ para que muestre \ y no la entienda como secuencia de escape 
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)"); //Elimina espacio en blanco al inicio. Respeta el salto de línea

// CÓDIGO PARA GENERAR FACTURAS
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// CARACTERES CODIFICADOS
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");*/

// CÓDIGO PARA GENERAR FACTURAS
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");