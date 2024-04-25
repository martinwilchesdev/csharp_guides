/**
* Un literal de cadena textual conserva todos los espacios en blanco y caracteres especiales.
* Una cadena textual usa la directiva "@" antes de la cadena literal.
*/
Console.WriteLine(@"  c:\temp\new.txt");

/**
* La interpolacion de cadenas permite combinar valores en una sola cadena de texto.
* Una expresion de interpolacion es indicada con un simbolo "{}".
* Un string se convierte en una plantilla cuando tiene el prefijo "$". 
*/
var name = "Ada";
Console.WriteLine($"Hello {name}");