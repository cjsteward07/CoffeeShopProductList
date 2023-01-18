using CoffeeShopProductList.Models;

namespace CoffeeShopProductList

{
    public class ProductListRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        private List<ProductViewModel> _mockProducts;

        public ProductListRepository()
        {
            CreateMockProductList();
        }
        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1, Name = "Bread", Description = "White", Price = 1.99M, Category = "Baked Goods" });
            _mockProducts.Add(new ProductViewModel { Id = 2, Name = "Milk", Description = "Whole", Price = 3.99M, Category = "Dairy" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "KitKat Bar", Description = "Snack Size", Price = .75M, Category = "Candy" });
            _mockProducts.Add(new ProductViewModel { Id = 4, Name = "Prime Rib", Description = "16oz", Price = 1.99M, Category = "Meat" });
            _mockProducts.Add(new ProductViewModel { Id = 5, Name = "Diet Coke", Description = "Can 12oz", Price = .89M, Category = "Soft Drink" });
        }
        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }

        public void UpdateProducts(ProductViewModel product)
        {
            int index = _mockProducts.FindIndex(x => x.Id == product.Id);
            _mockProducts[index] = product;
        }
        public void DeleteProduct(int id)
        {
            int index = _mockProducts.FindIndex(x => x.Id == id);
            _mockProducts.RemoveAt(index);
        }

        public void CreateProduct(ProductViewModel product)
        {
            product.Id = _mockProducts.Max(x => x.Id) + 1;
            _mockProducts.Add(product);
        }
    }
}
