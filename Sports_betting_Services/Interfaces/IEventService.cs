using Sports_Betting_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_betting_Services.Interfaces
{
    public interface IEventService
    {
        ICollection<Event> GetAll();

        void AddsNew();

        void DeleteEvent(int id);

        Event UpdateEvent(int Id, string Name, double OddsForFirstTeam, double OddsForDraw, double OddsForSecondTeam,
      DateTime StartDate);
    }
}
