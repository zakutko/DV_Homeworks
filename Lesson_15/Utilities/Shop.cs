using Lesson_15.Models;

namespace Lesson_15.Utilities
{
    public class Shop
    {
        public readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var productToRemove = _products.SingleOrDefault(x => x.Id == productId);

            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
            }
        }

        public Product GetProductById(int productId)
        {
            return _products.Single(x => x.Id == productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
