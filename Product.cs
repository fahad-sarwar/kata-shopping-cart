namespace ShoppingCartKata
{
    public class Product
    {
        private string Sku;

        public Product(string sku)
        {
            Sku = sku;
        }

        public override bool Equals(object obj) => ((Product)obj).Sku == Sku;

        public override int GetHashCode() => Sku.GetHashCode();

        public override string ToString() => Sku;
    }
}
