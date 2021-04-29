using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Delantero : Jugador
    {
        public int PenalesConvertidos { get; set; }
        public Delantero()
        {

        }
        public Delantero(int id, string nombre, string apellido, bool expulsado, int penalesConvertidos) : base(id, nombre, apellido, expulsado)
        {
            PenalesConvertidos = penalesConvertidos;
        }

        public override int CalcularPuntos()
        {
            return (PenalesConvertidos * Constantes.PUNTAJE_PENALES_CONVERTIROS) - AjusteExpulsado();
            //if (Expulsado)
            //    return (PenalesConvertidos * Constantes.PUNTAJE_PENALES_CONVERTIROS) - Constantes.PUNTAJE_EXPULSADO;
            //else
            //    return (PenalesConvertidos * Constantes.PUNTAJE_PENALES_CONVERTIROS);
        }
    }
}