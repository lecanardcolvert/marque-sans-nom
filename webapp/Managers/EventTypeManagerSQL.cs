using System;
using Services;
using Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Managers
{
    /// <summary>
    ///   This is the final class that the user need to instanciate or to provide to the dependency injection system to work with the <see cref="EventType"/> entity type in the database.
    /// - The user can override the CRUD method implemented in the abstract class <see cref="NormalCrudOperationSQL<TEntity>"/> if needed.
    /// - If the user want to implement a method that is only specific to the Business entity type, declare it in the <see cref="IEventTypeServices"/> then implement it in this class.
    /// - The only method that can be declared and implemented directly in this class are privates methods for the side logic or method that will be only needed for the SQL provider.
    /// </summary>
    public class EventTypeManagerSQL : NormalCrudOperationSQL<EventType>, IEventTypeServices
    {
        public EventTypeManagerSQL(AppDbContext context, ILogger<NormalCrudOperationSQL<EventType>> logger) : base(context, logger)
        {

        }

        public async Task<List<Event>> GetEventsFromEventTypeName(string eventTypeTitle)
        {
            List<Event> events = null;
            var eventType = await _context.EventTypes
                                                .Where(e => e.Title == eventTypeTitle)
                                                .Include(e => e.Events)
                                                .FirstOrDefaultAsync();
            if(eventType != null)
            {
                events = eventType.Events;
            }

            return events;
        }
    }
}