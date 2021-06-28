using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("How many cars are in the race?");
    int numberofcars = Convert.ToInt32(Console.ReadLine()) + 1;
    double totalaverage = 0;
    for (int i = 1; i < numberofcars; i++) 
    {
      Console.WriteLine("Enter the distance covered by car #" + i);
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car #" + i);
      double time = Convert.ToDouble(Console.ReadLine());
      double mph = distance / time;
      Console.WriteLine("The speed of this car is " + mph + " miles per hour");
      totalaverage = totalaverage + mph;
    }
    double average = totalaverage/(numberofcars - 1);
    Console.WriteLine("The average speed of the cars is " + average + " miles per hour");
  }
}