using System;

namespace CustomizeConvertor
{
    public class Fahreheit
    {
        public double Degrees { get; set; }

        public Fahreheit(double degrees)
        {
            Degrees = degrees;
        }

        public static implicit operator double(Fahreheit f)
        {
            return f.Degrees;
        }

        public static explicit operator Fahreheit(double d)
        {
            return new Fahreheit(d);
        }
    }
}
