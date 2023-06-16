namespace examen.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Montant { get; set; }
        public DateTime Date { get; set; }
        public int CompteId { get; set; }
        public Compte Compte { get; set; }
    }
}
