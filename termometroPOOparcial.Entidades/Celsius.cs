using System;

namespace termometroPOOparcial.Entidades
{
    public class Celsius
    {
       public float Magnitud { get; set; }
       public static float CeroAbsoluto { get; set; }

        //Deberán tener un constructor estático que inicialice
        //el atributo Cero Absoluto en -273.15 en Celsius, 0 en Kelvin y -459.67 en Fahrenheit .

        static Celsius()
        {
            CeroAbsoluto = -273.15f;
        }
        //Deberán tener un constructor con la magnitud de cada temperatura.
        public Celsius(float magnitud)
        {
            this.Magnitud = magnitud;
        }
        //Hacer la sobrecarga implícita entre float y las temperaturas.

        public static implicit operator Celsius(float f)
        {
            return new Celsius(f);
        }
        //Hacer la sobrecarga explícita entre las temperaturas.
        public static explicit operator Celsius(Kelvin k)
        {
            //ºC = K – 273.15
            return new Celsius(k.Magnitud - 273.15f);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            //C = (F-32) * 5/9
            return new Celsius((f.Magnitud - 32) * (5 / 9f));
        }

        //Operadores de igualdad
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Celsius))
            {
                return false;
            }
            return this.Magnitud == ((Celsius)obj).Magnitud;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.Equals((Celsius)k);
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == (Celsius)k);
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.Equals((Celsius)f);
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == (Celsius)f);
        }

        //operaciones misma temp
        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.Magnitud + c2.Magnitud);
        }

        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.Magnitud - c2.Magnitud);
        }
        //sobrecarga de operaciones
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.Magnitud + ((Celsius)f).Magnitud);
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.Magnitud - ((Celsius)f).Magnitud);
        }
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.Magnitud + ((Celsius)k).Magnitud);
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.Magnitud - ((Celsius)k).Magnitud);
        }
        //to string

        public override string ToString()
        {
            return $"{this.Magnitud} C°";
        }
    }
}
