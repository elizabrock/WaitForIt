using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WaitForIt.Model;

namespace WaitForIt.Repository
{
    public interface IEventRepository
    {
        int GetCount();
        void Add();
        void Delete();
        void Update();
        void Clear();
        IQueryable<Event> PastEvents(); // EventRepository.PastEvents.Where(c => c.CalculateMonth() == 2)
        int CalculateMonth();
        IQueryable<Event> All();
        Event GetById(int id);
        Event GetByDate(string date);
        IQueryable<Event> SearchFor(Expression<Func<Event, bool>> predicate);

        
     
    }
}
