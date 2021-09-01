using Xunit;
using Project0.StoreApplication.Domain.Models;


namespace Project0.StoreApplication.Testing.DomainTesting
{
  public class CustomerTesting

  {
    [Fact]
    public void Test_Customer()
    {

      //arrange - instance of the entity of test
      var sut = new Customer();

      //act = execute sut for data
      //var actual = sut.ToString();

      //assert
      //Assert.NotNull(actual);
    }




    [Fact]
    public void Test_ToString()
    {
      var sut = new Customer();
      sut.ToString();
    }
  }
}