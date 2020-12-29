using ExampleDecoratorPattern.Interfaces;
//Utilizando o Decorator, esta class acrescenta o elemento "Cheddar" a classe Hamburguer

namespace ExampleDecoratorPattern
{
    //Concrete Decorator
    public class CheddarDecorator : HamburguerDecorator
    {
        public CheddarDecorator(IHamburguer hamburguer)
            : base(hamburguer)
        {

        }

        public override string BuscarTipoHamburguer()
        {
            string hamburguer = base.BuscarTipoHamburguer();
            hamburguer += "\r\n Cheddar Burguer: Acrescentando cheddar ao Hambúrguer Simples";
            return hamburguer;
        }
    }
}
