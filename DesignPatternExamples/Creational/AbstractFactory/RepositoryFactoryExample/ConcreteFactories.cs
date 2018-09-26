namespace DesignPatternExamples.Creational.AbstractFactory.RepositoryFactoryExample
{
    public class ConcreteFactories
    {
        public class EFRepositoryFactory : RepositoryAbstractFactory {
            public override IBooksRepository CreateBooksRepository()
            {
                return new EFBooksRepoistory();
            }

            public override IProductsRepository CreateProductsRepository()
            {
                return new EFProductsRepoistory();
            }
        }
        public class SqlRepositoryFactory : RepositoryAbstractFactory {
            public override IBooksRepository CreateBooksRepository()
            {
                return new EFBooksRepoistory();
            }

            public override IProductsRepository CreateProductsRepository()
            {
                return new SqlProductsRepoistory();
            }
        }
    }
}