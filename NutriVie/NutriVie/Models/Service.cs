using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace NutriVie.Models
{
    public class Service
    {

        public Service() { }

        [Key]
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Max {0} characters.")]
        public string NomService { get; set; }

        [StringLength(120, ErrorMessage = "Max {0} characters.")]
        public string Description { get; set; }

    }
}
