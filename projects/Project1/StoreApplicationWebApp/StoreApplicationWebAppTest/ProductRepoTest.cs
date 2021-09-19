using StoreApplicationWebAppBusinessLayer.Repositories;
using System;
using Xunit;

namespace StoreApplicationWebAppTest
{
    public class ProductRepoTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new ProductRepo();
            var actual = sut;
            Assert.NotNull(actual);

        }
    }
}
