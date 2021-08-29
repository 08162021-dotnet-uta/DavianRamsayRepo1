using Xunit;
using Project0.StoreApplication.Storage.Repositories;



namespace Project0.StoreApplication.Testing.RepositoryTesting
{
  public class CustomerRepositioryTesting

  {
    [Fact]
    public void Test_CustRepo()
    {

      //arrange - instance of the entity of test
      var sut = new CustomerRepository();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }

    [Fact]
    public void TestInsert()
    {
      var sut = new CustomerRepository();
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


