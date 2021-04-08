using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class Vaccin
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Type de vaccin")]
        [MaxLength(50)]
        public string TypeVaccin { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marque { get; set; }

        [Required]
        public int NumLot { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date du prochain rappel")]
        public DateTime DateRappel { get; set; }

        [Required]
        [Display(Name = "Personne")]
        public virtual Personne Personne { get; set; }
    }
}
