namespace FactoryMethodPattern
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ProductB();
    }
}