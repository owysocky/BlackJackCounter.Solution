using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackj.Models;

namespace Blackj.Tests
{
  [TestClass]
  public class CountTest
  {
    [TestMethod]
    public void CounterConstructor_CreateInstanse_Count()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
  }
}
