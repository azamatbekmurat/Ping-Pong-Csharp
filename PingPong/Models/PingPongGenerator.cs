using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _number;
    private int _id;
    private static int _lastId = 0;

    private static List<PingPongGenerator> _instances = new List<PingPongGenerator> {};

    public Contact(int inputNumber)
    {
      _number = inputNumber;

    }

    public int GetNumber()
    {
      return _number;
    }

    public static GetRange(int num)
    {
      for (var i=0; i<=num.Count; i++)
      {
        // to be finished
      }

    }

    public string ToReplace(int number)
    {
          if (number % 15 == 0)
          {
            return "ping-pong";
          } else if (number % 5 == 0) {
            return "pong";
          } else if (number % 3 == 0) {
            return "ping";
          } else {
            return "false";
          }
    }
  }
}
