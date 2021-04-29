using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PremioBatallaPenales
    {
        public static List<DirectorTecnico> ObtenerGanadores(List<DirectorTecnico> lista)
        {
            int maxPuntos = lista.Max(o => o.CalcularPuntos());
            return lista.Where(o => o.CalcularPuntos() == maxPuntos).ToList();
        }
    }
}
