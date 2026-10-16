namespace StudentCardApp
{
    partial class FrmStudentCard
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();

            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();

            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cboGender = new System.Windows.Forms.ComboBox();

            this.picAvatar = new System.Windows.Forms.PictureBox();

            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSavePng = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();

            this.grpInput.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.picAvatar)).BeginInit();

            this.SuspendLayout();

            // 
            // grpInput
            // 
            this.grpInput.Name = "grpInput";
            this.grpInput.Text = "Thông tin sinh viên";
            this.grpInput.Location =
                new System.Drawing.Point(20, 20);
            this.grpInput.Size =
                new System.Drawing.Size(390, 700);
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;

            this.grpInput.Controls.Add(this.lblStudentId);
            this.grpInput.Controls.Add(this.lblFullName);
            this.grpInput.Controls.Add(this.lblClass);
            this.grpInput.Controls.Add(this.lblFaculty);
            this.grpInput.Controls.Add(this.lblCourse);
            this.grpInput.Controls.Add(this.lblBirthDate);
            this.grpInput.Controls.Add(this.lblGender);

            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.txtFullName);
            this.grpInput.Controls.Add(this.cboClass);
            this.grpInput.Controls.Add(this.cboFaculty);
            this.grpInput.Controls.Add(this.cboCourse);
            this.grpInput.Controls.Add(this.dtpBirthDate);
            this.grpInput.Controls.Add(this.cboGender);

            this.grpInput.Controls.Add(this.picAvatar);
            this.grpInput.Controls.Add(this.btnChooseImage);
            this.grpInput.Controls.Add(this.btnReset);

            // 
            // lblStudentId
            // 
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Text = "Mã sinh viên:";
            this.lblStudentId.Location =
                new System.Drawing.Point(18, 40);
            this.lblStudentId.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblFullName
            // 
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Text = "Họ và tên:";
            this.lblFullName.Location =
                new System.Drawing.Point(18, 87);
            this.lblFullName.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblClass
            // 
            this.lblClass.Name = "lblClass";
            this.lblClass.Text = "Lớp:";
            this.lblClass.Location =
                new System.Drawing.Point(18, 134);
            this.lblClass.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblFaculty
            // 
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Text = "Khoa:";
            this.lblFaculty.Location =
                new System.Drawing.Point(18, 181);
            this.lblFaculty.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblCourse
            // 
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Text = "Khóa học:";
            this.lblCourse.Location =
                new System.Drawing.Point(18, 228);
            this.lblCourse.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Text = "Ngày sinh:";
            this.lblBirthDate.Location =
                new System.Drawing.Point(18, 275);
            this.lblBirthDate.Size =
                new System.Drawing.Size(125, 25);

            // 
            // lblGender
            // 
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Giới tính:";
            this.lblGender.Location =
                new System.Drawing.Point(18, 322);
            this.lblGender.Size =
                new System.Drawing.Size(125, 25);

            // 
            // txtStudentId
            // 
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Location =
                new System.Drawing.Point(145, 36);
            this.txtStudentId.Size =
                new System.Drawing.Size(225, 25);
            this.txtStudentId.MaxLength = 30;
            this.txtStudentId.TabIndex = 0;

            // 
            // txtFullName
            // 
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Location =
                new System.Drawing.Point(145, 83);
            this.txtFullName.Size =
                new System.Drawing.Size(225, 25);
            this.txtFullName.MaxLength = 60;
            this.txtFullName.TabIndex = 1;

            // 
            // cboClass
            // 
            this.cboClass.Name = "cboClass";
            this.cboClass.Location =
                new System.Drawing.Point(145, 130);
            this.cboClass.Size =
                new System.Drawing.Size(225, 27);
            this.cboClass.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboClass.TabIndex = 2;

            // 
            // cboFaculty
            // 
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Location =
                new System.Drawing.Point(145, 177);
            this.cboFaculty.Size =
                new System.Drawing.Size(225, 27);
            this.cboFaculty.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboFaculty.TabIndex = 3;

            // 
            // cboCourse
            // 
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Location =
                new System.Drawing.Point(145, 224);
            this.cboCourse.Size =
                new System.Drawing.Size(225, 27);
            this.cboCourse.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.TabIndex = 4;

            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Location =
                new System.Drawing.Point(145, 271);
            this.dtpBirthDate.Size =
                new System.Drawing.Size(225, 25);
            this.dtpBirthDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.TabIndex = 5;

            // 
            // cboGender
            // 
            this.cboGender.Name = "cboGender";
            this.cboGender.Location =
                new System.Drawing.Point(145, 318);
            this.cboGender.Size =
                new System.Drawing.Size(225, 27);
            this.cboGender.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.TabIndex = 6;

            // 
            // picAvatar
            // 
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Location =
                new System.Drawing.Point(120, 370);
            this.picAvatar.Size =
                new System.Drawing.Size(150, 190);
            this.picAvatar.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.BackColor =
                System.Drawing.Color.FromArgb(240, 244, 248);
            this.picAvatar.TabStop = false;

            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Location =
                new System.Drawing.Point(120, 575);
            this.btnChooseImage.Size =
                new System.Drawing.Size(150, 38);
            this.btnChooseImage.TabIndex = 7;
            this.btnChooseImage.UseVisualStyleBackColor = true;

            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Text = "Làm mới";
            this.btnReset.Location =
                new System.Drawing.Point(120, 630);
            this.btnReset.Size =
                new System.Drawing.Size(150, 38);
            this.btnReset.TabIndex = 8;
            this.btnReset.UseVisualStyleBackColor = true;

            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Text = "XEM TRƯỚC THẺ SINH VIÊN";
            this.lblPreviewTitle.Location =
                new System.Drawing.Point(440, 20);
            this.lblPreviewTitle.Size =
                new System.Drawing.Size(700, 40);
            this.lblPreviewTitle.Font = new System.Drawing.Font(
                "Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);

            // 
            // pnlPreview
            // 
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Location =
                new System.Drawing.Point(440, 75);
            this.pnlPreview.Size =
                new System.Drawing.Size(720, 480);
            this.pnlPreview.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.pnlPreview.BackColor =
                System.Drawing.Color.FromArgb(222, 230, 237);
            this.pnlPreview.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Text = "Xem trước in";
            this.btnPrintPreview.Location =
                new System.Drawing.Point(440, 580);
            this.btnPrintPreview.Size =
                new System.Drawing.Size(155, 42);
            this.btnPrintPreview.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.btnPrintPreview.TabIndex = 1;
            this.btnPrintPreview.UseVisualStyleBackColor = true;

            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "In thẻ";
            this.btnPrint.Location =
                new System.Drawing.Point(610, 580);
            this.btnPrint.Size =
                new System.Drawing.Size(120, 42);
            this.btnPrint.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;

            // 
            // btnSavePng
            // 
            this.btnSavePng.Name = "btnSavePng";
            this.btnSavePng.Text = "Lưu PNG";
            this.btnSavePng.Location =
                new System.Drawing.Point(745, 580);
            this.btnSavePng.Size =
                new System.Drawing.Size(120, 42);
            this.btnSavePng.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.btnSavePng.TabIndex = 3;
            this.btnSavePng.UseVisualStyleBackColor = true;

            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Thoát";
            this.btnExit.Location =
                new System.Drawing.Point(880, 580);
            this.btnExit.Size =
                new System.Drawing.Size(120, 42);
            this.btnExit.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;

            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text =
                "Nhập mã sinh viên, họ tên và chọn ảnh để xem thẻ.";
            this.lblStatus.Location =
                new System.Drawing.Point(440, 645);
            this.lblStatus.Size =
                new System.Drawing.Size(700, 60);
            this.lblStatus.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // 
            // FrmStudentCard
            // 
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize =
                new System.Drawing.Size(1180, 740);
            this.MinimumSize =
                new System.Drawing.Size(1196, 779);
            this.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.Name = "FrmStudentCard";
            this.Text = "Lab09 - Thiết kế và in thẻ sinh viên";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblPreviewTitle);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSavePng);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.picAvatar)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboGender;

        private System.Windows.Forms.PictureBox picAvatar;

        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSavePng;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblPreviewTitle;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblStatus;
    }
}