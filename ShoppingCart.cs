using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartKata
{
    public class ShoppingCart
    {
        private readonly List<Product> _basket;

        private static Dictionary<Product, Money> _priceList = new Dictionary<Product, Money>
        {
            { new Product("A"), new Money(50) },
            { new Product("B"), new Money(30) },
            { new Product("C"), new Money(15) },
            { new Product("D"), new Money(10) }
        };

        public ShoppingCart()
        {
            _basket = new List<Product>();
        }

        public void Scan(Product product)
        {
            _basket.Add(product);
        }

        public Money GetTotal()
        {
            var total = _basket.Aggregate(new Money(0), (current, product) => current.Add(_priceList[product]));

            return total.Add(new Discounter(_basket).CalculateDiscount());
        }
    }
}
