using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitForIt;
using System.Data.Entity;
//using WaitForIt.Model;

namespace WaitForIt.Repository
{
    public class EventRepository : IEventRepository
    {
        private EventContext _dbContext;

        public EventRepository()
        {
            _dbContext = new EventContext();
            _dbContext.Events.Load();
        }

        public EventContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.Event> GetDbSet()
        {
            return _dbContext.Events;
        }

        public int GetCount()
        {
            return _dbContext.Events.Count<Model.Event>();

        }

        public void Add(Model.Event E)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Events.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Event E)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Events.RemoveRange(a);
            _dbContext.SaveChanges();
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
            var qu = from Event in _dbContext.Events select Event;
            return qu.ToList<Model.Event>();
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
            var query = from Event in _dbContext.Events
                        where Event.Date == date
                        select Event;
            return query.First<Model.Event>();
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
