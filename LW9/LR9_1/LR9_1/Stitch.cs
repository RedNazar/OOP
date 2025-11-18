using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LR9_1
{
    public partial class Stitch : UserControl
    {
        private bool isMouseDown = false;
        public bool fill = false;
        public Stitch()
        {
            InitializeComponent();
            this.MouseDown += Stitch_MouseDown;
            this.MouseUp += Stitch_MouseUp;
            this.MouseMove += Stitch_MouseMove;
            this.MouseClick += PolotnoMouseClick;
            this.Paint += PolotnoPaint;
            this.SizeChanged += PolotnoSizeChanged;
        }

        public Color ActiveColor = Color.Green;
        public string protokol = "";
        public int symm = 0; // 0 - без, 1 - вертикальна, 2 - горизонтальна, 3 - дві осі, 4 - центральна
        public int CWid, CHig;
        int CrossWidth = 8;

        private void Stitch_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            DrawAt(e.X, e.Y);
        }

        private void Stitch_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Stitch_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                DrawAt(e.X, e.Y);
            }
        }
        void PolotnoMouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X / CrossWidth * CrossWidth;
            int Y = e.Y / CrossWidth * CrossWidth;

            if (fill)
            {
                FloodFillWithSymmetry(X, Y, ActiveColor);
            }
            else
            {
                DrawAt(X, Y);
            }
        }


        private void DrawAt(int x, int y)
        {
            int X = (x / CrossWidth) * CrossWidth;
            int Y = (y / CrossWidth) * CrossWidth;

            if (fill)
            {
                FloodFillWithSymmetry(X, Y, ActiveColor);
            }
            else
            {
                DrawSymmetric(X, Y);
                Invalidate();
            }
        }


        private void AddCross(int X, int Y)
        {
            for (int p = 0; p < protokol.Length; p += 26)
                if (X == int.Parse(protokol.Substring(p, 5)) && Y == int.Parse(protokol.Substring(p + 5, 5)))
                {
                    protokol = protokol.Remove(p, 26);
                    break;
                }

            protokol += string.Format("{0,5}{1,5}{2,4}{3,4}{4,4}{5,4}", X, Y, ActiveColor.A, ActiveColor.R, ActiveColor.G, ActiveColor.B);
        }

        private void PolotnoPaint(object sender, PaintEventArgs e)
        {
            SolidBrush B = new SolidBrush(ActiveColor);
            for (int x = 0; x < protokol.Length; x += 26)
            {
                B.Color = Color.FromArgb(
                    int.Parse(protokol.Substring(x + 10, 4)),
                    int.Parse(protokol.Substring(x + 14, 4)),
                    int.Parse(protokol.Substring(x + 18, 4)),
                    int.Parse(protokol.Substring(x + 22, 4))
                );

                e.Graphics.FillRectangle(B,
                    int.Parse(protokol.Substring(x, 5)),
                    int.Parse(protokol.Substring(x + 5, 5)),
                    CrossWidth - 1, CrossWidth - 1
                );
            }
        }

        private void PolotnoSizeChanged(object sender, EventArgs e)
        {
            CWid = Width / CrossWidth;
            CHig = Height / CrossWidth;
        }

        public void Clear()
        {
            protokol = "";
            Invalidate();
        }
        public void SaveImage(string filePath)
        {
            if (Width == 0 || Height == 0) return;

            using (Bitmap bmp = new Bitmap(Width, Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        Color GetCellColor(int x, int y)
        {
            for (int i = 0; i < protokol.Length; i += 26)
            {
                int px = int.Parse(protokol.Substring(i, 5));
                int py = int.Parse(protokol.Substring(i + 5, 5));
                if (px == x && py == y)
                {
                    return Color.FromArgb(
                        int.Parse(protokol.Substring(i + 10, 4)),
                        int.Parse(protokol.Substring(i + 14, 4)),
                        int.Parse(protokol.Substring(i + 18, 4)),
                        int.Parse(protokol.Substring(i + 22, 4))
                    );
                }
            }
            return Color.Empty;
        }

        void FloodFillWithSymmetry(int startX, int startY, Color fillColor)
        {
            int X = startX;
            int Y = startY;

            Color targetColor = GetCellColor(X, Y);
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            Queue<Point> q = new Queue<Point>();
            q.Enqueue(new Point(X, Y));

            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                int cx = p.X;
                int cy = p.Y;

                if (cx < 0 || cy < 0 || cx >= Width || cy >= Height)
                    continue;

                Color currentColor = GetCellColor(cx, cy);
                if (currentColor.ToArgb() != targetColor.ToArgb()) continue;

                DrawSymmetric(cx, cy);

                q.Enqueue(new Point(cx + CrossWidth, cy));
                q.Enqueue(new Point(cx - CrossWidth, cy));
                q.Enqueue(new Point(cx, cy + CrossWidth));
                q.Enqueue(new Point(cx, cy - CrossWidth));
            }

            Invalidate();
        }


        private void DrawSymmetric(int X, int Y)
        {
            // Завжди малюємо базову клітинку
            AddCross(X, Y);

            int centerX = ((CWid - 1) * CrossWidth) / 2;   // центр по X
            int centerY = ((CHig - 1) * CrossWidth) / 2;   // центр по Y

            // Вертикальна вісь (віддзеркалення по центру по X)
            int mirrorX = (CWid * CrossWidth) - X - CrossWidth;
            // Горизонтальна вісь (віддзеркалення по центру по Y)
            int mirrorY = (CHig * CrossWidth) - Y - CrossWidth;
            // Центральна симетрія (поворот на 180°)
            int centralX = (CWid * CrossWidth) - X - CrossWidth;
            int centralY = (CHig * CrossWidth) - Y - CrossWidth;

            switch (symm)
            {
                case 0: // Без симетрії — тільки одна клітинка
                    break;

                case 1: // Вертикальна вісь
                    if (mirrorX != X) AddCross(mirrorX, Y);
                    break;

                case 2: // Горизонтальна вісь
                    if (mirrorY != Y) AddCross(X, mirrorY);
                    break;

                case 3: // Дві осі (і вертикальна, і горизонтальна) → 4 клітинки
                    if (mirrorX != X) AddCross(mirrorX, Y);
                    if (mirrorY != Y) AddCross(X, mirrorY);
                    if (mirrorX != X && mirrorY != Y) AddCross(mirrorX, mirrorY);
                    break;

                case 4: // Центральна симетрія (поворот 180°)
                    int cx = centerX * 2 - X;
                    int cy = centerY * 2 - Y;
                    if (cx != X || cy != Y) AddCross(cx, cy);
                    break;
            }
        }
    }
}
