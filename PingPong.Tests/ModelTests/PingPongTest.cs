using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void IsPing_NumberDivisibleByThree_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("0", testPingPong.ToReplace(0));
    }
    // [TestMethod]
    // public void IsPing_NumberDivisibleByFive_True()
    // {
    //   PingPongGenerator testPingPong = new PingPongGenerator();
    //   Assert.AreEqual("pong", testPingPong.ToReplace(5));
    // }
    // [TestMethod]
    // public void IsPing_NumberDivisibleByFifteen_True()
    // {
    //   PingPongGenerator testPingPong = new PingPongGenerator();
    //   Assert.AreEqual("ping-pong", testPingPong.ToReplace(15));
    // }
    // [TestMethod]
    // public void IsPing_NumberNonDivisibleByFive_True()
    // {
    //   PingPongGenerator testPingPong = new PingPongGenerator();
    //   Assert.AreEqual("false", testPingPong.ToReplace(4));
    // }

  }
}
