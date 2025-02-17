int sortedNumber = new Random().Next(1, 101);
int guess = 0;

while (guess != sortedNumber) {
  if (guess != 0) {
    Console.WriteLine("Guess: " + guess);
  }
  if (guess != 0 & guess > sortedNumber) {
    Console.WriteLine("Your guess is too high!");
  }
  if (guess != 0 & guess < sortedNumber) {
    Console.WriteLine("Your guess is too low!");
  }

  Console.WriteLine("Guess a number between 1 and 100:");
  guess = int.Parse(Console.ReadLine());
}

Console.WriteLine("You got it! The secret number is " + sortedNumber);
Console.Beep();
