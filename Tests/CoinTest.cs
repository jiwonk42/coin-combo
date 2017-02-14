using Xunit;
using System;
using System.Collections.Generic;

namespace CoinCombo
{
  public class CointTest
  {
    [Fact]
    public void LeetspeakerTranslator_ForUserInputa_a()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("a", testLeetspeaker.Translate("a"));
    }
  }
}
