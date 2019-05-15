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
      Counter newCounter = new Counter(1, 1, 1);
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }

    [TestMethod]
    public void GetRunningTotal_CountTotal_Int()
    {
      Counter newCounter = new Counter(0, 0, 0);
      int result = newCounter.GetRunningTotal(1);
      Assert.AreEqual(result, 1);
    }
  }
}
