Console.WriteLine("How many rows?");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("How many columns?");
int columnsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Which symbol?");
String symbol = Console.ReadLine();

for (int yI = 0; yI < rowsNumber; yI++) {
  for (int xI = 0; xI < columnsNumber; xI++) {
    Console.Write(symbol);
  }
  Console.Write("\n");
} 