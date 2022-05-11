namespace PizzeriaAgrippino.Models
{
    public class Pizze
    {
        public int Id { get; set; }
        public string ImagePizza { get; set; }
        public string NamePizza { get; set; }
        public string DescriptionPizza { get; set; }
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
