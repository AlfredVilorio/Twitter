using System;

class Program {
  public static void Main (string[] args) {
   int twc = 140;

    Console.WriteLine("Enter a message: ");
    string wordcountinput = Console.ReadLine();

     if(wordcountinput.Length < twc)
    
      {
        Console.WriteLine("Posted");
        }

    else{

        Console.WriteLine("The message exceeds wordcount");
  
      
    
    }
    }
  }
  
      