using System;

class MainClass {
  public static void Main(string[] args) {
    
    // Объекты
    // User user1 = new User();
    // User user2 = new User();

    // user1.name = "Ilya";
    // user1.password = "1234";

    // user2.name = "Artem";
    // user2.password = "1234555";

// Вариант с конструктором
    User user1 = new User() { Name = "Ilya", Password = "1234" };

// Бесполезно, т.к. есть конструктор
    // user1.Name = "asdf";
    // user1.Password = "1234";

    Console.WriteLine(user1.Name);
    Console.WriteLine(user1.Password);

    // user1.GetInfo();
    // user2.GetInfo(); 

  }
}

// Пример реального класса 
class User {
  public string Name { get; set; }
  public string Password { get; set; }

// Це конструктор
  // public User(string name, string password) {
  //   Name = name;
  //   Password = password;
  // }
}

// Пример обычного класса
// class User {
//   // field
//   private string name;
//   private string password;

//   // property
//   public string Name {
//     get {
//       string str = "Iluha ";

//       return str + name.ToUpper();
//     }

//     set {
//       name = value;
//     }
//   }

//   public string Password {
//     get {
//       return password;
//     }

//     set {
//       password = value;
//     }
//   }
// }

// Пример супер простого, даже нереального класса
// class User {
//   public string name;
//   public string password;

//   public void GetInfo() {
//     Console.WriteLine($"{ name } - { password }");
//   }
// }