using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The divisors for the number are");
    Console.Write(" 1 ");

    int sum = 1;

    for(int divisor = 2; divisor <= (x/2); divisor++)
    {
      if ( (x % divisor) == 0 ){
      Console.Write(" {0} ", divisor);
      sum += divisor;
        }
    if (x > 1){
      Console.Write(" {0}", x);
      sum += x;
    }
    Console.WriteLine("");
    Console.WriteLine("Sum of divisors: {0}", sum);

    if ( sum == x){
      Console.WriteLine("Perfect Number");
    }
    else{
      Console.WriteLine("Not a Perfect Number");
    }
    }
  }
  }

  
