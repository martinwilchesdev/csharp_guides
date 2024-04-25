/**
* El operador "+" convierte de forma implicita un valor numerico a string temporalmente cuando este se encuentra concatenado con datos de tipo string.
* Para realizar la operacion numerica entre 2 valores numericos dentro de secuencia concatenada de strings, estos valores deben ser encerrados entre "()"
*/
var age = 20;
Console.WriteLine("My age is " + age + 10); // El resultado obtenido es: My age is 2010
Console.WriteLine("My name is " + (age + 10)); // El resultado obtenido es: My age is 30

// Se aumenta la precision en el resultado de una division cuando al menos uno de los numeros operados admite digitos fraccionarios
Console.WriteLine(5.0d / 4.0);

// El tipo de dato de un valor numerico puede ser convertido a un tipo distinto de forma temporal mediante la siguiente notacion
Console.WriteLine((decimal)5 / 4);