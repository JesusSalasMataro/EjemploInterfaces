using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public class GestorHeroesFactory
    {
        public static IGestorHeroes GetGestorHeroes(string tipoGestor)
        {
            IGestorHeroes gestorHeroes;

            if (tipoGestor.Equals("bd"))
            {
                gestorHeroes = new GestorHeroesBD();
            }
            else if (tipoGestor.Equals("fichero"))
            {
                gestorHeroes = new GestorHeroesFichero();
            }
            else
            {
                gestorHeroes = new GestorHeroesNulo();
            }

            return gestorHeroes;
        }
    }
}
