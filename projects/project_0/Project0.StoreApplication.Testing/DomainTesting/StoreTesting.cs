using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Testing.DomainTesting
{
  public class StoreTesting

  {
    [Fact]
    public void Test_Store()
    {

      //arrange - instance of the entity of test
      var sut = new Store();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }




    [Fact]
    public void Test_ToString()
    {
      var sut = new Store();
      sut.ToString();
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

