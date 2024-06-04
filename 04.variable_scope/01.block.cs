bool flag = true;

if (flag) {
    int value;
    value = 10;
    Console.WriteLine(value);
}

// Las variables definidas dentro de un bloque de codigo solo pueden ser accedidas dentro del bloque mismo
Console.WriteLine(value); // error: El nombre 'value' no existe en el contexto actual