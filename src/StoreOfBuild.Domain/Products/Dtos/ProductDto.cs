namespace StoreOfBuild.Domain.Products
{
    public class ProductDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        //verificar
        public int categoryid { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
    }

}