namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOrder = new Button();
            grbMenu = new GroupBox();
            pibChikenBurger = new PictureBox();
            pibBeefBurger = new PictureBox();
            pibburger = new PictureBox();
            rbtnChikenBurger = new RadioButton();
            rbtnBeefBurger = new RadioButton();
            rbtnBurger = new RadioButton();
            grbAddMenu = new GroupBox();
            chkAddsorse = new CheckBox();
            chkAddchize = new CheckBox();
            chkcola = new CheckBox();
            chkkamti = new CheckBox();
            grbMenuList = new GroupBox();
            lblTitle = new Label();
            libMenuList = new ListBox();
            btnClear = new Button();
            lblStatus = new Label();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pibChikenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibBeefBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibburger).BeginInit();
            grbAddMenu.SuspendLayout();
            grbMenuList.SuspendLayout();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("맑은 고딕", 20F);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(575, 495);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(173, 64);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(pibChikenBurger);
            grbMenu.Controls.Add(pibBeefBurger);
            grbMenu.Controls.Add(pibburger);
            grbMenu.Controls.Add(rbtnChikenBurger);
            grbMenu.Controls.Add(rbtnBeefBurger);
            grbMenu.Controls.Add(rbtnBurger);
            grbMenu.Font = new Font("맑은 고딕", 18F);
            grbMenu.ForeColor = Color.Red;
            grbMenu.Location = new Point(64, 138);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(313, 421);
            grbMenu.TabIndex = 1;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴 선택";
            // 
            // pibChikenBurger
            // 
            pibChikenBurger.Image = Properties.Resources.치킨버거;
            pibChikenBurger.Location = new Point(180, 287);
            pibChikenBurger.Name = "pibChikenBurger";
            pibChikenBurger.Size = new Size(111, 102);
            pibChikenBurger.SizeMode = PictureBoxSizeMode.Zoom;
            pibChikenBurger.TabIndex = 5;
            pibChikenBurger.TabStop = false;
            // 
            // pibBeefBurger
            // 
            pibBeefBurger.Image = Properties.Resources.불고기버거;
            pibBeefBurger.Location = new Point(180, 162);
            pibBeefBurger.Name = "pibBeefBurger";
            pibBeefBurger.Size = new Size(111, 102);
            pibBeefBurger.SizeMode = PictureBoxSizeMode.Zoom;
            pibBeefBurger.TabIndex = 4;
            pibBeefBurger.TabStop = false;
            // 
            // pibburger
            // 
            pibburger.Image = (Image)resources.GetObject("pibburger.Image");
            pibburger.Location = new Point(180, 38);
            pibburger.Name = "pibburger";
            pibburger.Size = new Size(111, 102);
            pibburger.SizeMode = PictureBoxSizeMode.Zoom;
            pibburger.TabIndex = 3;
            pibburger.TabStop = false;
            // 
            // rbtnChikenBurger
            // 
            rbtnChikenBurger.AutoSize = true;
            rbtnChikenBurger.Font = new Font("맑은 고딕", 15F);
            rbtnChikenBurger.ForeColor = Color.Black;
            rbtnChikenBurger.Location = new Point(19, 313);
            rbtnChikenBurger.Name = "rbtnChikenBurger";
            rbtnChikenBurger.Size = new Size(136, 39);
            rbtnChikenBurger.TabIndex = 2;
            rbtnChikenBurger.TabStop = true;
            rbtnChikenBurger.Text = "치킨버거";
            rbtnChikenBurger.UseVisualStyleBackColor = true;
            // 
            // rbtnBeefBurger
            // 
            rbtnBeefBurger.AutoSize = true;
            rbtnBeefBurger.Font = new Font("맑은 고딕", 15F);
            rbtnBeefBurger.ForeColor = Color.Black;
            rbtnBeefBurger.Location = new Point(19, 186);
            rbtnBeefBurger.Name = "rbtnBeefBurger";
            rbtnBeefBurger.Size = new Size(161, 39);
            rbtnBeefBurger.TabIndex = 1;
            rbtnBeefBurger.TabStop = true;
            rbtnBeefBurger.Text = "불고기버거";
            rbtnBeefBurger.UseVisualStyleBackColor = true;
            // 
            // rbtnBurger
            // 
            rbtnBurger.AllowDrop = true;
            rbtnBurger.AutoSize = true;
            rbtnBurger.Font = new Font("맑은 고딕", 15F);
            rbtnBurger.ForeColor = Color.Black;
            rbtnBurger.Location = new Point(19, 67);
            rbtnBurger.Name = "rbtnBurger";
            rbtnBurger.Size = new Size(111, 39);
            rbtnBurger.TabIndex = 0;
            rbtnBurger.TabStop = true;
            rbtnBurger.Text = "햄버거";
            rbtnBurger.UseVisualStyleBackColor = true;
            // 
            // grbAddMenu
            // 
            grbAddMenu.Controls.Add(chkAddsorse);
            grbAddMenu.Controls.Add(chkAddchize);
            grbAddMenu.Controls.Add(chkcola);
            grbAddMenu.Controls.Add(chkkamti);
            grbAddMenu.Font = new Font("맑은 고딕", 18F);
            grbAddMenu.ForeColor = Color.Red;
            grbAddMenu.Location = new Point(407, 138);
            grbAddMenu.Name = "grbAddMenu";
            grbAddMenu.Size = new Size(211, 253);
            grbAddMenu.TabIndex = 2;
            grbAddMenu.TabStop = false;
            grbAddMenu.Text = "추가 메뉴";
            // 
            // chkAddsorse
            // 
            chkAddsorse.AutoSize = true;
            chkAddsorse.Font = new Font("맑은 고딕", 12F);
            chkAddsorse.ForeColor = Color.Black;
            chkAddsorse.Location = new Point(17, 184);
            chkAddsorse.Name = "chkAddsorse";
            chkAddsorse.Size = new Size(121, 32);
            chkAddsorse.TabIndex = 3;
            chkAddsorse.Text = "소스 추가";
            chkAddsorse.UseVisualStyleBackColor = true;
            // 
            // chkAddchize
            // 
            chkAddchize.AutoSize = true;
            chkAddchize.Font = new Font("맑은 고딕", 12F);
            chkAddchize.ForeColor = Color.Black;
            chkAddchize.Location = new Point(17, 146);
            chkAddchize.Name = "chkAddchize";
            chkAddchize.Size = new Size(121, 32);
            chkAddchize.TabIndex = 2;
            chkAddchize.Text = "치즈 추가";
            chkAddchize.UseVisualStyleBackColor = true;
            // 
            // chkcola
            // 
            chkcola.AutoSize = true;
            chkcola.Font = new Font("맑은 고딕", 12F);
            chkcola.ForeColor = Color.Black;
            chkcola.Location = new Point(17, 108);
            chkcola.Name = "chkcola";
            chkcola.Size = new Size(74, 32);
            chkcola.TabIndex = 1;
            chkcola.Text = "콜라";
            chkcola.UseVisualStyleBackColor = true;
            // 
            // chkkamti
            // 
            chkkamti.AutoSize = true;
            chkkamti.Font = new Font("맑은 고딕", 12F);
            chkkamti.ForeColor = Color.Black;
            chkkamti.Location = new Point(17, 70);
            chkkamti.Name = "chkkamti";
            chkkamti.Size = new Size(114, 32);
            chkkamti.TabIndex = 0;
            chkkamti.Text = "감자튀김";
            chkkamti.UseVisualStyleBackColor = true;
            // 
            // grbMenuList
            // 
            grbMenuList.Controls.Add(lblStatus);
            grbMenuList.Controls.Add(libMenuList);
            grbMenuList.Font = new Font("맑은 고딕", 18F);
            grbMenuList.ForeColor = Color.Red;
            grbMenuList.Location = new Point(643, 138);
            grbMenuList.Name = "grbMenuList";
            grbMenuList.Size = new Size(269, 315);
            grbMenuList.TabIndex = 3;
            grbMenuList.TabStop = false;
            grbMenuList.Text = "주문 내역";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(64, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(437, 62);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // libMenuList
            // 
            libMenuList.Font = new Font("맑은 고딕", 12F);
            libMenuList.FormattingEnabled = true;
            libMenuList.Location = new Point(15, 46);
            libMenuList.Name = "libMenuList";
            libMenuList.Size = new Size(238, 200);
            libMenuList.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 20F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(768, 495);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(173, 64);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(15, 264);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(140, 31);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "총금액 : 0원";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 613);
            Controls.Add(btnClear);
            Controls.Add(lblTitle);
            Controls.Add(grbMenuList);
            Controls.Add(grbAddMenu);
            Controls.Add(grbMenu);
            Controls.Add(btnOrder);
            Name = "Form1";
            Text = "Form1";
            grbMenu.ResumeLayout(false);
            grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pibChikenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibBeefBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibburger).EndInit();
            grbAddMenu.ResumeLayout(false);
            grbAddMenu.PerformLayout();
            grbMenuList.ResumeLayout(false);
            grbMenuList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrder;
        private GroupBox grbMenu;
        private RadioButton rbtnChikenBurger;
        private RadioButton rbtnBeefBurger;
        private RadioButton rbtnBurger;
        private GroupBox grbAddMenu;
        private GroupBox grbMenuList;
        private PictureBox pibburger;
        private PictureBox pibChikenBurger;
        private PictureBox pibBeefBurger;
        private Label lblTitle;
        private CheckBox chkAddsorse;
        private CheckBox chkAddchize;
        private CheckBox chkcola;
        private CheckBox chkkamti;
        private ListBox libMenuList;
        private Label lblStatus;
        private Button btnClear;
    }
}
