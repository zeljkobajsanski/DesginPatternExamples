namespace DesignPatternExamples.Creational.AbstractFactory.RepositoryFactoryExample
{
    public abstract class RepositoryAbstractFactory
    {
        IBooksRepository CreateBooksRepository();
        IProductsRepository CreateProductsRepository();
    }
}