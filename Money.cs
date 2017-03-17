namespace ShoppingCartKata
{
    public class Money
    {
        private int _value;

        public Money(int value)
        {
            _value = value;
        }

        public override bool Equals(object obj) => ((Money)obj)._value == _value;

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString();

        public Money Add(Money money) => new Money(money._value + _value);

        internal Money Multiply(int number) => new Money(_value * number);
    }
}
