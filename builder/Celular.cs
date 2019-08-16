namespace builder
{
    public class Celular
    {
        public Celular(string nome)
        {
            Nome = nome;    
        }

        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string SO { get; set; }
        public string Camera { get; set; }
    }
}