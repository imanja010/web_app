using web_app.Models;

namespace web_app.Services
{
    public class DbService<T> where T : Entity
    {
        private List<T> _data = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T? GetById(long id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Remove(long id)
        {
            var item = _data.FirstOrDefault(x => x.Id == id);
            if(item != null)
            {
                _data.Remove(item);
            }
        }
    }
}
