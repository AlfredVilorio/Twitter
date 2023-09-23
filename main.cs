using System;

class Program {
  public static void Main (string[] args) {
   int twc = 140; // Maximum wordcount//
    
    //Input message//
    Console.WriteLine("Enter a message: ");
    string wordcountinput = Console.ReadLine();

    //If wordcount does not exceed it is posted//
     if(wordcountinput.Length < twc)
    
      {
        Console.WriteLine("Posted");
        }

    //If wordcount exceeds, it is not posted//
    else{

        Console.WriteLine("The message exceeds wordcount");
  
      
    
    }
    }
  }
  
      