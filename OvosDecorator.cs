using ExampleDecoratorPattern.Interfaces;
//Utilizando o Decorator, esta class acrescenta o elemento "Ovos" a classe Hamburguer

namespace ExampleDecoratorPattern
{
    //Concrete Decorator
    public class OvosDecorator : HamburguerDecorator
    {
        public OvosDecorator(IHamburguer hamburguer)
            : base(hamburguer)
        {
        }

        public override string BuscarTipoHamburguer()
        {
            string hamburguer = base.BuscarTipoHamburguer();
            hamburguer += "\r\n X-Egg: Acrescentando ovos ao Hambúrguer Simples";
            return hamburguer;
        }
    }
}