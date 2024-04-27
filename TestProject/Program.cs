Random dice = new Random();
var roll1 = dice.Next();
var roll2 = dice.Next(105);
var roll3 = dice.Next(100, 200);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");