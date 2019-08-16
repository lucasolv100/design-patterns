namespace decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;
        public Decorator(ItemBiblioteca item_biblioteca)
        {
            itemBiblioteca = item_biblioteca;
        }
        public override void Exibe()
        {
            itemBiblioteca.Exibe();
        }
    }
}