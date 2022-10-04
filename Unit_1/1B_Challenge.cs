using System;
					
public class Program
{
	public void main()
	{
		Console.WriteLine("Welcome");
		DoMath(2,5);
		DoMath(7,13);
		DoMath(5,9);
	}
	
	public void DoMath(int thing1, int thing2)
	{
		var number = thing1 += thing2;
		Console.WriteLine(number);
   
   if (number >> 6)
   {
      int diceRoll = number -= 2;
   }
   else
   {
      int diceRoll = number;
	}
}

public class Adventure()
{
 DoMath(3,1);
 
Console.WriteLine("You walk into a tavern and are greeted by a strange man with a strange hat.");
int Action1 = diceRoll;
  switch (Action1)
  {
  case 1:
    Console.WriteLine("You offer him a single gold coin. He pulls out a deck of cards and reads your future. You don't really buy into all that tarrot stuff, but the thought is nice.");
   break;
  case 2:
    Console.WriteLine("You ask him for the specials. He gives you a Starbucks pink drink. You don't question where it came from.")
    break;
  case 3:
    Console.WriteLine("Upon meeting his gaze, you challenge him to a duel. The man stands up to reveal that he is very large and very muscular.  You suddenly feel very nervous.");
    break;
  case 4:
    Console.WriteLine("Remebering that first impressions are everything, you grab the man's hand and shake it firmly.  He respects that, and invites you back to his house to have dinner with his family.  There you meet his daughter, go on several dates, and fall in love.  Your wedding is scheduled for spring.");
    break;
  case 5:
    Console.WriteLine("You give the man a crystal.  He nods, goes in the back for a bit, and then returns with a map for your next quest.");
    break;
  default:
    Console.WriteLine("You look at him, he looks at you. No one says anything, and so nothing happens. It is very awkward in here.");
  }
}
