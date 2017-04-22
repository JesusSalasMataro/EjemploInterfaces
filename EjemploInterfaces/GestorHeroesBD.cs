using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public class GestorHeroesBD : IGestorHeroes
    {

        public List<Heroe> LeerHeroes()
        {
           // TODO: Conectar con base de datos y hacer query para devolver lista héroes

            return new List<Heroe>();
        }

        public void EscribirHeroes(List<Heroe> Heroes)
        {
            // TODO: Conectar con base de datos y guardar héroes
        }
    }
}
