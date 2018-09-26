namespace DesignPatternExamples.Creational.AbstractFactory.RepositoryFactoryExample
{
    #region Abstractions
    public interface IRepository
    {
    }

    public interface IBooksRepository : IRepository { }
    public interface IProductsRepository : IRepository { }
    #endregion

    #region Implementations
    public class EFBooksRepoistory : IBooksRepository { }
    public class EFProductsRepoistory : IProductsRepository { }

    public class SqlBooksRepoistory : IBooksRepository { }
    public class SqlProductsRepoistory : IProductsRepository { }
    #endregion
}