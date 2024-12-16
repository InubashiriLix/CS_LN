using System;

namespace calculate_override_namespace
{
    // public interface IBoxLen {
    // double
    // }
    public class Box
    {
        private double height = 10;
        private double width = 10;
        private double length = 10;

        public double Height
        {
            get { return height; }
            set { height = Math.Max(0, value); }
        }

        public double Width
        {
            get { return width; }
            set { width = Math.Max(0, value); }
        }

        public double Length
        {
            get { return length; }
            set { length = Math.Max(0, value); }
        }

        public double Volume
        {
            get { return height * width * length; }
        }

        public Box(double height, double width, double len)
        {
            Console.WriteLine("Box constructor called");
            Console.WriteLine("Volume is " + Volume);
        }

        public static Box operator +(Box b, Box c)
        {
            return new Box(c.height + b.height, c.width + b.width, c.length + b.length);
        }

        public static Box operator -(Box b, Box c)
        {
            return new Box(c.height - b.height, c.width - b.width, c.length - b.length);
        }

        public static Box operator *(Box b, Box c)
        {
            return new Box(c.height * b.height, c.width * b.width, c.length * b.length);
        }

        public static Box operator /(Box b, Box c)
        {
            return new Box(c.height / b.height, c.width / b.width, c.length / b.length);
        }

        public static bool operator ==(Box b, Box c)
        {
            return b.height == c.height && b.width == c.width && b.length == c.length;
        }

        public static bool operator !=(Box b, Box c)
        {
            return b.height != c.height || b.width != c.width || b.length != c.length;
        }

        public static bool operator <(Box b, Box c)
        {
            return b.height < c.height && b.width < c.width && b.length < c.length;
        }

        public static bool operator >(Box b, Box c)
        {
            return b.height > c.height && b.width > c.width && b.length > c.length;
        }

        public static bool operator <=(Box b, Box c)
        {
            return b.height <= c.height && b.width <= c.width && b.length <= c.length;
        }

        public static bool operator >=(Box b, Box c)
        {
            return b.height >= c.height && b.width >= c.width && b.length >= c.length;
        }

        public static Box operator ++(Box b)
        {
            return new Box(b.height + 1, b.width + 1, b.length + 1);
        }

        public static Box operator --(Box b)
        {
            return new Box(b.height - 1, b.width - 1, b.length - 1);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Box)obj;
            return height == other.height && width == other.width && length == other.length;
        }
    }
}
