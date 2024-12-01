namespace ТDD._1
{
    internal class Product
    {
        private string expectedName;
        private decimal expectedPrice;
        private int expectedQuantity;

        public Product(string expectedName, decimal expectedPrice, int expectedQuantity)
        {
            this.expectedName = expectedName;
            this.expectedPrice = expectedPrice;
            this.expectedQuantity = expectedQuantity;
        }
    }
}