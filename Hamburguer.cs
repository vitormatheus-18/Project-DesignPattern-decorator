using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class Hamburguer : IHamburguer
    {
        public string BuscarTipoHamburguer()
        {
            var hamburguer = "Este é um Hambúrguer Simples";
            return hamburguer;
        }
    }
}
