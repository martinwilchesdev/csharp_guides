// La instruccion foreach permite iterar los elementos contenidos en un arreglo.
string[] dishes = {"Pizza", "Pasta", "Soup"};

// La variable temporal hace referencia a cada elemento del arreglo que esta siendo iterado en el ciclo actual.
foreach(string dish in dishes) {
    Console.WriteLine($"Dish name: {dish}");
}