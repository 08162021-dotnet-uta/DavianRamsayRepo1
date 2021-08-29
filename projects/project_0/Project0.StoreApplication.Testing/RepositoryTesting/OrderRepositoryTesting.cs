using Xunit;
using Project0.StoreApplication.Storage.Repositories;



namespace Project0.StoreApplication.Testing.RepositoryTesting
{
  public class OrderRepositoryTesting

  {
    [Fact]
    public void Test_OrderRepo()
    {

      //arrange - instance of the entity of test
      var sut = new OrderRepository();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }

    [Fact]
    public void TestInsert()
    {
      var sut = new OrderRepository();
      var actual = sut.Select();
      Assert.NotNull(actual);
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


