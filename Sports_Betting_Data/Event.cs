﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Betting_Data
{
    public class Event
    {
        public int Id { get; set; }

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