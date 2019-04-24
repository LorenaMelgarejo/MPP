using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string nombre;
        private static EtipoManada _tipo;

        public EtipoManada Tipo
        {
            set { _tipo = value; }  //this.Tipo = value; }
        }

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

         static Grupo()
        {
            _tipo = EtipoManada.Unica;
        }

        public Grupo(string nombre)
        { this.nombre = nombre; }

        public Grupo(string nombre, EtipoManada tipo):this()
        {

            _tipo = tipo;  
        }

        public implicit operator string(Grupo g)
        {
            string dato = "";
            foreach (Mascota item in g._manada)
            {
                dato += item.ToString();
            }

            return dato;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {

            for (int i= 0; i<g._manada.Count; i++)
            {
                if (g._manada[i] == m)
                {
                    return true;
                }
                
                 
            }
            return false;
            
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return (!(g == m));
        }

        public static Grupo operator -(Grupo g, Mascota m)
        { }

        public static Grupo operator +(Grupo g, Mascota m)
        { }

    }
}
