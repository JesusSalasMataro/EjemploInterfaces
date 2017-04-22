using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public class GestorHeroesNulo : IGestorHeroes
    {
        public List<Heroe> LeerHeroes()
        {
            return new List<Heroe>();
        }

        public void EscribirHeroes(List<Heroe> Heroes)
        {
            
        }
    }
}
