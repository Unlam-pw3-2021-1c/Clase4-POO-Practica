using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Datos
    {
        public static List<DirectorTecnico> DirectoresTecnicos = new List<DirectorTecnico>();
        public static List<Arquero> Arqueros = new List<Arquero>();
        public static List<Delantero> Delanteros = new List<Delantero>();

        static Datos()
        {
            Arquero arq1 = new Arquero(1, "Juan", "Carrizo", false, 1);
            Arquero arq2 = new Arquero(2, "Gato", "Sessa", true, 0);
            Arquero arq3 = new Arquero(3, "Jose Luis Felix", "Chilavert", true, 3);
            Arqueros = new List<Arquero>() { arq1, arq2, arq3};

            Delantero del1 = new Delantero(4, "Turu", "Flores", true, 5);
            Delantero del2 = new Delantero(5, "Franco", "Soldano", false, 2);
            Delantero del3 = new Delantero(6, "Gomito", "Gomez", false, 3);
            Delantero del4 = new Delantero(7, "Pulga", "Rodriguez", false, 10);
            Delanteros = new List<Delantero>() { del1, del2, del3, del4 };

            DirectorTecnico dt1 = new DirectorTecnico("Caruso Lombardi", arq1, del1, del2);
            DirectorTecnico dt2 = new DirectorTecnico("D1eg0", arq2, del3, del4);
            DirectorTecnico dt3 = new DirectorTecnico("Bilardista", arq3, del1, del2);
            DirectorTecnico dt4 = new DirectorTecnico("El Muñe", arq1, del4, del2);
            DirectoresTecnicos = new List<DirectorTecnico>() { dt1, dt2, dt3, dt4 };
        }
    }
}
