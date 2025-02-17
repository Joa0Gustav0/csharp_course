List<string[]> grid = new List<string[]> {};
int gridLength = 0;

while (gridLength < 10 || gridLength > 30) {
  Console.WriteLine("Insert a length for the grid (-10 & +30):");
  try {
    gridLength = int.Parse(Console.ReadLine());

    if (gridLength < 10 || gridLength > 30) {
      throw new Exception();
    }

  } catch (Exception e) {
    Console.WriteLine("Insert a valid value between 10 and 30 for the grid length.");
  } 
} 

Console.WriteLine("Valid Grid Length.");
constructGrid(gridLength);

Thread.Sleep(1000);
Console.Clear();
constructSqrFunctionChart();
printGrid();

void constructGrid(int length) {
  for (int i = 0; i < length; i++) {
    grid.Add(new string[length]);
  }

  foreach(string[] row in grid) {
    for (int i = 0; i < row.Length; i++) {
      row[i] = "¨";
    }
  }
}

void constructSqrFunctionChart() {
  for (int x = 0; x < gridLength; x++) {
    int y = Convert.ToInt32(executeSqrFuntion(x));
    //Console.WriteLine($"{x}, {Convert.ToInt32(y)}");
    grid[gridLength - 1 - y][x] = "#";
    printGrid();
    Console.Beep();
    Thread.Sleep(25);
    Console.Clear();
  }
}

float executeSqrFuntion(int x) {
  float a = -4f / (gridLength - 1);
  float b = 4f;
  return MathF.Floor(a * x * x + b * x);
}

void printGrid() {
  foreach(string[] row in grid) {
    foreach (string column in row) {
      Console.Write(column);
    }
    Console.WriteLine();
  }
}