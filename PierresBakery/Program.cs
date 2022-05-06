using System;
using PierresBakery;

public class Program
{
  public static void Main()
  {
   Console.WriteLine(@"
   Welcome to Pierre's Bakery!

   --*Menu*-- 
   Bread $5 and Pastries $2

   Deals:

   Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.)

   Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
   
   ");
    AvoidIntro();
    static void AvoidIntro()
    {
      Console.WriteLine("Would you like to place an order today? (Yes/No)");
      string orderAnswer = Console.ReadLine().ToUpper();
      if (orderAnswer == "YES")
      {
      Console.WriteLine("How Many Bread loaves would you like to purchase?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How Many Pastries would you like to purchase?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Bread newBread = new Bread (breadOrder);
      newBread.BaugettesPrice();
      Pastry newPastry = new Pastry (pastryOrder);
      newPastry.PastryPrice();
      Console.WriteLine(@$"
      
      Thank you for your Order! 
    
      Your Total for Today is: ${newBread.BreadOrderTotal + newPastry.PastryOrderTotal}.00");
      }
      else
      {
        Console.WriteLine("NEXT CUSTOMER PLEASE!");
      }
    }
  }
}