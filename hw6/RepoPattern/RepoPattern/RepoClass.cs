using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern
{
    public class RepoClass<T> : IRepository<T> where T : class ,IID
    {
        private readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void Save()
        {
            // Implementation for saving changes to a data source (if applicable)
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public T GetById(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }
    }
}
