using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace COMP1019_Lab08_SimplePaint
{
    public enum DrawMode
    {
        Pen,
        Line,
        Rectangle,
        Ellipse
    }

    public class DrawItem
    {
        public DrawMode Mode { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public bool Filled { get; set; }

        public Point Start { get; set; }
        public Point End { get; set; }

        public List<Point> Points { get; } = new List<Point>();

        // Chuẩn hóa để kéo hình theo hướng nào cũng đúng.
        public Rectangle GetBounds()
        {
            int x = Math.Min(Start.X, End.X);
            int y = Math.Min(Start.Y, End.Y);

            int width = Math.Abs(End.X - Start.X);
            int height = Math.Abs(End.Y - Start.Y);

            return new Rectangle(x, y, width, height);
        }

        public void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, Width))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;

                if (Mode == DrawMode.Pen)
                {
                    if (Points.Count > 1)
                    {
                        graphics.DrawLines(pen, Points.ToArray());
                    }
                    else if (Points.Count == 1)
                    {
                        DrawDot(graphics, Points[0]);
                    }

                    return;
                }

                if (Mode == DrawMode.Line)
                {
                    if (Start == End)
                    {
                        DrawDot(graphics, Start);
                    }
                    else
                    {
                        graphics.DrawLine(pen, Start, End);
                    }

                    return;
                }

                Rectangle bounds = GetBounds();

                if (bounds.Width == 0 || bounds.Height == 0)
                {
                    return;
                }

                using (SolidBrush brush = new SolidBrush(Color))
                {
                    if (Mode == DrawMode.Rectangle)
                    {
                        if (Filled)
                        {
                            graphics.FillRectangle(brush, bounds);
                        }

                        graphics.DrawRectangle(pen, bounds);
                    }
                    else if (Mode == DrawMode.Ellipse)
                    {
                        if (Filled)
                        {
                            graphics.FillEllipse(brush, bounds);
                        }

                        graphics.DrawEllipse(pen, bounds);
                    }
                }
            }
        }

        private void DrawDot(Graphics graphics, Point point)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                graphics.FillEllipse(
                    brush,
                    point.X - Width / 2F,
                    point.Y - Width / 2F,
                    Width,
                    Width);
            }
        }
    }
}