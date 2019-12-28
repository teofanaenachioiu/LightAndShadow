using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightAndShadow
{
    public class Colour
    {
        public double r, g, b, a;

        public Colour() { r = g = b = a = 0.0; }

        public Colour(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = 1.0;
        }

        public Colour(double r, double g, double b, double a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public object Clone()
        {
            object o = new Colour(r, g, b, a);
            return o;
        }

        public override bool Equals(object x)
        {
            if ((((Colour)x).r == r) && (((Colour)x).g == g) && (((Colour)x).b == b) && (((Colour)x).a == a))
                return true;
            else return false;
        }

        public static Colour operator +(Colour c1, Colour c2)
        {
            return new Colour(c1.r + c2.r, c1.g + c2.g, c1.b + c2.b);
        }

        public static Colour operator -(Colour c1, Colour c2)
        {
            return new Colour(c1.r - c2.r, c1.g - c2.g, c1.b - c2.b);
        }

        public static Colour operator *(Colour c1, Colour c2)
        {
            return new Colour(c1.r * c2.r, c1.g * c2.g, c1.b * c2.b);
        }

        public static Colour operator *(double c, Colour c2)
        {
            return new Colour(c * c2.r, c * c2.g, c * c2.b);
        }

        public static Colour operator *(Colour c1, double c)
        {
            return new Colour(c1.r * c, c1.g * c, c1.b * c);
        }

        public static Colour operator /(Colour c1, double c)
        {
            return new Colour(c1.r / c, c1.g / c, c1.b / c);
        }

        public static Colour operator +(Colour c)
        {
            return new Colour(c.r, c.g, c.b);
        }

        public static Colour operator -(Colour c)
        {
            return new Colour(-c.r, -c.g, -c.b);
        }

        public Colour clamp()
        {
            Colour ret = new Colour
            {
                r = (r > 1.0) ? 1.0 : r,
                g = (g > 1.0) ? 1.0 : g,
                b = (b > 1.0) ? 1.0 : b
            };

            ret.r = (ret.r < 0.0) ? 0.0 : ret.r;
            ret.g = (ret.g < 0.0) ? 0.0 : ret.g;
            ret.b = (ret.b < 0.0) ? 0.0 : ret.b;

            return ret;
        }

        public double norm()
        {
            return Math.Sqrt(r * r + g * g + b * b);
        }

        public Colour normalize()
        {
            Colour ret = new Colour();
            if ((r > 1.0) || (g > 1.0) || (b > 1.0))
            {
                if ((r >= g) && (r >= b))
                {
                    ret.r = 1.0; ret.g = g / r; ret.b = b / r;
                }
                else if ((g >= r) && (g >= b))
                {
                    ret.r = r / g; ret.g = 1.0; ret.b = b / g;
                }
                else
                {
                    ret.r = r; ret.g = g / b; ret.b = 1.0;
                }
            }
            else
            {
                ret.r = r; ret.g = g; ret.b = b;
            }
            return ret;
        }

        private static double max3(double a, double b, double c)
        {
            if ((a >= b) && (a >= c)) return a;
            if ((b >= a) && (b >= c)) return b;
            return c;
        }

        private static double min3(double a, double b, double c)
        {
            if ((a <= b) && (a <= c)) return a;
            if ((b <= a) && (b <= c)) return b;
            return c;
        }

        private Colour RGBtoHSV()
        {
            double max, min;
            double h = 0.0, s, v;
            max = max3(r, g, b);
            min = min3(r, g, b);
            v = max;

            s = (max != 0.0) ? ((max - min) / max) : 0.0;

            if (s == 0.0) h = 360.0;
            else
            {
                double delta = min - max;
                if (r == max) h = (g - b) / delta;
                else if (g == max) h = 2.0 + (b - r) / delta;
                else if (b == max) h = 4.0 + (r - g) / delta;

                h *= 60.0;
                if (h < 0.0) h += 360.0;
            }
            h /= 360.0;
            return new Colour(h, s, v, s);
        }

        private Colour HSVtoRGB()
        {
            double h = r, s = g, v = b;
            double rt = 0.0, gt = 0.0, bt = 0.0;
            b *= 360.0;

            if (s == 0.0)
            {
                if (h < 0.0) rt = gt = bt = v;
                else
                {
                    //Error!! This should never happen!
                    rt = gt = bt = 0.0;
                }
            }
            else
            {
                double f, p, q, t;
                int i;
                if (h >= 360.0) h = 360.0;
                h /= 60.0;
                i = (int)Math.Floor(h);
                f = h - i;
                p = v * (1.0 - s);
                q = v * (1.0 - (s * f));
                t = v * (1.0 - (s * (1.0 - f)));
                switch (i)
                {
                    case 0: rt = v; gt = t; bt = p; break;
                    case 1: rt = q; gt = v; bt = p; break;
                    case 2: rt = p; gt = v; bt = t; break;
                    case 3: rt = p; gt = q; bt = v; break;
                    case 4: rt = t; gt = p; bt = v; break;
                    case 5: rt = v; gt = p; bt = q; break;
                }
            }
            return new Colour(rt, gt, bt, a);
        }

        public double R { get { return r; } set { r = value; } }
        public double G { get { return g; } set { g = value; } }
        public double B { get { return b; } set { b = value; } }
        public double A { get { return a; } set { a = value; } }

        public double Cyan { get { return 1.0 - r; } set { r = 1.0 - value; } }
        public double Magenta { get { return 1.0 - g; } set { g = 1.0 - value; } }
        public double Yallow { get { return 1.0 - b; } set { a = 1.0 - value; } }

        public double Hue
        {
            get
            {
                Colour hsv = RGBtoHSV();
                return hsv.r;
            }
            set
            {
                Colour hsv = RGBtoHSV();
                hsv.r = value;
                Colour rgb = hsv.HSVtoRGB();
                r = rgb.r;
                g = rgb.g;
                b = rgb.b;
            }
        }

        public double Saturation
        {
            get
            {
                Colour hsv = RGBtoHSV();
                return hsv.g;
            }
            set
            {
                Colour hsv = RGBtoHSV();
                hsv.g = value;
                Colour rgb = hsv.HSVtoRGB();
                r = rgb.r;
                g = rgb.g;
                b = rgb.b;
            }
        }

        public double Value
        {
            get
            {
                Colour hsv = RGBtoHSV();
                return hsv.b;
            }
            set
            {
                Colour hsv = RGBtoHSV();
                hsv.b = value;
                Colour rgb = hsv.HSVtoRGB();
                r = rgb.r;
                g = rgb.g;
                b = rgb.b;
            }
        }

        public override string ToString()
        {
            return string.Format("Color({0},{1},{2})", r, g, b);
        }
    }
}
