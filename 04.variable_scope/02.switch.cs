int employeeLevel = 201;
string employeeName = "John Smith";

string title = "";

// La estructura switch se proporciona como alternativa a una construccion de bifurcacion if-elseif-else
switch(employeeLevel) {
    // Se ejecuta el case que coincida con el parametro proporcionado
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    // Si no hay coincidencia en ninguno de los case, se ejecuta la linea default
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");