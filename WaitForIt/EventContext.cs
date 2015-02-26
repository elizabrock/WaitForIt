using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WaitForIt.Model;

namespace WaitForIt
{
    public class EventContext: DbContext
    {
        public EventContext(string connection="WaitForIt.EventContext") : base(connection)
        {

        }
        public DbSet<Event> Events { get; set; }
    }
}
