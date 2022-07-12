using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termometroPOOparcial.Entidades
{
    public  class Kelvin
    {
        public float Magnitud { get; set; }
        public static float CeroAbsoluto { get; set; }

        //Deberán tener un constructor estático que inicialice
        //el atributo Cero Absoluto en -273.15 en Celsius, 0 en Kelvin y -459.67 en Fahrenheit .

        static Kelvin()
        {
            CeroAbsoluto = 0f;
        }
        //Deberán tener un constructor con la magnitud de cada temperatura.
        public Kelvin(float magnitud)
        {
            this.Magnitud = magnitud;
        }
        //Hacer la sobrecarga implícita entre float y las temperaturas.

        public static implicit operator Kelvin(float f)
        {
            return new Kelvin(f);
        }
        //Sobrecargas explicitas entre tempreaturas
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Magnitud + 273.15f);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.Magnitud + 459.67f) * (5 / 9f));
        }
        //Operadores de igualdad
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Kelvin))
            {
                return false;
            }
            return this.Magnitud == ((Kelvin)obj).Magnitud;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.Equals(k2);
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.Equals((Kelvin)c);
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == (Kelvin)c);
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.Equals((Kelvin)f);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == (Kelvin)f);
        }
        //operaciones misma temp
        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.Magnitud + k2.Magnitud);
        }

        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.Magnitud - k2.Magnitud);
        }
        //sobrecarga de operaciones
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.Magnitud + ((Kelvin)f).Magnitud);
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.Magnitud - ((Kelvin)f).Magnitud);
        }
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.Magnitud + ((Kelvin)c).Magnitud);
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.Magnitud - ((Kelvin)c).Magnitud);
        }

        //to string

        public override string ToString()
        {
            return $"{this.Magnitud} K°";
        }
    }
}
