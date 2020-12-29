using ExampleDecoratorPattern.Interfaces;
using System;

namespace ExampleDecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IHamburguer hamburguer = new Hamburguer();
            IHamburguer cheddarDecorator = new CheddarDecorator(hamburguer);
            IHamburguer baconDecorator = new BaconDecorator(cheddarDecorator);
            IHamburguer ovosDecorator = new OvosDecorator(baconDecorator);

            Console.WriteLine(ovosDecorator.BuscarTipoHamburguer());
            Console.WriteLine();
        }
    }
}