/**
* Los arreglos son estructuras de datos individuales a los que se puede acceder mediante su indice.
* El primer conjunto de corchetes le indica al compilador que la variables es un arreglo.
* El segundo conjunto de corchetes indica la cantidad de elementos que puede contener el arreglo.
*/
string[] fraudulentOrderIDs = new string[3];

// Para asignar un valor a un elemento de un arreglo se utiliza el operador "=" como cualquier otro tipo de variable
fraudulentOrderIDs[0] = "A123";

// El acceso a de los elementos de un arreglo se realiza de igual forma que al asignar un valor
Console.WriteLine($"First id: {fraudulentOrderIDs[0]}");

// La reasignacion de valores en un arreglo se realiza del mismo modo que al asignar un valor para un determinado elemento
fraudulentOrderIDs[0] = "123A";

/**
* Para inicializar un arreglo durante la declaracion se utiliza la siguiente sintaxis.
* Al inicializar un arreglo se realiza la asignacion de los valores para cada uno de los elementos que contiene.
*/
string[] dishes = {"Pizza", "Pasta", "Soup"};

// La propiedad "Length" permite determinar la cantidad de elementos que son contenidos en un arreglo.
Console.WriteLine(dishes.Length);