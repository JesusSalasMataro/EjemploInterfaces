using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public interface IGestorHeroes
    {
        List<Heroe> LeerHeroes();

        void EscribirHeroes(List<Heroe> Heroes);
    }
}
