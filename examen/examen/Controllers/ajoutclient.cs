using examen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace examen.Controllers
{
    public class ajoutclient
    {
        public IActionResult AjouterClientCompteOperation(Client client)
        {
            // Ajouter le client à la base de données
            _context.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
