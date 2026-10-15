using System.Windows.Forms;

namespace COMP1019_Lab08_SimplePaint
{
    public class DrawingCanvas : Panel
    {
        public DrawingCanvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}