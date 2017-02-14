using System;
using System.Collections.Generic;

namespace CoinCombo
{
  public class Coin
  {
    public List<string> Coins(string cents)
    {
      int centsInt = int.Parse(cents);
      List<string> coinResult = new List<string>{};

      int quarterInt = centsInt / 25;
      string quarter = quarterInt.ToString() + " Quarter";

      if(quarterInt > 0)
      {
        coinResult.Add(quarter);
      }

      string dime = ((centsInt - 25 * quarterInt) / 10).ToString() + " Dime";

      if(quarterInt > 0)
      {
        coinResult.Add(dime);
      }

      return coinResult;
    }
  }
}
