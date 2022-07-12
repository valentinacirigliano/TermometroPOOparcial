using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termometroPOOparcial.Entidades
{
    public  class Fahrenheit
    {
        public float Magnitud { get; set; }
        public static float CeroAbsoluto { get; set; }

        //Deberán tener un constructor estático que inicialice
        //el atributo Cero Absoluto en -273.15 en Celsius, 0 en Kelvin y -459.67 en Fahrenheit .

        static Fahrenheit()
        {
            CeroAbsoluto = -459.67f;
        }
        //Deberán tener un constructor con la magnitud de cada temperatura.
        public Fahrenheit(float magnitud)
        {
                this.Magnitud = magnitud;
        }
        //Hacer la sobrecarga implícita entre float y las temperaturas.

        public static implicit operator Fahrenheit(float f)
        {
            return new Fahrenheit(f);
        }

        //Sobrecargas explciitas entre temperaturas

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.Magnitud * (9 / 5f) + 32);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit( (k.Magnitud * (9 / 5f)) - 459.67f );
        }

        //Operadores de igualdad
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fahrenheit))
            {
                return false;
            }
            return this.Magnitud == ((Fahrenheit)obj).Magnitud;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.Equals((Fahrenheit)k);
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == (Fahrenheit)k);
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.Equals((Fahrenheit)c);
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == (Fahrenheit)c);
        }

        //operaciones misma temp
        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.Magnitud + f2.Magnitud);
        }

        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.Magnitud - f2.Magnitud);
        }
        //sobrecarga de operaciones
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.Magnitud + ((Fahrenheit)c).Magnitud);
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.Magnitud - ((Fahrenheit)c).Magnitud);
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.Magnitud + ((Fahrenheit)k).Magnitud);
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.Magnitud - ((Fahrenheit)k).Magnitud);
        }
        //to string

        public override string ToString()
        {
            return $"{this.Magnitud} F°";
        }

    }
}
