using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                if (this == (Perro)obj)
                { return true; }
            }
            return retorno;

        }

        public static explicit operator int(Perro p)//conversion exxplicita de perro a int  y retorna edad
        {
            int retorno;
            retorno = p.edad;
            return retorno;
        }

        protected override string Ficha()
        {
            if (this.esAlfa == true)
            {
                return base.DatosCompletos() + this.esAlfa.ToString() + this.edad.ToString();
            }

            else
                return base.DatosCompletos() + this.edad.ToString();
        }


        public Perro(string nombre, string raza):base(nombre,raza)
        {

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa):this(nombre,raza)
        {
            this.edad = 0;
            this.esAlfa = false;

        }

        public string ToString()
        {
            return Ficha();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad==p2.edad)
            {
                return true;
            }
            else
               return false;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad==p2.edad);
        }





    }
}
