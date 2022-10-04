using system;
public class Program
{
public void Main()
{
console.WriteLine("Welcome");
DoMath(4,17);
DoMath(5, 12);
DoMath(3, 5);
}

public void DoMath(int value, int value2)
{
var number = value + value2;
console.WriteLine(number);
}
public void compare(int value, int value2)
{
if (value > value2) 
{
  console.WriteLine("True, the first value is greater");
}
else
{
  Console.WriteLine("Falsehood! The second value is most");
}

public void Statements()
{
if (15 > 30)
{
  Console.WriteLine("15 is the bigger number");
}
else if(15 > 25)
{
  Console.WriteLine("15 is the bigger number";
}
else
{
  Console.WriteLine("15 is just small potatoes, bro.");
}
int x = 20;
int y = 18;
if (x > y) 
{
  Console.WriteLine("x is greater than y");
}
else if(x == y)
{
Console.WriteLine("x is equal to y");
}
else
{
  Console.WriteLine("y is greater than x");
}
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
    Console.WriteLine("It does not matter what day of the week it is. Existance will continue to drag until we are released from this mortal coil.");
}

public void ChaosMath(x, y) 
{
int x = 50;
int y = 10;
if (x > y)
{
  Console.WriteLine("Hello World");
}
}
}
}
}
}
