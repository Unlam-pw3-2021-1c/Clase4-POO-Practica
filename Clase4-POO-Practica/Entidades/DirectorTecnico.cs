using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : ICalculaPuntos
    {
        public string NombreUsuario { get; set; }
        public Arquero Arquero { get; set; }
        public Delantero Delantero1 { get; set; }
        public Delantero Delantero2 { get; set; }
        public DirectorTecnico()
        {

        }

        public DirectorTecnico(string nombreUsuario, Arquero arq, Delantero del1, Delantero del2)
        {
            NombreUsuario = nombreUsuario;
            Arquero = arq;
            Delantero1 = del1;
            Delantero2 = del2;
        }

        public override string ToString()
        {
            return $"{NombreUsuario} Puntos Totales: {CalcularPuntos()} Arq: {Arquero} Del1: {Delantero1} Del2: {Delantero2}"; 
        }

        public int CalcularPuntos()
        {
            return Arquero.CalcularPuntos() + Delantero1.CalcularPuntos() + Delantero2.CalcularPuntos();
        }
    }
}
