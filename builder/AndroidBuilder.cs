namespace builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }
        public void BuildBateria()
        {
            this.celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.SO = "Android 4.6";
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