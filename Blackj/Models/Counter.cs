using System;
using System.Collections.Generic;

namespace Blackj.Models
{
  public class Counter
  {
    private int _runningTotal;
    private int _trueTotal;
    private int _totalCardsUsed;

    public Counter()
    {
      _runningTotal = 0;
      _trueTotal = 0;
      _totalCardsUsed = 0;
    }

    public int GetRunningTotal()
    {
      return _runningTotal;
    }
    public int AddRunningTotal(int input)
    {
      return _runningTotal += input;
    }

    public int GetTotalCardsUsed()
    {
      return _totalCardsUsed + 1;
    }

    public int GetTrueCount()
    {
      int decksUsed = _totalCardsUsed / 52;
      return _runningTotal / (6 - decksUsed);
    }
  }
}
