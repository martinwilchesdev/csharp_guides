// Al llamar a un metodo con estado es necesario crear una instancia de la clase para asi tener acceso al metodo del objeto.
var dice = new Random();
Console.WriteLine(dice.Next(1, 10));

// Los metodos sobrecargados admiten varias implementaciones del metodo (cantidad variable de parametros o parametros de distintos tipos)
Console.WriteLine();
Console.WriteLine(123);
Console.WriteLine(true);
Console.WriteLine("Hello World");