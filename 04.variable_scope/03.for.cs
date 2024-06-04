/**
* La instruccion for recorre en iteracion un bloque de codigo un numero especifico de veces.
* La instruccion for proporciona un mayor control sobre el proceso de iteracion gracias a que expone las condiciones para la iteracion.
*/
for(int i = 1; i <= 10; i++) {
    // La palabra clave break permite finalizar la ejecucion de la iteracion cuando se cumple una condicion especifica
    if (i > 3) break;
    Console.WriteLine(i);
}

// la instruccion for es util para recorrer un arreglo de elementos
string[] names = new string[] {"Joan", "Steve", "Eddie"};
for(int i = names.Length -  1; i >= 0; i--) {
    Console.WriteLine($"User: {names[i]}");
}

// El ciclo for permite modificar el contenido de un arreglo dentro del bloque de codigo de la iteracion
for(int i = 0; i < names.Length; i++) {
    if (names[i] == "Joan") {
        names[i] = "Bruce";
    }
}