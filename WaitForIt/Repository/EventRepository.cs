using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitForIt;
using System.Data.Entity;

namespace WaitForIt.Repository
{
    public class EventRepository : IEventRepository
    {
        private EventContext _dbContext;

        public EventRepository()
        {
            _dbContext = new EventContext();
        }

        public DbSet<Model.Event> GetDbSet()
        {
            return _dbContext.Events;
        }

        public int GetCount()
        {
            throw new NotImplementedException();

        }

        public void Add(Model.Event E)
        {
            throw new NotImplementedException();
            // _dbContext.SaveChanges();
        }

        public void Delete(Model.Event E)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Event> PastEvents()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Model.Event E)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Event> All()
        {
            throw new NotImplementedException();
        }

        public Model.Event GetById(int id)
        {
            var query = from Event in _dbContext.Events
                        where Event.EventId == id
                        select Event;
            return query.First<Model.Event>();

        }

        public Model.Event GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Event> SearchFor(System.Linq.Expressions.Expression<Func<Model.Event, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
