namespace FactoryMethodPattern
{
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ProductA();
    }
}