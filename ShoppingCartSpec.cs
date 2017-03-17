using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoppingCartKata
{
    [TestClass]
    public class ShoppingCartSpec
    {
        [TestMethod]
        public void Scan_A_Returns_50()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Scan(new Product("A"));

            Assert.AreEqual(new Money(50), shoppingCart.GetTotal());
        }
    }

    public class ShoppingCart
    {
        private readonly List<Product> _scannedProducts;

        public ShoppingCart()
        {
            _scannedProducts = new List<Product>();
        }

        public void Scan(Product product)
        {
            _scannedProducts.Add(product);
        }

        public Money GetTotal()
        {
            return new Money(50);
        }
    }

    public class Product
    {
        private string Sku;

        public Product(string sku)
        {
            Sku = sku;
        }

        public override bool Equals(object obj)
        {
            return ((Product)obj).Sku == Sku;
        }

        public override int GetHashCode()
        {
            return Sku.GetHashCode();
        }

        public override string ToString()
        {
            return Sku;
        }
    }

    public class Money
    {
        private int Value;

        public Money(int value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return ((Money)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
