using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace COMP1019_Lab08_SimplePaint
{
    public partial class Form1 : Form
    {
        private readonly List<DrawItem> items =
            new List<DrawItem>();

        private DrawItem currentItem;
        private Color currentColor = Color.Black;
        private Bitmap backgroundImage;
        private Point lastMousePosition;

        public Form1()
        {
            InitializeComponent();

            cboMode.Items.AddRange(new object[]
            {
                "Pen",
                "Line",
                "Rectangle",
                "Ellipse"
            });

            cboMode.SelectedIndex = 0;

            canvas.Paint += Canvas_Paint;
            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseUp += Canvas_MouseUp;

            canvas.MouseCaptureChanged += delegate
            {
                if (!canvas.Capture && currentItem != null)
                {
                    currentItem = null;
                    canvas.Invalidate();
                    UpdateStatus();
                }
            };

            cboMode.SelectedIndexChanged += delegate
            {
                UpdateStatus();
            };

            nudWidth.ValueChanged += delegate
            {
                UpdateStatus();
            };

            btnColor.Click += delegate { ChooseColor(); };
            btnUndo.Click += delegate { Undo(); };
            btnClear.Click += delegate { ClearCanvas(); };
            btnSave.Click += delegate { SavePng(); };
            btnOpen.Click += delegate { OpenBackground(); };

            btnBackground.Click += delegate
            {
                ChangeBackgroundColor();
            };

            KeyDown += Form1_KeyDown;

            FormClosed += delegate
            {
                if (backgroundImage != null)
                {
                    backgroundImage.Dispose();
                    backgroundImage = null;
                }
            };

            UpdateStatus();
        }

        // ==================== XỬ LÝ CHUỘT ====================

        private Point GetCanvasPoint(Point point)
        {
            int maxX = Math.Max(0, canvas.ClientSize.Width - 1);
            int maxY = Math.Max(0, canvas.ClientSize.Height - 1);

            int x = Math.Max(0, Math.Min(point.X, maxX));
            int y = Math.Max(0, Math.Min(point.Y, maxY));

            return new Point(x, y);
        }

        private void Canvas_MouseDown(
            object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            Point point = GetCanvasPoint(e.Location);
            lastMousePosition = point;

            currentItem = new DrawItem
            {
                Mode = (DrawMode)cboMode.SelectedIndex,
                Color = currentColor,
                Width = (float)nudWidth.Value,
                Filled = chkFill.Checked,
                Start = point,
                End = point
            };

            currentItem.Points.Add(point);

            canvas.Capture = true;
            canvas.Invalidate();
            UpdateStatus();
        }

        private void Canvas_MouseMove(
            object sender, MouseEventArgs e)
        {
            Point point = GetCanvasPoint(e.Location);
            lastMousePosition = point;

            if (currentItem != null)
            {
                UpdateCurrentItem(point);
                canvas.Invalidate();
            }

            UpdateStatus();
        }

        private void Canvas_MouseUp(
            object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left ||
                currentItem == null)
            {
                return;
            }

            Point point = GetCanvasPoint(e.Location);
            lastMousePosition = point;

            UpdateCurrentItem(point);

            bool valid = true;

            if (currentItem.Mode == DrawMode.Rectangle ||
                currentItem.Mode == DrawMode.Ellipse)
            {
                Rectangle bounds = currentItem.GetBounds();

                valid = bounds.Width > 0 && bounds.Height > 0;
            }

            if (valid)
            {
                items.Add(currentItem);
            }

            currentItem = null;
            canvas.Capture = false;

            canvas.Invalidate();
            UpdateStatus();
        }

        private void UpdateCurrentItem(Point point)
        {
            currentItem.End = point;

            if (currentItem.Mode == DrawMode.Pen)
            {
                int count = currentItem.Points.Count;

                if (count == 0 ||
                    currentItem.Points[count - 1] != point)
                {
                    currentItem.Points.Add(point);
                }
            }
        }

        // ==================== VẼ LẠI CANVAS ====================

        private void Canvas_Paint(
            object sender, PaintEventArgs e)
        {
            RenderCanvas(e.Graphics, true);
        }

        private void RenderCanvas(
            Graphics graphics, bool includePreview)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Ảnh nền được đặt tại góc trên trái,
            // giữ nguyên kích thước gốc.
            if (backgroundImage != null)
            {
                graphics.DrawImageUnscaled(
                    backgroundImage, 0, 0);
            }

            foreach (DrawItem item in items)
            {
                item.Draw(graphics);
            }

            // Hiển thị hình xem trước trong lúc kéo chuột.
            if (includePreview && currentItem != null)
            {
                currentItem.Draw(graphics);
            }
        }

        // ==================== CHỌN MÀU ====================

        private void ChooseColor()
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = currentColor;
                dialog.FullOpen = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                currentColor = dialog.Color;

                btnColor.BackColor = currentColor;

                btnColor.ForeColor =
                    currentColor.GetBrightness() < 0.5F
                    ? Color.White
                    : Color.Black;

                UpdateStatus();
            }
        }

        private void ChangeBackgroundColor()
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = canvas.BackColor;
                dialog.FullOpen = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    canvas.BackColor = dialog.Color;
                    canvas.Invalidate();
                }
            }
        }

        // ==================== UNDO ====================

        private void CancelCurrentDrawing()
        {
            currentItem = null;
            canvas.Capture = false;
        }

        private void Undo()
        {
            // Nếu đang kéo chuột, hủy nét chưa hoàn thành.
            if (currentItem != null)
            {
                CancelCurrentDrawing();
            }
            else if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
            }

            canvas.Invalidate();
            UpdateStatus();
        }

        // ==================== CLEAR ====================

        private void ClearCanvas()
        {
            DialogResult answer = MessageBox.Show(
                "Bạn có muốn xóa toàn bộ vùng vẽ không?",
                "Xác nhận Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            CancelCurrentDrawing();
            items.Clear();

            if (backgroundImage != null)
            {
                backgroundImage.Dispose();
                backgroundImage = null;
            }

            canvas.BackColor = Color.White;
            canvas.Invalidate();
            UpdateStatus();
        }

        // ==================== LƯU PNG ====================

        private void SavePng()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Lưu vùng vẽ";
                dialog.Filter = "PNG Image|*.png";
                dialog.DefaultExt = "png";
                dialog.AddExtension = true;
                dialog.FileName = "Lab08_Paint.png";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    int width = Math.Max(
                        1, canvas.ClientSize.Width);

                    int height = Math.Max(
                        1, canvas.ClientSize.Height);

                    using (Bitmap bitmap =
                        new Bitmap(width, height))
                    {
                        using (Graphics graphics =
                            Graphics.FromImage(bitmap))
                        {
                            graphics.Clear(canvas.BackColor);
                            RenderCanvas(graphics, false);
                        }

                        bitmap.Save(
                            dialog.FileName,
                            ImageFormat.Png);
                    }

                    MessageBox.Show(
                        "Đã lưu ảnh PNG thành công.",
                        "Lưu ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể lưu ảnh.\n" + ex.Message,
                        "Lỗi lưu ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ==================== MỞ ẢNH NỀN ====================

        private void OpenBackground()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh nền";

                dialog.Filter =
                    "Ảnh|*.png;*.jpg;*.jpeg;*.bmp;*.gif";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    Bitmap nextImage;

                    // Tạo bản sao để không khóa file gốc.
                    using (Image original =
                        Image.FromFile(dialog.FileName))
                    {
                        nextImage = new Bitmap(original);
                    }

                    if (backgroundImage != null)
                    {
                        backgroundImage.Dispose();
                    }

                    backgroundImage = nextImage;

                    canvas.Invalidate();
                    UpdateStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể mở ảnh.\n" + ex.Message,
                        "Lỗi mở ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ==================== PHÍM TẮT ====================

        private void Form1_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelCurrentDrawing();
                canvas.Invalidate();
                UpdateStatus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // ==================== TRẠNG THÁI ====================

        private void UpdateStatus()
        {
            lblStatus.Text =
                "X: " + lastMousePosition.X +
                "   Y: " + lastMousePosition.Y +
                "   |   Chế độ: " + cboMode.Text +
                "   |   Độ dày: " + nudWidth.Value +
                "   |   Số nét: " + items.Count;
        }
    }
}