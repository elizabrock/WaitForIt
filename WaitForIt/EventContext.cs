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

        public DbSet<Event> Events { get; set; }
    }
}
