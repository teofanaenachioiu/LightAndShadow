using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LightAndShadow
{
    public class Phong: Material
    {
        public double f;

        public override Colour Light(Vector3 n, Vector3 l, Vector3 v, Colour Ia, Colour Id, Colour Is)
        {
            Vector3 r;
            Colour c, e, a;
            e = pe * emissive;
            a = pa * Ia * ambient;

            //n = (Vector2)n.Clone(n);
            n = Vector3.Normalize(n);
            l = Vector3.Normalize(l);
            v = Vector3.Normalize(v);

            r = Vector3.Reflect(l, n);

            // !!!!!!!!!!!!!!!!!!!!!!
            Vector3 vector3 = n * l;
            if (vector3.Z < 0.0)
            {
                Id = new Colour(0.0, 0.0, 0.0);
                Is = new Colour(0.0, 0.0, 0.0);
            }
            // !!!!
            if((r*v).Z < 0.0)
            {
                Is = new Colour(0.0, 0.0, 0.0);
            }
            //!!!!!!!!!!!!
            c = e + a + pd * diffuse * Id * (n * l).X + ps * specular * Is * Math.Pow((r * v).X, f);
            return c;
        }

        public Phong()
        {
            pd = 0.5;
            ps = 0.4;
            pa = 0.1;
            pe = 0.0;
            f = 20.0;

            diffuse = new Colour(1.0, 1.0, 1.0);
            specular = new Colour(1.0, 1.0, 1.0);
            emissive = new Colour(1.0, 1.0, 1.0);
            ambient = new Colour(1.0, 1.0, 1.0);
        }

        public object Clone()
        {
            Phong ph = new Phong();
            ph.pd = pd;
            ph.ps = ps;
            ph.pa = pa;
            ph.pe = pe;
            ph.f = f;

            ph.diffuse = (Colour)diffuse.Clone();
            ph.specular = (Colour)specular.Clone();
            ph.emissive = (Colour)emissive.Clone();
            ph.ambient = (Colour)ambient.Clone();

            object o = ph;
            return o;
        }

        public override string ToString()
        {
            return "Material::Phong()";
        }
    }
}
