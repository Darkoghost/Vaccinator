using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class Personne
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(5)]
        public string Sexe { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de naissance")]
        public DateTime AnneeDeNaissance { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public virtual ICollection<Vaccin> Vaccins { get; set; }

    }
}
