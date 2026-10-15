namespace COMP1019_Lab08_SimplePaint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTools = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();

            this.btnColor = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.chkFill = new System.Windows.Forms.CheckBox();

            this.canvas = new DrawingCanvas();
            this.lblStatus = new System.Windows.Forms.Label();

            this.pnlTools.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.nudWidth)).BeginInit();

            this.SuspendLayout();

            // Thanh công cụ
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Height = 110;
            this.pnlTools.BackColor = System.Drawing.Color.White;

            this.pnlTools.Controls.Add(this.lblMode);
            this.pnlTools.Controls.Add(this.cboMode);
            this.pnlTools.Controls.Add(this.lblWidth);
            this.pnlTools.Controls.Add(this.nudWidth);
            this.pnlTools.Controls.Add(this.btnColor);
            this.pnlTools.Controls.Add(this.btnUndo);
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Controls.Add(this.btnSave);
            this.pnlTools.Controls.Add(this.btnOpen);
            this.pnlTools.Controls.Add(this.btnBackground);
            this.pnlTools.Controls.Add(this.chkFill);

            // Chế độ
            this.lblMode.Name = "lblMode";
            this.lblMode.Text = "Chế độ:";
            this.lblMode.Location = new System.Drawing.Point(20, 20);
            this.lblMode.Size = new System.Drawing.Size(75, 25);

            this.cboMode.Name = "cboMode";
            this.cboMode.Location = new System.Drawing.Point(100, 16);
            this.cboMode.Size = new System.Drawing.Size(160, 27);
            this.cboMode.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.TabIndex = 0;

            // Độ dày
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Text = "Độ dày:";
            this.lblWidth.Location = new System.Drawing.Point(285, 20);
            this.lblWidth.Size = new System.Drawing.Size(75, 25);

            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Location = new System.Drawing.Point(365, 16);
            this.nudWidth.Size = new System.Drawing.Size(75, 25);
            this.nudWidth.Minimum = new decimal(
                new int[] { 1, 0, 0, 0 });
            this.nudWidth.Maximum = new decimal(
                new int[] { 20, 0, 0, 0 });
            this.nudWidth.Value = new decimal(
                new int[] { 3, 0, 0, 0 });
            this.nudWidth.TabIndex = 1;

            // Màu nét
            this.btnColor.Name = "btnColor";
            this.btnColor.Text = "Chọn màu";
            this.btnColor.Location = new System.Drawing.Point(465, 12);
            this.btnColor.Size = new System.Drawing.Size(110, 35);
            this.btnColor.TabIndex = 2;
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.UseVisualStyleBackColor = false;

            // Tô hình
            this.chkFill.Name = "chkFill";
            this.chkFill.Text = "Tô màu hình";
            this.chkFill.Location = new System.Drawing.Point(600, 16);
            this.chkFill.Size = new System.Drawing.Size(150, 28);
            this.chkFill.TabIndex = 3;

            // Undo
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Text = "Undo";
            this.btnUndo.Location = new System.Drawing.Point(20, 60);
            this.btnUndo.Size = new System.Drawing.Size(105, 35);
            this.btnUndo.TabIndex = 4;

            // Clear
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(140, 60);
            this.btnClear.Size = new System.Drawing.Size(105, 35);
            this.btnClear.TabIndex = 5;

            // Lưu ảnh
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Lưu PNG";
            this.btnSave.Location = new System.Drawing.Point(260, 60);
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 6;

            // Mở ảnh nền
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Text = "Mở ảnh nền";
            this.btnOpen.Location = new System.Drawing.Point(385, 60);
            this.btnOpen.Size = new System.Drawing.Size(130, 35);
            this.btnOpen.TabIndex = 7;

            // Đổi màu nền
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Text = "Màu nền";
            this.btnBackground.Location =
                new System.Drawing.Point(530, 60);
            this.btnBackground.Size = new System.Drawing.Size(110, 35);
            this.btnBackground.TabIndex = 8;

            // Canvas
            this.canvas.Name = "canvas";
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.TabIndex = 1;

            // Trạng thái
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Height = 32;
            this.lblStatus.Text = "Sẵn sàng";
            this.lblStatus.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.BackColor =
                System.Drawing.Color.FromArgb(232, 240, 245);

            // Form1
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "Lab08 - Simple Paint";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            this.Controls.Add(this.canvas);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlTools);

            this.pnlTools.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.nudWidth)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.CheckBox chkFill;

        private DrawingCanvas canvas;
        private System.Windows.Forms.Label lblStatus;
    }
}