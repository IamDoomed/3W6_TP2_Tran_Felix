namespace NutriVie.Models
{
    public class StatsVM
    {
        public int NombreRecettesTroisAliments { get; set; }
        public string AlimentPlusCalorique { get; set; } = string.Empty;
        public List<(string Nom, int TempsTotal)> RecettesCourtes { get; set; } = new();
        public double CaloriesRecetteFrancaiseMoinsCalorique { get; set; }
    }
}
