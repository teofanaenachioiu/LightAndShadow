namespace LightAndShadow
{
    abstract public class Material
    {
        abstract public Colour Light(Vector n, Vector l, Vector v, Colour Ia, Colour Id, Colour Is);

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

            pt = 0.0;
            pr = 0.0;
            ir = 1.0;
        }
    }
}
