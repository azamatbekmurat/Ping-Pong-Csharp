using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _number;
    // private int _id;
    // private static int _lastId = 0;

    private static List<PingPongGenerator> _listNumbers = new List<PingPongGenerator>() {};

    public PingPongGenerator(int Number)
    {
      _number = Number;
    }

    public int GetNumber()
    {
      return _number;
    }
    public void ToReplace()
    {
      for (var i=0; i<=_number; i++) {
          if (_number % 15 == 0)
          {
            _listNumbers.Add("ping-pong");
          } else if (_number % 5 == 0) {
            _listNumbers += i;
          } else if (_number % 3 == 0) {
            _listNumbers += "ping";
          } else {
            _listNumbers.Add(i.ToString());
          }
      }
    }

    public static List<PingPongGenerator> GetAll()
    {
      return _listNumbers;
    }

  }
}
