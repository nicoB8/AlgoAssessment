using Xunit;

namespace TGS.Challenge.Tests
{
  public class EquivalenceIndexTests
  {
    private readonly EquivalenceIndex _equivalenceIndex;

    public EquivalenceIndexTests()
    {
      this._equivalenceIndex= new EquivalenceIndex();
    }

    [Fact]
    public void Returns_Index_ForValidNumberSequence()
    {
        var index = _equivalenceIndex.Find(new int[] { 1, 2, 3, 4, 5, 7, 8, 10, 12 });

        Assert.Equal(6, index);
    }

    [Fact]
    public void Retruns_Neg1_ForInvalidNumberSequence()
    {
      var index = _equivalenceIndex.Find(new int[] { 2, 2, 3, 4, 3, 74, 8, 10, 12 });

      Assert.Equal(-1, index);
    }
  }  
}