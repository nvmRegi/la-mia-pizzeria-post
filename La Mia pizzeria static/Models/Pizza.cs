namespace La_Mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Ingrediente { get; set; }
        public string Image { get; set; }
        public double Prezzo { get; set; }

        public Pizza()
        {

        }

        public Pizza(string nome, string ingrediente, string image, double prezzo)
        {
            Nome = nome;
            Ingrediente = ingrediente;
            Image = image;
            Prezzo = prezzo;
        }
    }
}
