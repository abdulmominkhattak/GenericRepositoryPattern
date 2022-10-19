namespace GenericRepo.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {  

        List<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
 
    }
}
