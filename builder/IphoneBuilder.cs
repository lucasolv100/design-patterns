namespace builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;
        public IphoneBuilder()
        {
            this.celular = new Celular("Iphone");
        }
        public void BuildBateria()
        {
            this.celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.Camera = "20 MP";
        }

        public void BuildSistema()
        {
            this.celular.SO = "IOS 3";
        }

        public void BuildTela()
        {
            this.celular.Tela = "Gorila Glass";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }
}