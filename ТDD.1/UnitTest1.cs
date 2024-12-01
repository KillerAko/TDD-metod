using System;
using Xunit;

namespace ТDD._1
{
    public class ProductTests
    {
        [Fact]
        public void Product_ShouldBeCreatedWithCorrectProperties()
        {
            // Arrange
            string expectedName = "Test Product";
            decimal expectedPrice = 10.5m;
            int expectedQuantity = 3;

            // Act
            var product = new Product(expectedName, expectedPrice, expectedQuantity);
           
            // Assert
            Assert.Equal(expectedName, product.Name);
            Assert.Equal(expectedPrice, product.Price);
            Assert.Equal(expectedQuantity, product.Quantity);
        }

        [Fact]
        public void Price_ShouldBeChangedOnlyToPositiveValue()
        {
            // Arrange
            var product = new Product("Test Product", 10.5m, 3);

            // Act & Assert
            product.Price = 15.0m; // Valid update
            Assert.Equal(15.0m, product.Price);

            Assert.Throws<ArgumentException>(() => product.Price = -5.0m); // Invalid update
        }
    }
}
