namespace The_Nuts
{
    partial class ProductControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.txtProCnt = new System.Windows.Forms.TextBox();
            this.lblMadeday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "제품 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "제품 가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "제품 수량";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(200, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "생산 담기";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Location = new System.Drawing.Point(198, 16);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(38, 12);
            this.lblProName.TabIndex = 11;
            this.lblProName.Text = "label5";
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(198, 55);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(38, 12);
            this.lblProPrice.TabIndex = 12;
            this.lblProPrice.Text = "label6";
            // 
            // txtProCnt
            // 
            this.txtProCnt.Location = new System.Drawing.Point(198, 130);
            this.txtProCnt.Name = "txtProCnt";
            this.txtProCnt.Size = new System.Drawing.Size(84, 21);
            this.txtProCnt.TabIndex = 14;
            // 
            // lblMadeday
            // 
            this.lblMadeday.AutoSize = true;
            this.lblMadeday.Location = new System.Drawing.Point(198, 94);
            this.lblMadeday.Name = "lblMadeday";
            this.lblMadeday.Size = new System.Drawing.Size(65, 12);
            this.lblMadeday.TabIndex = 17;
            this.lblMadeday.Text = "2020-06-25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "제품 코드";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDetail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(40, 177);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(84, 31);
            this.btnDetail.TabIndex = 15;
            this.btnDetail.Text = "상세 보기";
            this.btnDetail.UseVisualStyleBackColor = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMadeday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.txtProCnt);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(329, 211);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.TextBox txtProCnt;
        private System.Windows.Forms.Label lblMadeday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDetail;
    }
}
