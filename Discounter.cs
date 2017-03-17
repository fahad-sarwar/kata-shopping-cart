using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartKata
{
    public class Discounter
    {
        private List<Product> _basket;

        private static List<DiscountRule> _rules = new List<DiscountRule>
        {
            new DiscountRule(new Product("A"), 3, new Money(-20)),
            new DiscountRule(new Product("B"), 2, new Money(-10)),
        };

        public Discounter(List<Product> basket)
        {
            _basket = basket;
        }

        public Money CalculateDiscount()
        {
            return _rules.Aggregate(new Money(0), (current, rule) => current.Add(rule.GetDiscount(_basket)));
        }
    }
}
