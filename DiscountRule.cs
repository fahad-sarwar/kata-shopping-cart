using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartKata
{
    public class DiscountRule
    {
        private Product _product;
        private int _numberOfInstances;
        private Money _discountPrice;

        public DiscountRule(Product product, int numberOfInstances, Money discountPrice)
        {
            _product = product;
            _numberOfInstances = numberOfInstances;
            _discountPrice = discountPrice;
        }

        public Money GetDiscount(List<Product> basket)
        {
            var count = basket.Count(p => p.Equals(_product)) / _numberOfInstances;

            return count > 0
                ? _discountPrice.Multiply(count)
                : new Money(0);
        }
    }
}
