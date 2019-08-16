namespace bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no canal de culinaria");
        }

        public string Status()
        {
            return ("Você está assistindo receita de bolo de laranja");
        }
    }
}