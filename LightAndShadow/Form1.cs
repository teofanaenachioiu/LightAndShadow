using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightAndShadow
{
    public partial class Form1 : Form
    {
        private bool mustpaint = false;
        private Colour matt = new Colour(1.0, 0.0, 0.0);
        private Colour spec = new Colour(1.0, 1.0, 1.0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mustpaint = true;
            pictureBox1.Invalidate();
        }

        void Plot(Graphics gfx, double x, double y, double r, double g, double b)
        {
            Pen pen = new Pen(Brushes.White);
            pen.Color = Color.FromArgb(255, (int)(r * 255), (int)(g * 255), (int)(b * 255));
            gfx.DrawLine(pen, (int)x, (int)y, (int)x + 1, (int)y);
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x, y;
            double rx, ry, rz;
            Material mat = new Phong();
            Vector3 n;
            Vector3 l = new Vector3(-100, 100, 100);
            Vector3 v = new Vector3(0, 0, 100);
            if (mustpaint)
            {
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

                        n = new Vector3((float)rx, (float)ry, (float)rz);

                        if (rx * rx + ry * ry < 1.0)
                        {
                            //inside the sphere
                            Colour c = mat.Light(n, l - n, v - n,
                                new Colour(1.0, 1.0, 1.0),
                                matt,
                                spec
                                );
                            Plot(e.Graphics, x, y, c.R, c.G, c.B);
                        }
                    }
                }
                mustpaint = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            matt = new Colour(c.R / 255.0, c.G / 255.0, c.B / 255.0);
            button1.BackColor = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            spec = new Colour(c.R / 255.0, c.G / 255.0, c.B / 255.0);
            button2.BackColor = c;
        }
    }
}
