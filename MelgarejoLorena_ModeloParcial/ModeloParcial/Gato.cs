using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Gato:Mascota
    {

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
            {
                if (this == (Gato)obj)
                { return true; }
            }
            return retorno;
        }

        protected override string Ficha()
        {
            return this.DatosCompletos();

        }

        public Gato(string nombre, string raza):base(nombre,raza)
        { }

        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }
           else
                return false;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1.Nombre == g2.Nombre && g1.Raza == g2.Raza);
        }

        public override string ToString()
        {
            return Ficha();

        }


    }
}
