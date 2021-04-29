using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arquero : Jugador
    {
        public int PenalesAtajados { get; set; }

        public Arquero()
        {

        }
        public Arquero(int id, string nombre, string apellido, bool expulsado, int penalesAtajados) : base(id, nombre, apellido, expulsado)
        {
            PenalesAtajados = penalesAtajados;
        }

        public override int CalcularPuntos()
        {
            //return (PenalesAtajados * 100) - (Expulsado ? 50 : 0);
            return (PenalesAtajados * Constantes.PUNTAJE_PENALES_ATAJADOS) - AjusteExpulsado();
        }
    }

}
