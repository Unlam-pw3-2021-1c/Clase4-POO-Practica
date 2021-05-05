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

        /// <summary>
        /// Retorna aquellos jugadores con el mayor puntaje
        /// </summary>
        /// <param name="delanteros"></param>
        /// <param name="arqueros"></param>
        /// <returns></returns>
        public static List<Jugador> ObtenerJugadoresMasValiosos(List<Arquero> arqueros, List<Delantero> delanteros)
        {
            List<Jugador> jugadoresMasValiosos = new List<Jugador>();

            int maxPuntosDel = delanteros.Max(o => o.CalcularPuntos());
            List<Delantero> delanterosMasValiosos = delanteros.Where(o => o.CalcularPuntos() == maxPuntosDel).ToList();

            int maxPuntosArq = arqueros.Max(o => o.CalcularPuntos());
            List<Arquero> arquerosMasValiosos = arqueros.Where(o => o.CalcularPuntos() == maxPuntosDel).ToList();

            if (maxPuntosArq > maxPuntosDel)
            {
                //return arquerosMasValiosos.Cast<Jugador>().ToList()
                foreach (var arq in arquerosMasValiosos)
                {
                    jugadoresMasValiosos.Add(arq);
                }
            }
            else if(maxPuntosArq < maxPuntosDel)
            {
                foreach (var del in delanterosMasValiosos)
                {
                    jugadoresMasValiosos.Add(del);
                }
            }
            else //delanteros y arqueros comparten el max puntos
            {
                foreach (var arq in arquerosMasValiosos)
                {
                    jugadoresMasValiosos.Add(arq);
                }

                foreach (var del in delanterosMasValiosos)
                {
                    jugadoresMasValiosos.Add(del);
                }
            }

            return jugadoresMasValiosos;
        }

        public static List<Jugador> ObtenerJugadoresMasValiosos(List<Jugador> jugadores)
        {
            List<Jugador> jugadoresMasValiosos = new List<Jugador>();

            int maxPuntos = jugadores.Max(o => o.CalcularPuntos());

            //List<Jugador> res = new List<Jugador>();
            //foreach (var o in jugadores)
            //{
            //    if (o.CalcularPuntos() == maxPuntos)
            //    {
            //        res.Add(o);
            //    }
            //}


            return jugadores.Where(o => o.CalcularPuntos() == maxPuntos).ToList();
        }

    }
}
