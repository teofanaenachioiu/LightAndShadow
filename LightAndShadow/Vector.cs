using System;

namespace LightAndShadow
{
    public class Vector
    {
        public double x, y, z;

        public Vector()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        public Vector(Vector v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public object Clone()
        {
            object o = new Vector(x, y, z);
            return o;
        }

        public override bool Equals(object obj)
        {
            if ((((Vector)obj).x == x) && (((Vector)obj).y == y) && (((Vector)obj).z == z)) return true;
            return false;
        }

        public static Vector operator +(Vector a, Vector v)
        {
            return new Vector(a.x + v.x, a.y + v.y, a.z + v.z);
        }

        public static Vector operator -(Vector a, Vector v)
        {
            return new Vector(a.x - v.x, a.y - v.y, a.z - v.z);
        }

        // dot product
        public static double operator *(Vector a, Vector v)
        {
            return a.x * v.x + a.y * v.y + a.z* v.z;
        }

        public static Vector operator *(double c, Vector v)
        {
            return new Vector(c * v.x, c * v.y, c * v.z);
        }

        // cross product
        public static Vector operator ^(Vector a, Vector v)
        {
            return new Vector
            {
                x = a.x * v.x,
                y = a.y * v.y,
                z = a.z * v.z
            };
        }

        public double norm()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public void normalize()
        {
            double s = norm();
            if (s != 0.0)
            {
                x = x / s;
                y = y / s;
                z = z / s;
            }
        }

        public static Vector reflect(Vector l, Vector n)
        {
            return 2.0 * (l * n) * n - l;
        }

        public static double cos(Vector a, Vector b)
        {
            double produs = a * b;
            produs = produs / modul(a);
            produs = produs / modul(b);
            return produs;
        }

        public static double modul(Vector a)
        {
            return Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
        }
    }
}
