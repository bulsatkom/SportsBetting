using Sports_betting_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports_Betting_Data;
using Sports_Betting_Data.Interfaces;

namespace Sports_betting_Services
{
    public class EventService : IEventService
    {
        private readonly IEfDbSetWrapper<Event> context;

        public EventService(IEfDbSetWrapper<Event> context)
        {
            if(context == null)
            {
                throw new ArgumentNullException("Context cannot be null!!!");
            }

            this.context = context;
        }

        public void AddsNew()
        {
            this.context.Add(new Event()
            {
                Id = this.context.All.Count() + 1,
                Name = "",
                OddsForDraw = 1,
                OddsForFirstTeam = 1,
                OddsForSecondTeam = 1,
                StartDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 23, 59, 0, 0 ,DateTimeKind.Utc)
            });

            this.context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var ev = this.context.All.FirstOrDefault(x => x.Id == id);

            if(ev != null)
            {
                this.context.Delete(ev);

                this.context.SaveChanges();
            }
        }

        public ICollection<Event> GetAll()
        {
            return this.context.All.ToList();
        }

        public Event UpdateEvent(int Id, string Name, double OddsForFirstTeam, double OddsForDraw,
            double OddsForSecondTeam, DateTime StartDate)
        {
            var el = this.context.All.FirstOrDefault(x => x.Id == Id);

            el.Name = Name;
            el.OddsForDraw = OddsForDraw;
            el.OddsForFirstTeam = OddsForFirstTeam;
            el.OddsForSecondTeam = OddsForSecondTeam;
            el.StartDate = StartDate;

            this.context.SaveChanges();

            return el;
        }
    }
}
