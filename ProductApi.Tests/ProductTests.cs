using ProductApi.Models;

namespace ProductApi.Tests;

public class ProductTests
{
    [Fact]
    public void Product_Should_Have_Correct_Name()
    {
        var product = new Product
        {
            Id = 1,
            Name = "Portátil",
            Price = 999
        };

        Assert.Equal("Portátil", product.Name);
    }

    [Fact]
    public void Product_Price_Should_Be_Greater_Than_Zero()
    {
        var product = new Product
        {
            Id = 2,
            Name = "Monitor",
            Price = 250
        };

        Assert.True(product.Price > 0);
    }
}