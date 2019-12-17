using System;

namespace ToDoList.Models {
  public class Program {
      static void Main()
      {
          Console.WriteLine("YOYOYO we made it in here.");
          Item testItem = new Item("YOYOYO we made it in here.");
          Console.WriteLine(testItem.GetType());
          Console.WriteLine(testItem.Description);
      }

  }
}