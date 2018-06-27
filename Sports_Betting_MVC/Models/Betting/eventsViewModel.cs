using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sports_Betting_MVC.Models.Betting
{
    public class eventsViewModel
    {
        public eventsViewModel()
        {
            this.events = new List<MatchViewModel>();
        }

        public ICollection<MatchViewModel> events { get; set; }
    }
}