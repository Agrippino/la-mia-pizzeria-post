using Microsoft.AspNetCore.Mvc;
using PizzeriaAgrippino.Models;
using PizzeriaAgrippino.Utilies;

namespace PizzeriaAgrippino.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {   //il controller dice le liste e il modello 
            //quando chiamo il controller idez il controller si chiama la lista dei post con il metodo getspost()
            // 
            List<Pizze> pizzes = PostData.GetPosts();
            //poi dobbiamo passare una razor, quindi inseriamo il nome della lista, cioè pizzes 
            // potremmo anche non inserire homepage nel caso in cui avessimo lasciato il file nominato index 
            return View("HomePage",pizzes);
        }
        //creiamo una nuova pagina, quindi per prima cosa creiamo un metodo nuovo
        [HttpGet]
        //il metodo servirà per vedere i dettagli di un determinato post quindi inseriamo l'id, quindi il parametro 
        public IActionResult Dettagli(int id)
        {
            //dichiariamo un oggeto temporaneo che sarà null per ora 
            Pizze TrovataDescrzionePizza = null;
            //Per trovare la pizza scansiona la lista Pizze, lo facciamo con richiamando il metodo getposts che scansiona tutta la lista delle nostre pizze
            //Ovviamente creo questa vista nel controller pizze(cartella)
            foreach(Pizze pizze in PostData.GetPosts())
            {
                //Se trovo una pizza con lo stesso id, dico che TDP è uguale a pizze e poi eseguo un break per uscire.
                if(pizze.Id == id)
                {
                    TrovataDescrzionePizza = pizze;
                    break;
                }
            }
            //Se la pizza è stata trovata e quindi è diverso da null, faccio un return vista "dettagli" con il modello agganciato che sarebbe la pizza trovata
            if(TrovataDescrzionePizza != null)
            {
                return View("Dettagli",TrovataDescrzionePizza);
            }//altrimenti se non è stato trovato invio un messaggio di errrore che segna anche l'id, è simile al concetto di CW e Console.error
            else
            {
                return NotFound("La pizza con id " + id + "non è stato trovato");
                //Dopo aver fatto tutto questo devo creare in pizze una vista 
            }
        }
    }
}
 