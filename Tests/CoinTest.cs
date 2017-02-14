using Xunit;
using System;
using System.Collections.Generic;

namespace CoinCombo
{
  public class CointTest
  {
    [Fact]
    public void CoinComboTest_ForUserInputs25_1Q()
    {
      Coin testCoin = new Coin();
      List<string> expected = new List<string>{};
      expected.Add("1 Quarter");
      Assert.Equal(expected, testCoin.Coins("25"));
    }

    [Fact]
    public void CoinComboTest_ForUserInputs35_1Q1D()
    {
      Coin testCoin = new Coin();
      List<string> expected = new List<string>{};
      expected.Add("1 Quarter 1 Dime");
      Assert.Equal(expected, testCoin.Coins("35"));
    }
  }
}
