namespace The_Nuts
{
    partial class TheNutsMainFrm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheNutsMainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slide1 = new System.Windows.Forms.Panel();
            this.slide2 = new System.Windows.Forms.Panel();
            this.btnBalzu = new System.Windows.Forms.Button();
            this.btnBOM = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnMetrial = new System.Windows.Forms.Button();
            this.btnMetrialManeger = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnProductManeger = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.slide1.SuspendLayout();
            this.slide2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 72);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(1263, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(24, 20);
            this.btnclose.TabIndex = 7;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Nuts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(214)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.slide1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnProductManeger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 668);
            this.panel2.TabIndex = 4;
            // 
            // slide1
            // 
            this.slide1.Controls.Add(this.slide2);
            this.slide1.Controls.Add(this.btnCompany);
            this.slide1.Controls.Add(this.btnMetrial);
            this.slide1.Controls.Add(this.btnMetrialManeger);
            this.slide1.Location = new System.Drawing.Point(0, 30);
            this.slide1.Name = "slide1";
            this.slide1.Size = new System.Drawing.Size(140, 587);
            this.slide1.TabIndex = 1;
            // 
            // slide2
            // 
            this.slide2.AutoSize = true;
            this.slide2.Controls.Add(this.btnBalzu);
            this.slide2.Controls.Add(this.btnBOM);
            this.slide2.Location = new System.Drawing.Point(0, 30);
            this.slide2.Name = "slide2";
            this.slide2.Size = new System.Drawing.Size(140, 486);
            this.slide2.TabIndex = 0;
            // 
            // btnBalzu
            // 
            this.btnBalzu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBalzu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalzu.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBalzu.ForeColor = System.Drawing.Color.Black;
            this.btnBalzu.Location = new System.Drawing.Point(0, 30);
            this.btnBalzu.Name = "btnBalzu";
            this.btnBalzu.Size = new System.Drawing.Size(140, 30);
            this.btnBalzu.TabIndex = 8;
            this.btnBalzu.Text = "발주관리";
            this.btnBalzu.UseVisualStyleBackColor = false;
            this.btnBalzu.Click += new System.EventHandler(this.BalzuManager_Click);
            // 
            // btnBOM
            // 
            this.btnBOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBOM.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBOM.ForeColor = System.Drawing.Color.Black;
            this.btnBOM.Location = new System.Drawing.Point(0, 0);
            this.btnBOM.Name = "btnBOM";
            this.btnBOM.Size = new System.Drawing.Size(140, 30);
            this.btnBOM.TabIndex = 9;
            this.btnBOM.Text = "BOM관리";
            this.btnBOM.UseVisualStyleBackColor = false;
            this.btnBOM.Click += new System.EventHandler(this.lblBOM_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatAppearance.BorderSize = 0;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCompany.ForeColor = System.Drawing.Color.Black;
            this.btnCompany.Location = new System.Drawing.Point(0, 60);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(140, 30);
            this.btnCompany.TabIndex = 11;
            this.btnCompany.Text = "거래처관리";
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnMetrial
            // 
            this.btnMetrial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMetrial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetrial.FlatAppearance.BorderSize = 0;
            this.btnMetrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetrial.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMetrial.ForeColor = System.Drawing.Color.Black;
            this.btnMetrial.Location = new System.Drawing.Point(0, 30);
            this.btnMetrial.Name = "btnMetrial";
            this.btnMetrial.Size = new System.Drawing.Size(140, 30);
            this.btnMetrial.TabIndex = 3;
            this.btnMetrial.Text = "원재료관리";
            this.btnMetrial.UseVisualStyleBackColor = false;
            this.btnMetrial.Click += new System.EventHandler(this.btnMetrial_Click);
            // 
            // btnMetrialManeger
            // 
            this.btnMetrialManeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMetrialManeger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetrialManeger.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMetrialManeger.ForeColor = System.Drawing.Color.Black;
            this.btnMetrialManeger.Location = new System.Drawing.Point(0, 0);
            this.btnMetrialManeger.Name = "btnMetrialManeger";
            this.btnMetrialManeger.Size = new System.Drawing.Size(140, 30);
            this.btnMetrialManeger.TabIndex = 4;
            this.btnMetrialManeger.Text = "원재료/거래처";
            this.btnMetrialManeger.UseVisualStyleBackColor = false;
            this.btnMetrialManeger.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Location = new System.Drawing.Point(0, 60);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(140, 30);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "제품관리";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.ProductMG_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(0, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "생산";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnProductCr_Click);
            // 
            // btnProductManeger
            // 
            this.btnProductManeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProductManeger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductManeger.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProductManeger.ForeColor = System.Drawing.Color.Black;
            this.btnProductManeger.Location = new System.Drawing.Point(0, 0);
            this.btnProductManeger.Name = "btnProductManeger";
            this.btnProductManeger.Size = new System.Drawing.Size(140, 30);
            this.btnProductManeger.TabIndex = 0;
            this.btnProductManeger.Text = "생산관리";
            this.btnProductManeger.UseVisualStyleBackColor = false;
            this.btnProductManeger.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // TheNutsMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TheNutsMainFrm";
            this.Text = "The Nuts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.slide1.ResumeLayout(false);
            this.slide1.PerformLayout();
            this.slide2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel slide1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnProductManeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel slide2;
        private System.Windows.Forms.Button btnMetrial;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnMetrialManeger;
        private System.Windows.Forms.Button btnBalzu;
        private System.Windows.Forms.Button btnBOM;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnclose;
    }
}

