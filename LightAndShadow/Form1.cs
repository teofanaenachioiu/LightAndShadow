using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightAndShadow
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Colour ambiant = new Colour(1.0, 0.0, 0.0);
        private Colour diffuse = new Colour(1.0, 1.0, 0.0);
        private Colour specular = new Colour(1.0, 1.0, 1.0);
        private Material mat = new Phong();
        private Vector n;
        private Vector l = new Vector(-100, 100, 100);
        private Vector v = new Vector(0, 100, 0);
        private Bitmap myBmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            myBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            metroTextBoxXL.Text = l.x.ToString();
            metroTextBoxYL.Text = l.y.ToString();
            metroTextBoxZL.Text = l.z.ToString();

            metroTextBoxXV.Text = v.x.ToString();
            metroTextBoxYV.Text = v.y.ToString();
            metroTextBoxZV.Text = v.z.ToString();
            paint();
        }

        private void repaint()
        {
            paint();
            pictureBox1.Update();
        }

        public void paint()
        {
            Graphics g = Graphics.FromImage(myBmp);

            int x, y;
            double rx, ry, rz;

            for (y = 0; y < 256; y++)
            {
                for (x = 0; x < 256; x++)
                {
                    rx = x / 255.0;
                    ry = y / 255.0;
                    rx -= 0.5;
                    ry -= 0.5;
                    rx *= 2.0;
                    ry *= 2.0;
                    rz = Math.Sqrt(1 - (rx * rx) + (ry * ry));

                    n = new Vector(rx, ry, rz);

                    if (rx * rx + ry * ry < 1.0)
                    {
                        //inside the sphere
                        Colour c = mat.Light(n, l - n, v - n, ambiant, diffuse, specular);
                        Plot(g, x, y, c.R, c.G, c.B);
                    }
                }
            }
            pictureBox1.Image = myBmp;
        }

      

        public Form1()
        {
            InitializeComponent();
        }

        void Plot(Graphics gfx, double x, double y, double r, double g, double b)
        {
            Pen pen = new Pen(Brushes.White);
            pen.Color = Color.FromArgb(255, (int)(r * 255), (int)(g * 255), (int)(b * 255));
            gfx.DrawLine(pen, (int)x, (int)y, (int)x + 1, (int)y);
        }

        private void metroTrackBarAmbientRed_Scroll(object sender, ScrollEventArgs e)
        {
            ambiant.r = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarAmbientGreen_Scroll(object sender, ScrollEventArgs e)
        {
            ambiant.g = e.NewValue / 255.0;
            repaint();

        }

        private void metroTrackBarAmbientBlue_Scroll(object sender, ScrollEventArgs e)
        {
            ambiant.b = e.NewValue / 255.0;
            repaint();

        }

        private void metroTrackBarDifusseRed_Scroll(object sender, ScrollEventArgs e)
        {
            diffuse.r = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarDifusseGreen_Scroll(object sender, ScrollEventArgs e)
        {
            diffuse.g = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarDifusseBlue_Scroll(object sender, ScrollEventArgs e)
        {
            diffuse.b = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarSpecularRed_Scroll(object sender, ScrollEventArgs e)
        {
            specular.r = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarSpecularGreen_Scroll(object sender, ScrollEventArgs e)
        {
            specular.g = e.NewValue / 255.0;
            repaint();
        }

        private void metroTrackBarSpecularBlue_Scroll(object sender, ScrollEventArgs e)
        {
            specular.b = e.NewValue / 255.0;
            repaint();
        }

        private void metroButtonLight_Click(object sender, EventArgs e)
        {
            l.x = double.Parse(metroTextBoxXL.Text);
            l.y = double.Parse(metroTextBoxYL.Text);
            l.z = double.Parse(metroTextBoxZL.Text);
            repaint();
        }

        private void metroButtonViewer_Click(object sender, EventArgs e)
        {
            v.x = double.Parse(metroTextBoxXV.Text);
            v.y = double.Parse(metroTextBoxYV.Text);
            v.z = double.Parse(metroTextBoxZV.Text);
            repaint();
        }
    }
}
