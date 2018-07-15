using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HRDesk.Models
{
    public class Interview 
    {
        public int Id { get; set; }        
        public string PersonName { get; set; }
        public string PersonSername { get; set; }
        public string PersonPatronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime InterviewDate { get; set; }

        public int VacancyId { get; set; }
        [ForeignKey("VacancyId")]
        public Vacancy Vacancy { get; set; }
    }
}
