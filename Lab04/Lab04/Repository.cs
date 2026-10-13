using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    public class Repository<T> where T : IEntity
    {
        private readonly List<T> danhSach;

        public Repository()
        {
            danhSach = new List<T>();
        }

        public void Add(T item)
        {
            danhSach.Add(item);
        }

        public bool Remove(string id)
        {
            T? item = FindById(id);

            if (item == null)
            {
                return false;
            }

            danhSach.Remove(item);
            return true;
        }

        public T? FindById(string id)
        {
            return danhSach.FirstOrDefault(
                item =>
                    item.Id.Equals(
                        id,
                        StringComparison.OrdinalIgnoreCase
                    )
            );
        }

        public List<T> Find(Func<T, bool> dieuKien)
        {
            return danhSach
                .Where(dieuKien)
                .ToList();
        }

        public List<T> GetAll()
        {
            return danhSach.ToList();
        }
    }
}