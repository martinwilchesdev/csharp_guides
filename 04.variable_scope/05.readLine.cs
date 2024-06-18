/**
 * Console.ReadLine() permite la entrada de datos por parte del usuario.
 * Los datos recibidos se encuentran en formato string.
*/
Console.WriteLine("Enter your age");
string age = Console.ReadLine();

/**
 * El metodo int.tryParse() se puede usar para convertir un valor de tipo string a entero.
 * Recibe 2 parametros, el string evaluado y el nombre de la variable de entero a la que se asignara un valor.
 * Este metodo retorna un valor booleano
*/
int numericValue = 0;
bool validNumber = false;

// Si el valor del string asignado a readResult representa un entero valido, el valor se asignara a la variable de entero denominada numericValue y true a validNumber
validNumber = int.TryParse(age, out numericValue);