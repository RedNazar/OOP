using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR9
{
    public partial class Katok : UserControl
    {
        public Point[] P;
        int[] dx;
        int[] dy;
        Random R = new Random();
        int n;

        Color bgColor;
        Color lineColor;

        List<Point[]> frames = new List<Point[]>();

        public Katok(int N)
        {
            InitializeComponent();

            n = N;
            P = new Point[N];
            dx = new int[N];
            dy = new int[N];

            bgColor = Color.FromArgb(255,
                R.Next(150, 256),
                R.Next(150, 256),
                R.Next(150, 256));

            lineColor = Color.FromArgb(255,
                R.Next(0, 120),
                R.Next(0, 120),
                R.Next(0, 120));

            // Генеруємо ламану
            for (int i = 0; i < N; i++)
            {
                P[i].X = R.Next(Width);
                P[i].Y = R.Next(Height);
                do { dx[i] = R.Next(6) - 3; } while (dx[i] == 0);
                do { dy[i] = R.Next(6) - 3; } while (dy[i] == 0);
            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                P[i].X += dx[i];
                P[i].Y += dy[i];

                if (P[i].X < 3 || P[i].X > Width - 3)
                    dx[i] = -dx[i];
                if (P[i].Y < 3 || P[i].Y > Height - 3)
                    dy[i] = -dy[i];

                if (P[i].X > Width - 3) P[i].X = Width - 3;
                if (P[i].Y > Height - 3) P[i].Y = Height - 3;
            }

            Point[] copy = new Point[n];
            for (int i = 0; i < n; i++)
                copy[i] = P[i];

            frames.Add(copy);

            if (frames.Count > 5)
                frames.RemoveAt(0);

            Invalidate();

        }

        private void Katok_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(bgColor);

            using (Pen p = new Pen(lineColor, 2))
            {
                foreach (var fig in frames)
                    e.Graphics.DrawPolygon(p, fig);
            }
        }

        private void Katok_Load(object sender, EventArgs e)
        {

        }
    }
}