using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Testing.DomainTesting
{
  public class OrderTesting

  {
    [Fact]
    public void Test_Order()
    {

      //arrange - instance of the entity of test
      var sut = new Order();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }




    [Fact]
    public void Test_ToString()
    {
      var sut = new Order();
      sut.ToString();
    }
  }
}