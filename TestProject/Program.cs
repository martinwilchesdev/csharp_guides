Random dice = new Random();

var roll1 = dice.Next(1, 7);
var roll2 = dice.Next(1, 7);
var roll3 = dice.Next(1, 7);

var total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)) {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll1 == roll3)) {
    Console.WriteLine("You rolled triples! +6 bonus to total");
    total += 6;
}

if (total > 14) {
    Console.WriteLine("You Win!");
} else {
    Console.WriteLine("Sorry, you lose.");
}