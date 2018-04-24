using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _number;
    // private int _id;
    // private static int _lastId = 0;

    private List<string> _listNumbers = new List<string>() {};

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
        if (i==0) {
          _listNumbers.Add(i.ToString());
        } else {
          if (i % 15 == 0)
          {
            _listNumbers.Add("ping-pong");
          } else if (i % 5 == 0) {
            _listNumbers.Add("pong");
          } else if (i % 3 == 0) {
            _listNumbers.Add("ping");
          } else {
            _listNumbers.Add(i.ToString());
          }
        }
      }
    }

    public List<string> GetAll()
    {
      return _listNumbers;
    }

  }
}
