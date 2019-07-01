namespace abstract_factory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new BluetoothPlayer();
        }
    }
}