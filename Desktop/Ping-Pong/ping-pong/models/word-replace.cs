using System;
using System.Collections.Generic;

public class Words {
  static void Main() {
    Console.WriteLine("Enter a number!");
    int userNum = int.Parse(Console.ReadLine());
    List<string> userList = new List<string> {};

    for (int i = 0; i <= userNum ; i++) {
      userList.Add(i.ToString());
      if (i % 3 == 0) {
        userList[i] = "ping";
      } else if (i % 5 == 0) {
        userList[i] = "pong";
      } else if ((i % 3 == 0) && (i % 5 == 0)) {
        userList[i] = "ping-pong";
      }
    Console.WriteLine(userList[i]);
    }
  }
}

// groceryList.Add("spaghetti");