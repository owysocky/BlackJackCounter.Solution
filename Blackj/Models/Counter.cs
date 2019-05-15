using System;
using System.Collections.Generic;

namespace Blackj.Models
{
  public class Counter
  {
    private int runningTotal;
    private int trueTotal;
    private int totalCardsUsed;

    public int GetRunningTotal(int input)
    {
      return runningTotal += input;
    }

    public int GetTrueCount()
    {
      int decksUsed = totalCardsUsed / 52;
      return runningTotal / (6 - decksUsed);
    }
  }
}
