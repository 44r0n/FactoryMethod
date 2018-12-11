using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteCreator(new ConcreteCreatorA());
            ExecuteCreator(new ConcreteCreatorB());
        }

        static void ExecuteCreator(Creator creator)
        {
            creator.AnOperation();
        }
    }
}
