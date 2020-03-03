namespace FantasyStatsTracker.Api.Interfaces
{
    public interface IDataStore<T>
    {
        void Add(T item);
        T Get(int id);
        T Update(T item);
        void Remove(T item);
    }
}