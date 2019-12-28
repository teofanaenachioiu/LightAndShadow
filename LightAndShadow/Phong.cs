using System;

namespace LightAndShadow
{
    public class Phong : Material
    {
        public double f;

        public override Colour Light(Vector n, Vector l, Vector v, Colour Ia, Colour Id, Colour Is)
        {
            Colour e = pe * emissive;
            Colour a = pa * Ia;

            n = (Vector)n.Clone();
            l = (Vector)l.Clone();
            v = (Vector)v.Clone();

            Vector r = Vector.reflect(l, n);

            n.normalize();
            l.normalize();
            v.normalize();
            r.normalize();

            double ln = l * n;
            if (ln < 0.0)
            {
                Id = new Colour(0.0, 0.0, 0.0);
                Is = new Colour(0.0, 0.0, 0.0);
            }

            double rv = r * v;
            if (rv < 0.0)
            {
                Is = new Colour(0.0, 0.0, 0.0);
            }

            Colour d = pd * Id * ln;
            Colour s = ps * Is * rv;
            return  e + a + d + s;
        }

        public Phong()
        {
            pd = 0.4;
            ps = 0.3;
            pa = 0.3;
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
