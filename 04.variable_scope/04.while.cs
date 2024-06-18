/**
* Las instrucciones do while y while ejecutan una instruccion o un bloque de codigo mientras una expresion booleana especificada se evalue como true.
* La instruccion do while se ejecuta al menos una vez aunque la condicion no se evalue como true.
*/
Random dice = new Random();
int current = 0;

do {
    current = dice.Next(1, 11);

    // La palabra clave continue omite ejecutar la iteracion actual del bloque de codigo y pasa inmediatamente a la siguiente iteracion
    if (current >= 8) continue;

    Console.WriteLine(current);
} while(current != 7);

while(current >= 3) {
    Console.WriteLine(current);
    current = dice.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");