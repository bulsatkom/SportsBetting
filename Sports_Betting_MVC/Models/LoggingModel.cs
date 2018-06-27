using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sports_Betting_MVC.Models
{
    public class LoggingModel
    {
        public int Id { get; set; }

        public string SelectedOdd { get; set; }

        public double Coeff { get; set; }
    }
}