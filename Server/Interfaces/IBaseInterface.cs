namespace Server.Interfaces
{
    public interface IBaseInterface<T>
    {
        public List<T> GetAll();
    }
}
