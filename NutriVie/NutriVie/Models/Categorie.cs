using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }

    }
}
