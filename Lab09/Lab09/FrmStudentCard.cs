using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace StudentCardApp
{
    public partial class FrmStudentCard : Form
    {
        private readonly PrintDocument printDocument =
            new PrintDocument();

        private const int CardWidth = 1000;
        private const int CardHeight = 630;

        public FrmStudentCard()
        {
            InitializeComponent();

            LoadSampleData();
            ConnectEvents();

            printDocument.DocumentName = "TheSinhVien";

            printDocument.DefaultPageSettings.Margins =
                new Margins(50, 50, 50, 50);

            printDocument.PrintPage += PrintDocument_PrintPage;

            ResetForm();
        }

        // ==================== DỮ LIỆU MẪU ====================

        private void LoadSampleData()
        {
            cboClass.Items.AddRange(new object[]
            {
                "CNTT01",
                "CNTT02",
                "SPTIN01",
                "SPTIN02"
            });

            cboFaculty.Items.AddRange(new object[]
            {
                "Công nghệ thông tin",
                "Toán - Tin học",
                "Ngoại ngữ",
                "Giáo dục Tiểu học"
            });

            cboCourse.Items.AddRange(new object[]
            {
                "K49",
                "K50",
                "K51"
            });

            cboGender.Items.AddRange(new object[]
            {
                "Nam",
                "Nữ",
                "Khác"
            });
        }

        // ==================== KẾT NỐI SỰ KIỆN ====================

        private void ConnectEvents()
        {
            txtStudentId.TextChanged += InputChanged;
            txtFullName.TextChanged += InputChanged;

            cboClass.TextChanged += InputChanged;
            cboFaculty.TextChanged += InputChanged;
            cboCourse.SelectedIndexChanged += InputChanged;
            cboGender.SelectedIndexChanged += InputChanged;
            dtpBirthDate.ValueChanged += InputChanged;

            pnlPreview.Paint += Preview_Paint;

            pnlPreview.Resize += delegate
            {
                pnlPreview.Invalidate();
            };

            btnChooseImage.Click += delegate
            {
                ChooseImage();
            };

            btnReset.Click += delegate
            {
                ResetForm();
            };

            btnPrintPreview.Click += delegate
            {
                ShowPrintPreview();
            };

            btnPrint.Click += delegate
            {
                PrintCard();
            };

            btnSavePng.Click += delegate
            {
                SavePng();
            };

            btnExit.Click += delegate
            {
                Close();
            };

            FormClosed += delegate
            {
                ClearPhoto();
                printDocument.Dispose();
            };
        }

        private void InputChanged(object sender, EventArgs e)
        {
            pnlPreview.Invalidate();

            lblStatus.Text = HasRequiredData()
                ? "Thẻ đã sẵn sàng để xem trước hoặc in."
                : "Nhập mã sinh viên, họ tên và chọn ảnh để xem thẻ.";
        }

        // ==================== KIỂM TRA DỮ LIỆU ====================

        private bool HasRequiredData()
        {
            return
                !string.IsNullOrWhiteSpace(txtStudentId.Text) &&
                !string.IsNullOrWhiteSpace(txtFullName.Text) &&
                picAvatar.Image != null;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên sinh viên.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                return false;
            }

            if (picAvatar.Image == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn ảnh đại diện.",
                    "Thiếu ảnh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // ==================== CHỌN ẢNH ====================

        private void ChooseImage()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh đại diện sinh viên";

                dialog.Filter =
                    "Ảnh sinh viên|*.jpg;*.jpeg;*.png;*.bmp";

                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    Bitmap nextImage;

                    // Tạo bản sao để không khóa file ảnh gốc.
                    using (Image original =
                        Image.FromFile(dialog.FileName))
                    {
                        nextImage = new Bitmap(original);
                    }

                    Image previous = picAvatar.Image;
                    picAvatar.Image = nextImage;

                    if (previous != null)
                    {
                        previous.Dispose();
                    }

                    InputChanged(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể đọc ảnh đã chọn.\n" + ex.Message,
                        "Lỗi ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ClearPhoto()
        {
            Image previous = picAvatar.Image;
            picAvatar.Image = null;

            if (previous != null)
            {
                previous.Dispose();
            }
        }

        // ==================== LÀM MỚI ====================

        private void ResetForm()
        {
            txtStudentId.Clear();
            txtFullName.Clear();

            cboClass.SelectedIndex = -1;
            cboClass.Text = "";

            cboFaculty.SelectedIndex = -1;
            cboFaculty.Text = "";

            cboCourse.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;

            dtpBirthDate.Value = DateTime.Today;

            ClearPhoto();

            lblStatus.Text =
                "Nhập mã sinh viên, họ tên và chọn ảnh để xem thẻ.";

            pnlPreview.Invalidate();
            ActiveControl = txtStudentId;
        }

        // ==================== PREVIEW TRÊN PANEL ====================

        private void Preview_Paint(
            object sender, PaintEventArgs e)
        {
            if (!HasRequiredData())
            {
                using (Font font = new Font("Segoe UI", 12F))
                using (SolidBrush brush =
                    new SolidBrush(Color.DimGray))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString(
                        "Nhập mã sinh viên, họ tên\n" +
                        "và chọn ảnh để hiển thị thẻ.",
                        font,
                        brush,
                        pnlPreview.ClientRectangle,
                        format);
                }

                return;
            }

            using (Bitmap card = CreateCardBitmap())
            {
                Rectangle area = new Rectangle(
                    15,
                    15,
                    Math.Max(1, pnlPreview.ClientSize.Width - 30),
                    Math.Max(1, pnlPreview.ClientSize.Height - 30));

                RectangleF target =
                    FitRectangle(card.Size, area);

                e.Graphics.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

                e.Graphics.DrawImage(card, target);
            }
        }

        // ==================== TẠO THẺ BẰNG GDI+ ====================

        private Bitmap CreateCardBitmap()
        {
            Bitmap bitmap = new Bitmap(CardWidth, CardHeight);

            try
            {
                using (Graphics graphics =
                    Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode =
                        SmoothingMode.AntiAlias;

                    graphics.InterpolationMode =
                        InterpolationMode.HighQualityBicubic;

                    graphics.TextRenderingHint =
                        System.Drawing.Text.TextRenderingHint
                            .AntiAliasGridFit;

                    graphics.Clear(
                        Color.FromArgb(242, 249, 255));

                    // Nền tiêu đề và khung ngoài.
                    using (SolidBrush headerBrush =
                        new SolidBrush(
                            Color.FromArgb(22, 65, 82)))
                    using (Pen borderPen =
                        new Pen(
                            Color.FromArgb(22, 65, 82), 4F))
                    {
                        graphics.FillRectangle(
                            headerBrush,
                            0,
                            0,
                            CardWidth,
                            145);

                        graphics.DrawRectangle(
                            borderPen,
                            2,
                            2,
                            CardWidth - 4,
                            CardHeight - 4);
                    }

                    DrawText(
                        graphics,
                        "TRƯỜNG ĐẠI HỌC SƯ PHẠM TP. HỒ CHÍ MINH",
                        new RectangleF(25, 20, 950, 40),
                        25F,
                        FontStyle.Bold,
                        Color.White,
                        true);

                    DrawText(
                        graphics,
                        "THẺ SINH VIÊN",
                        new RectangleF(25, 78, 950, 50),
                        36F,
                        FontStyle.Bold,
                        Color.White,
                        true);

                    // Ảnh bên trái.
                    Rectangle photoFrame =
                        new Rectangle(40, 180, 210, 280);

                    using (SolidBrush whiteBrush =
                        new SolidBrush(Color.White))
                    using (Pen photoPen =
                        new Pen(
                            Color.FromArgb(130, 150, 165), 2F))
                    {
                        graphics.FillRectangle(
                            whiteBrush,
                            photoFrame);

                        if (picAvatar.Image != null)
                        {
                            RectangleF photoTarget =
                                FitRectangle(
                                    picAvatar.Image.Size,
                                    photoFrame);

                            graphics.DrawImage(
                                picAvatar.Image,
                                photoTarget);
                        }

                        graphics.DrawRectangle(
                            photoPen,
                            photoFrame);
                    }

                    DrawText(
                        graphics,
                        txtStudentId.Text.Trim(),
                        new RectangleF(25, 478, 240, 50),
                        26F,
                        FontStyle.Bold,
                        Color.FromArgb(22, 65, 82),
                        true);

                    // Thông tin bên phải.
                    DrawInfo(
                        graphics,
                        "Họ tên:",
                        txtFullName.Text.Trim(),
                        180,
                        true);

                    DrawInfo(
                        graphics,
                        "Ngày sinh:",
                        dtpBirthDate.Value.ToString("dd/MM/yyyy"),
                        240,
                        false);

                    DrawInfo(
                        graphics,
                        "Giới tính:",
                        cboGender.Text,
                        300,
                        false);

                    DrawInfo(
                        graphics,
                        "Lớp:",
                        cboClass.Text.Trim(),
                        360,
                        false);

                    DrawInfo(
                        graphics,
                        "Khoa:",
                        cboFaculty.Text.Trim(),
                        420,
                        false);

                    DrawInfo(
                        graphics,
                        "Khóa học:",
                        cboCourse.Text,
                        480,
                        false);

                    // Đường phân cách cuối thẻ.
                    using (Pen linePen =
                        new Pen(
                            Color.FromArgb(180, 200, 215), 2F))
                    {
                        graphics.DrawLine(
                            linePen,
                            35,
                            555,
                            965,
                            555);
                    }

                    DrawText(
                        graphics,
                        "MÃ SINH VIÊN: " +
                            txtStudentId.Text.Trim(),
                        new RectangleF(40, 570, 920, 35),
                        22F,
                        FontStyle.Bold,
                        Color.FromArgb(22, 65, 82),
                        true);
                }

                return bitmap;
            }
            catch
            {
                bitmap.Dispose();
                throw;
            }
        }

        private void DrawInfo(
            Graphics graphics,
            string label,
            string value,
            float y,
            bool bold)
        {
            DrawText(
                graphics,
                label,
                new RectangleF(285, y, 160, 45),
                24F,
                FontStyle.Regular,
                Color.FromArgb(75, 85, 95),
                false);

            DrawText(
                graphics,
                string.IsNullOrWhiteSpace(value) ? "—" : value,
                new RectangleF(450, y, 505, 45),
                25F,
                bold ? FontStyle.Bold : FontStyle.Regular,
                Color.FromArgb(22, 45, 65),
                false);
        }

        private void DrawText(
            Graphics graphics,
            string text,
            RectangleF bounds,
            float size,
            FontStyle style,
            Color color,
            bool centered)
        {
            using (Font font = new Font(
                "Segoe UI",
                size,
                style,
                GraphicsUnit.Pixel))
            using (SolidBrush brush = new SolidBrush(color))
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = centered
                    ? StringAlignment.Center
                    : StringAlignment.Near;

                format.LineAlignment =
                    StringAlignment.Center;

                format.Trimming =
                    StringTrimming.EllipsisCharacter;

                format.FormatFlags =
                    StringFormatFlags.NoWrap;

                graphics.DrawString(
                    text,
                    font,
                    brush,
                    bounds,
                    format);
            }
        }

        // Giữ đúng tỉ lệ ảnh khi đưa vào một vùng.
        private RectangleF FitRectangle(
            Size imageSize,
            RectangleF area)
        {
            float scale = Math.Min(
                area.Width / imageSize.Width,
                area.Height / imageSize.Height);

            float width = imageSize.Width * scale;
            float height = imageSize.Height * scale;

            return new RectangleF(
                area.X + (area.Width - width) / 2F,
                area.Y + (area.Height - height) / 2F,
                width,
                height);
        }

        // ==================== XEM TRƯỚC IN ====================

        private void ShowPrintPreview()
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                using (PrintPreviewDialog dialog =
                    new PrintPreviewDialog())
                {
                    dialog.Document = printDocument;
                    dialog.Width = 1000;
                    dialog.Height = 750;

                    dialog.PrintPreviewControl.AutoZoom = true;

                    dialog.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở xem trước in.\n" +
                    "Hãy kiểm tra máy in hoặc máy in PDF.\n\n" +
                    ex.Message,
                    "Lỗi xem trước in",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==================== IN THẺ ====================

        private void PrintCard()
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                using (PrintDialog dialog = new PrintDialog())
                {
                    dialog.Document = printDocument;
                    dialog.UseEXDialog = true;
                    dialog.AllowSomePages = false;
                    dialog.AllowSelection = false;

                    if (dialog.ShowDialog(this) ==
                        DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể in thẻ.\n" + ex.Message,
                    "Lỗi in",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            if (!HasRequiredData())
            {
                e.Cancel = true;
                return;
            }

            if (e.MarginBounds.Width <= 0 ||
                e.MarginBounds.Height <= 0)
            {
                throw new InvalidOperationException(
                    "Vùng in không hợp lệ.");
            }

            using (Bitmap card = CreateCardBitmap())
            {
                // Kích thước khoảng 86 x 54 mm.
                // Tọa độ trang in dùng đơn vị 1/100 inch.
                float width = 86F / 25.4F * 100F;

                float height =
                    width * CardHeight / CardWidth;

                float scale = Math.Min(
                    1F,
                    Math.Min(
                        e.MarginBounds.Width / width,
                        e.MarginBounds.Height / height));

                width *= scale;
                height *= scale;

                float x =
                    e.MarginBounds.Left +
                    (e.MarginBounds.Width - width) / 2F;

                float y = e.MarginBounds.Top;

                e.Graphics.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

                e.Graphics.DrawImage(
                    card,
                    new RectangleF(
                        x,
                        y,
                        width,
                        height));
            }

            e.HasMorePages = false;
        }

        // ==================== LƯU PNG ====================

        private void SavePng()
        {
            if (!ValidateInput())
            {
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Lưu thẻ sinh viên";
                dialog.Filter = "PNG Image|*.png";
                dialog.DefaultExt = "png";
                dialog.AddExtension = true;
                dialog.FileName = "TheSinhVien.png";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (Bitmap card = CreateCardBitmap())
                    {
                        card.Save(
                            dialog.FileName,
                            ImageFormat.Png);
                    }

                    MessageBox.Show(
                        "Đã lưu thẻ thành công.",
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
    }
}