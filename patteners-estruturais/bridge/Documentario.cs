namespace bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no canal de documentários");
        }

        public string Status()
        {
            return ("Você está assistindo a origem de tudo");
        }
    }
}