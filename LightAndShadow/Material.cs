using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightAndShadow
{
    abstract public class Material
    {
        abstract public Colour Light(Vector3 n, Vector3 l, Vector3 v, Colour Ia, Colour Id, Colour Is);

        public Colour diffuse, specular, emissive, ambient;
        public double pd, ps, pa, pe;

        // transimssion
        public double pt;
        // index of reflection
        public double ir;
        //reflection
        public double pr;

        public Material()
        {
            pd = 0.5;
            ps = 0.4;
            pa = 0.1;
            pe = 0.0;

            diffuse = new Colour(1.0, 0.0, 0.0);
            specular = new Colour(1.0, 1.0, 1.0);
            emissive = new Colour(1.0, 0.0, 0.0);
            ambient = new Colour(1.0, 0.0, 0.0);
        }
    }
}
