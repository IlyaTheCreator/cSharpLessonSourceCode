// using System;

// class MainClass {
//   public static void Main (string[] args) {
    
    

//   }
// }

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] arg) {
    // string userInput = Console.ReadLine();

    // Console.WriteLine(userInput + " - вот это ты сказал");
    Console.WriteLine(MyClass.add(1, 18));

    poop.Book book1 = new poop.Book("1984", "super author");

    Console.WriteLine(book1.Name + " " + book1.Author);
  }
}

class MyClass {
  public static int add(int num1, int num2) {
    return num1 + num2;
  }
}




