using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Testing.DomainTesting
{
  public class ProductTesting

  {
    [Fact]
    public void Test_Product()
    {

      //arrange - instance of the entity of test
      var sut = new Product();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }




    [Fact]
    public void Test_ToString()
    {
      var sut = new Product();
      sut.ToString();
    }
  }
}