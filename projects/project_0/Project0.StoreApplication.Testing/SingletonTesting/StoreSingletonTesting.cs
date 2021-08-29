using Xunit;
using Project0.StoreApplication.Client.Singletons;



namespace Project0.StoreApplication.Testing.SingletonTesting
{
  public class StoreSingletonTesting

  {
    [Fact]
    public void Test_CustSing()
    {

      //arrange - instance of the entity of test
      var sut = StoreSingleton.Instance;

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }


    /*
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
          public void Test_OneStore(int i)
         {
           var sut = new StoreRepository();
           var store = sut.GetStore(i);
           Assert.NotNull(store);
         } */
  }
}


