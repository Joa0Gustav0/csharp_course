//Variables

//numerical data types -> int, double, float
//literal text datat types -> String, char
//Boolean data type -> bool

int x; //Declaration
x = 325; //Initialization

int y = 25;
int z = x + y;
float xy2 = (x + y) * .5f;

//Console.Write("The sum between " + x + " and " + y + " is " + z + "!\nAnd, it's half is " + xy2 + ".");

//Constant variables
//const float PI = 3.14f;

//Data Casting
//Use the Convert() method;

//Hypotenuse Calculator
/* Console.WriteLine("Hello, let's calculate the hypotenuse.");

Console.WriteLine("What's the value for the first cathetus in cm: ");
float firstCathetus = float.Parse((Console.ReadLine()));
Console.WriteLine("What's the value for the second cathetus in cm: ");
float secondCathetus = float.Parse((Console.ReadLine()));

float hypotenuse = MathF.Sqrt(MathF.Pow(firstCathetus, 2) + MathF.Pow(secondCathetus, 2));

Console.WriteLine("It seems the hypotenuse length for catethus " + firstCathetus + "cm and " + secondCathetus + "cm is " + hypotenuse + "cm."); */
Console.WriteLine("Insert the week day name of your choice:");
String dayName = Console.ReadLine();

switch(dayName.ToLower()) {
  case "sunday" :
    Console.WriteLine(dayName + " is the first day of the week!");
    break;
  case "monday" :
    Console.WriteLine(dayName + " is the second day of the week!");
    break;
  case "thusday" :
    Console.WriteLine(dayName + " is the third day of the week!");
    break;
  case "wednesday" :
    Console.WriteLine(dayName + " is the forth day of the week!");
    break;
  case "tuesday" :
    Console.WriteLine(dayName + " is the fifth day of the week!");
    break;
  case "friday" :
    Console.WriteLine(dayName + " is the sixth day of the week!");
    break;
  case "satuday" :
    Console.WriteLine(dayName + " is the seventh day of the week!");
    break;
  default : 
    Console.WriteLine("The inserted name is not a valid one for a week day.");
    break;
}
