using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("¿Qué tipo de persistencia quieres? bd o fichero");
            string tipoPersistencia = Console.ReadLine();

            IGestorHeroes gestorHeroes = GestorHeroesFactory.GetGestorHeroes(tipoPersistencia);
            List<Heroe> heroes = gestorHeroes.LeerHeroes();
        }
    }
}
