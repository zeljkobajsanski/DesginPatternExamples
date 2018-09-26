namespace DesignPatternExamples.Creational.AbstractFactory.RepositoryFactoryExample
{
    public abstract class RepositoryAbstractFactory
    {
        public abstract IBooksRepository CreateBooksRepository();
        public abstract IProductsRepository CreateProductsRepository();
    }
}