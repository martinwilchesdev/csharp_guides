// int numericValue;
// string? readValue;
// bool validEntry = false;

// Console.WriteLine("Please enter a number between 5 and 10");

// do {
//     readValue = Console.ReadLine();

//     if (readValue != "") {
//         if (int.TryParse(readValue, out numericValue)) {
//             if (numericValue >= 5 && numericValue <= 10) {
//                 validEntry = true;
//             } else {
//                 Console.WriteLine("Please enter a number between 5 and 10");
//             }
//         } else {
//             Console.WriteLine("Please enter a valid numeric value");
//         }
//     } else {
//         Console.WriteLine("Please enter a valid entry");
//     }
// } while(!validEntry);

// string[] roles = new string[] {"administrator", "director", "user"};
// bool validValue = false;
// string? readValue;

// Console.WriteLine("Enter a role, Administrator, Director or User");

// do {
//     readValue = Console.ReadLine();
    
//     if (roles.Contains(readValue.Trim().ToLower())) {
//         Console.WriteLine($"Your input value ({readValue}) has been acepted.");
//         validValue = true;
//     } else {
//         Console.WriteLine("Please enter a valid rol");
//     }
// } while(!validValue);

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string? name;

foreach(string str in myStrings) {
    string? myString;
    int indexDot = 0;

    do {
        indexDot = str.IndexOf(".");
        myString = str.Remove(0, indexDot);
        Console.WriteLine(myString);
    } while(indexDot != -1);
}