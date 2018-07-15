using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRDesk.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DesiredClosingDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public List<Interview> Interviews { get; set; }
    }
}
