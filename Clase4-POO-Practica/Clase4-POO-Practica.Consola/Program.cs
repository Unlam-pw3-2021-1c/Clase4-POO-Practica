using Entidades;
using System;
using System.Collections.Generic;

namespace Clase4_POO_Practica.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquero arq1 = new Arquero(1, "Juan", "Carrizo", false, 1);
            Arquero arq2 = new Arquero(2, "Gato", "Sessa", true, 0);
            Arquero arq3 = new Arquero(3, "Jose Luis Felix", "Chilavert", true, 3);

            Delantero del1 = new Delantero(4, "Turu", "Flores", true, 5);
            Delantero del2 = new Delantero(5, "Franco", "Soldano", false, 2);
            Delantero del3 = new Delantero(6, "Gomito", "Gomez", false, 3);
            Delantero del4 = new Delantero(7, "Pulga", "Rodriguez", false, 10);

            DirectorTecnico dt1 = new DirectorTecnico("Caruso Lombardi", arq1, del1, del2);
            DirectorTecnico dt2 = new DirectorTecnico("D1eg0", arq2, del3, del4);
            DirectorTecnico dt3 = new DirectorTecnico("Bilardista", arq3, del1, del2);
            DirectorTecnico dt4 = new DirectorTecnico("El Muñe", arq1, del4, del2);

            List<DirectorTecnico> participantes = new List<DirectorTecnico>() { dt1, dt2, dt3, dt4 };

            Console.WriteLine("Los/Las Ganadores son:");
            List<DirectorTecnico> ganadores = PremioBatallaPenales.ObtenerGanadores(participantes);
            foreach (var ganador in ganadores)
            {
                Console.WriteLine(ganador);
            }
        }
    }
}
