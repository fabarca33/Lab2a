using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the name of the item:");
    var item = Console.ReadLine();
    Console.WriteLine("Enter the Quantity:");
    var x = Console.ReadLine();
    int x1 = Convert.ToInt32(x);
    Console.WriteLine("Enter the price:");
    var y = Console.ReadLine();
    double y1 = Convert.ToDouble(y);
    Console.WriteLine("Total price of "+item +" = "+(x1*y1));
    
  }
}