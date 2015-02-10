using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitForIt.Repository
{
    class EventRepository : IEventRepository
    {
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Event> PastEvents()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Event> All()
        {
            throw new NotImplementedException();
        }

        public Model.Event GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Event GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Event> SearchFor(System.Linq.Expressions.Expression<Func<Model.Event, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
