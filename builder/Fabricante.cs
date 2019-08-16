namespace builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celular)
        {
            celular.BuildBateria();
            celular.BuildCamera();
            celular.BuildSistema();
            celular.BuildTela();
        }
    }
}