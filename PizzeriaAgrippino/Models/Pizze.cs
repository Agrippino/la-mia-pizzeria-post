using System.ComponentModel.DataAnnotations;

namespace PizzeriaAgrippino.Models

{
    public class Pizze
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Il campo immagine è obbligatorio")]
        public string ImagePizza { get; set; }
        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        public string NamePizza { get; set; }
        [Required(ErrorMessage = "Il campo Descrizione è obbligatorio")]
        public string DescriptionPizza { get; set; }
        [Required(ErrorMessage = "Il campo Prezzo è obbligatorio")]
        public double PricePizza { get; set; }
        
        public Pizze()
        {

        }

        public Pizze(int id, string imagePizza, string namePizza, string descriptionPizza, double pricePizza)
        {
            this.Id = id;
            this.ImagePizza = imagePizza;
            this.NamePizza = namePizza;
            this.DescriptionPizza = descriptionPizza;
            this.PricePizza = pricePizza;
            
        }
    }
}
