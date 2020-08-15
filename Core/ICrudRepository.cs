namespace BakeSale.Core
{
    public interface ICrudRepository<TObject> : ICrudMethods<TObject>, IPaging, ISorting, ISearching
    {


    }
}