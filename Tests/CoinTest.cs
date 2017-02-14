using Xunit;
using System;
using System.Collections.Generic;

namespace CoinCombo
{
  public class CointTest
  {
    [Fact]
    public void CoinComboTest_ForUserInputs1_1()
    {
      Coin testCoin = new Coin();
      Assert.Equal("1", testCoin.Coins("1"));
    }
    [Fact]
    public void CoinComboTest_ForUserInputs1_return1penny()
    {
      Coin testCoin = new Coin();
      Assert.Equal("1 penny", testCoins("1"));
    }
  }
}
