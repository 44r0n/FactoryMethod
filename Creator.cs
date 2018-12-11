namespace FactoryMethodPattern
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            Product product = FactoryMethod();
            product.Operation();
        }
    }
}