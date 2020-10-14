using System;
class MainClass {
  public static double CalculateCharges(int hours)
  {     
      double amount;
      if (hours <= 3)
      {
        amount = 2;        
      }
      else if ((hours > 5)&&(hours < 24))
      {
        amount = 2+ (0.5*(hours-3));
      }
      else
      {
        amount = 10;
      }
      return amount;
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Main method");
    double charges = 0;
    int hours = 0;
    for(int i=0; i< 10; i++)
    {
      hours = Convert.ToInt32(Console.ReadLine());//hours
      charges =  CalculateCharges(hours);
      Console.WriteLine(charges);
    }   
    
        
  }
}