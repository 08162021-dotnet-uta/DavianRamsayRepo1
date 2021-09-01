using Xunit;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;

namespace Project0.StoreApplication.Testing.DomainTesting
{
  public class OrderSingletonTesting

  {
    [Fact]
    public void Test_OrderSing()
    {

      //arrange - instance of the entity of test
      var sut = OrderSingleton.Instance;

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