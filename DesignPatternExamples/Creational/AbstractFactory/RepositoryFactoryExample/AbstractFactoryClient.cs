namespace DesignPatternExamples.Creational.AbstractFactory.RepositoryFactoryExample
{
    public class AbstractFactoryClient
    {
        public void RunDemo()
        {
            RepositoryAbstractFactory factory = new ConcreteFactories.EFRepositoryFactory();
            IBooksRepository booksRepository = factory.CreateBooksRepository();
            IProductsRepository productsRepository = factory.CreateProductsRepository();
        }
    }
}