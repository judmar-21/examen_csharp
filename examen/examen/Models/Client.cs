namespace examen.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public ICollection<Compte> Comptes { get; set; } 
    }
}
