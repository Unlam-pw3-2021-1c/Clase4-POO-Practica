using System;

namespace Entidades
{
    public abstract class Jugador : ICalculaPuntos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Expulsado { get; set; }

        public Jugador()
        {

        }
        public Jugador(int id, string nombre, string apellido, bool expulsado)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Expulsado = expulsado;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} ({CalcularPuntos()})";
        }
        protected int AjusteExpulsado()
        {
            if (Expulsado)
            {
                return Constantes.PUNTAJE_EXPULSADO;
            }
            else
            {
                return 0;
            }
        }

        public abstract int CalcularPuntos();
    }
}
