using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartKata
{
    [TestClass]
    public class ShoppingCartSpec
    {
        ShoppingCart _shoppingCart;

        [TestInitialize]
        public void Setup()
        {
            _shoppingCart = new ShoppingCart();
        }

        [TestMethod]
        public void Scan_A_returns_50()
        {
            _shoppingCart.Scan(new Product("A"));

            Assert.AreEqual(new Money(50), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_B_returns_30()
        {
            _shoppingCart.Scan(new Product("B"));

            Assert.AreEqual(new Money(30), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_all_products_returns_105()
        {
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("B"));
            _shoppingCart.Scan(new Product("C"));
            _shoppingCart.Scan(new Product("D"));

            Assert.AreEqual(new Money(105), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_three_As_returns_130()
        {
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));

            Assert.AreEqual(new Money(130), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_six_As_returns_260()
        {
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));

            Assert.AreEqual(new Money(260), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_five_As_returns_230()
        {
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));
            _shoppingCart.Scan(new Product("A"));

            Assert.AreEqual(new Money(230), _shoppingCart.GetTotal());
        }

        [TestMethod]
        public void Scan_2_Bs_returns_50()
        {
            _shoppingCart.Scan(new Product("B"));
            _shoppingCart.Scan(new Product("B"));

            Assert.AreEqual(new Money(50), _shoppingCart.GetTotal());
        }
    }    
}
