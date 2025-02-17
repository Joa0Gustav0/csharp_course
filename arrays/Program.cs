string[] fruits = "🍇,🥝,🍈,🍉,🍊,🍋,🍌,🍍,🥭,🍎,🍑,🍒,🍓,🍆".Split(","); 
string[] favoriteFruits = "🍇,🍍,🍑,🍓".Split(","); 

foreach (string fruit in fruits)
{ 
  Console.WriteLine(validateFruit(fruit));
}

string validateFruit(string fruit) {
  return fruit + " " + (favoriteFruits.Contains(fruit) ? "✅" : "❌");
}