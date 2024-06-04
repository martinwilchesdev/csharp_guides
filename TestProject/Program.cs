string? user_input;

Console.WriteLine("Enter a valid number between 5 and 10");

do {
    user_input = Console.ReadLine();
    int response = user_input.tryParse(user_input, out numericValue);
    Console.WriteLine(response);
} while(response == "");