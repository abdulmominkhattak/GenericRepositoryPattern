using GenericRepo.Data;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private GenericRepoContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<T> table;

        public GenericRepository(GenericRepoContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }


        public void Delete(object Id)
        {
            T exits = table.Find(Id);
            table.Remove(exits);
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
         }
    }

}