using System;
using System.Collections.Generic;

namespace Blackj.Models
{
  public class Counter
  {
    private int _runningTotal;
    private int _trueTotal;
    private int _totalCardsUsed;

    public Counter(int runningTotal, int trueTotal, int totalCardsUsed)
    {
      _runningTotal = runningTotal;
      _trueTotal = trueTotal;
      _totalCardsUsed = totalCardsUsed;
    }

    public int GetRunningTotal(int input)
    {
      return _runningTotal += input;
    }

    public int GetTotalCardsUsed()
    {
      return _totalCardsUsed++;
    }

    public int GetTrueCount()
    {
      int decksUsed = _totalCardsUsed / 52;
      return _runningTotal / (6 - decksUsed);
    }
  }
}
