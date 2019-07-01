namespace abstract_factory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new CDPlayer();
        }
    }
}