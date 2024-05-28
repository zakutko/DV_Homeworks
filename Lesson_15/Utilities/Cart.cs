using Lesson_15.Models;

namespace Lesson_15.Utilities
{
    public class Cart
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddToCart(Product product)
        {
            _products.Add(product);
        }

        public void RemoveFromCart(int productId)
        {
            _products.RemoveAll(x => x.Id == productId);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;

            _products.ForEach(x => totalPrice += x.Price);

            return totalPrice;
        }
    }
}
