using Azure;

namespace examen.Models
{
    public class Compte
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public decimal Solde { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Operation> Operations { get; set; }

    }
}
