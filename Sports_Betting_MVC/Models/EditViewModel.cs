using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sports_Betting_MVC.Models
{
    public class EditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 10000)]
        public double OddsForFirstTeam { get; set; }

        [Required]
        [Range(1, 10000)]
        public double OddsForDraw { get; set; }

        [Required]
        [Range(1, 10000)]
        public double OddsForSecondTeam { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
    }
}