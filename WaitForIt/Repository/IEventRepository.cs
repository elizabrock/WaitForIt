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
        int GetCount(); //
        void Add(Event E); //
        void Delete(Event E); //
        void Clear(); //
        IEnumerable<Event> PastEvents(); //
        int CalculateMonth(Event E); //
        IEnumerable<Event> All(); //
        Event GetById(int id); //
        Event GetByDate(string date); //
        IQueryable<Event> SearchFor(Expression<Func<Event, bool>> predicate);

        
     
    }
}
