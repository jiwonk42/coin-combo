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

      int dimeInt = (centsInt - 25 * quarterInt) / 10;
      string dime = dimeInt.ToString() + " Dime";

      if(dimeInt > 0)
      {
        coinResult.Add(dime);
      }

      int nickelInt = (centsInt - 25 * quarterInt - 10 * dimeInt) / 5;
      string nickel = nickelInt.ToString() + " Nickel";

      if(nickelInt > 0)
      {
        coinResult.Add(nickel);
      }

      return coinResult;
    }
  }
}
