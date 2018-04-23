using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
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
