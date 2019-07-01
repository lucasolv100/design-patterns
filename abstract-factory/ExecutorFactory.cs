namespace abstract_factory
{
    public class ExecutorFactory
    {
        public static Carro MontarCarro(string tipo){
            
            CarroFactory cf = null;
            
            switch (tipo)
            {
                case "Luxo":
                    cf = new CarroLuxoFactory();
                    break;
                
                case "Popular":
                    cf = new CarroPopularFactory();
                    break;
                
                default: 
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            
            carro.Roda = cf.MontarRoda();
            carro.Som = cf.MontarSom();

            return carro;

        }
    }
}