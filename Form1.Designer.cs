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
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grbAddMenu = new GroupBox();
            chkSause = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grbMenuList = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            lblAppName = new Label();
            btnClear = new Button();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
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
            btnOrder.Click += btnOrder_Click;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(picChickenBurger);
            grbMenu.Controls.Add(picBulgogiBurger);
            grbMenu.Controls.Add(picHamBurger);
            grbMenu.Controls.Add(rdoChickenBurger);
            grbMenu.Controls.Add(rdoBulgogiBurger);
            grbMenu.Controls.Add(rdoHamBurger);
            grbMenu.Font = new Font("맑은 고딕", 18F);
            grbMenu.ForeColor = Color.Red;
            grbMenu.Location = new Point(64, 138);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(313, 421);
            grbMenu.TabIndex = 1;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴 선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = Properties.Resources.치킨버거;
            picChickenBurger.Location = new Point(180, 287);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(111, 102);
            picChickenBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picChickenBurger.TabIndex = 5;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = Properties.Resources.불고기버거;
            picBulgogiBurger.Location = new Point(180, 162);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(111, 102);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(180, 38);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(111, 102);
            picHamBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picHamBurger.TabIndex = 3;
            picHamBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 15F);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(19, 313);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(136, 39);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 15F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(19, 186);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(161, 39);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AllowDrop = true;
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 15F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(19, 67);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(111, 39);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grbAddMenu
            // 
            grbAddMenu.Controls.Add(chkSause);
            grbAddMenu.Controls.Add(chkCheese);
            grbAddMenu.Controls.Add(chkCola);
            grbAddMenu.Controls.Add(chkPotato);
            grbAddMenu.Font = new Font("맑은 고딕", 18F);
            grbAddMenu.ForeColor = Color.Red;
            grbAddMenu.Location = new Point(407, 138);
            grbAddMenu.Name = "grbAddMenu";
            grbAddMenu.Size = new Size(178, 315);
            grbAddMenu.TabIndex = 2;
            grbAddMenu.TabStop = false;
            grbAddMenu.Text = "추가 메뉴";
            // 
            // chkSause
            // 
            chkSause.AutoSize = true;
            chkSause.Font = new Font("맑은 고딕", 15F);
            chkSause.ForeColor = Color.Black;
            chkSause.Location = new Point(17, 253);
            chkSause.Name = "chkSause";
            chkSause.Size = new Size(146, 39);
            chkSause.TabIndex = 3;
            chkSause.Text = "소스 추가";
            chkSause.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 15F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(17, 192);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(146, 39);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 15F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(17, 131);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(87, 39);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 15F);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(17, 70);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(137, 39);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grbMenuList
            // 
            grbMenuList.Controls.Add(lblTotalCost);
            grbMenuList.Controls.Add(lstOrder);
            grbMenuList.Font = new Font("맑은 고딕", 18F);
            grbMenuList.ForeColor = Color.Red;
            grbMenuList.Location = new Point(614, 138);
            grbMenuList.Name = "grbMenuList";
            grbMenuList.Size = new Size(298, 332);
            grbMenuList.TabIndex = 3;
            grbMenuList.TabStop = false;
            grbMenuList.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(15, 284);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(148, 31);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 14F);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(15, 46);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(264, 221);
            lstOrder.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(64, 36);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(437, 62);
            lblAppName.TabIndex = 4;
            lblAppName.Text = "버거 주문 키오스크";
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
            btnClear.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 613);
            Controls.Add(btnClear);
            Controls.Add(lblAppName);
            Controls.Add(grbMenuList);
            Controls.Add(grbAddMenu);
            Controls.Add(grbMenu);
            Controls.Add(btnOrder);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grbMenu.ResumeLayout(false);
            grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
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
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private GroupBox grbAddMenu;
        private GroupBox grbMenuList;
        private PictureBox picHamBurger;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private Label lblAppName;
        private CheckBox chkSause;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnClear;
    }
}
