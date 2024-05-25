using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
            Pen pen = new Pen(Color.Black, 2);
            Point[] points = new Point[50];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLines(pen, points);

            Point[] trianglePoints = { new Point(100, 250), new Point(50, 350), new Point(150, 350) };
            g.DrawPolygon(Pens.Black, trianglePoints);

            g.DrawEllipse(Pens.Black, 200, 250, 150, 100);

            g.FillEllipse(Brushes.Black, 400, 250, 100, 100);

            g.FillRectangle(Brushes.Black, 550, 250, 150, 100);

            g.FillPie(Brushes.Black, 700, 250, 100, 100, 0, 45);

            int[] radii = { 40, 30, 20, 10 };
            foreach (int radius in radii)
            {
                g.DrawEllipse(Pens.Black, 100 - radius, 420 - radius, 2 * radius, 2 * radius);
            }

            int size = 30;
            int offset = 20;
            for (int i = 0; i < 5; i++)
            {
                g.DrawRectangle(Pens.Black, 300 + i * offset, 0 + i * offset * 2, size, size * 2);
            }

            int tileSize = 20;
            int rows = 8;
            int cols = 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        g.FillRectangle(Brushes.Black, 0 + col * tileSize, 0 + row * tileSize, tileSize, tileSize);
                    }
                }
            }
        }
    }
}

