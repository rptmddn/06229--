namespace The_Nuts.BalzuForm
{
    partial class BalzuIngForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.balzuUserControl4 = new The_Nuts.BalzuForm.BalzuUserControl();
            this.balzuUserControl3 = new The_Nuts.BalzuForm.BalzuUserControl();
            this.balzuUserControl2 = new The_Nuts.BalzuForm.BalzuUserControl();
            this.balzuUserControl1 = new The_Nuts.BalzuForm.BalzuUserControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.balzuUserControl4);
            this.panel1.Controls.Add(this.balzuUserControl3);
            this.panel1.Controls.Add(this.balzuUserControl2);
            this.panel1.Controls.Add(this.balzuUserControl1);
            this.panel1.Location = new System.Drawing.Point(42, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 473);
            this.panel1.TabIndex = 0;
            // 
            // balzuUserControl4
            // 
            this.balzuUserControl4.Location = new System.Drawing.Point(511, 238);
            this.balzuUserControl4.Name = "balzuUserControl4";
            this.balzuUserControl4.Size = new System.Drawing.Size(341, 217);
            this.balzuUserControl4.TabIndex = 3;
            // 
            // balzuUserControl3
            // 
            this.balzuUserControl3.Location = new System.Drawing.Point(37, 238);
            this.balzuUserControl3.Name = "balzuUserControl3";
            this.balzuUserControl3.Size = new System.Drawing.Size(341, 217);
            this.balzuUserControl3.TabIndex = 2;
            // 
            // balzuUserControl2
            // 
            this.balzuUserControl2.Location = new System.Drawing.Point(511, 15);
            this.balzuUserControl2.Name = "balzuUserControl2";
            this.balzuUserControl2.Size = new System.Drawing.Size(341, 217);
            this.balzuUserControl2.TabIndex = 1;
            // 
            // balzuUserControl1
            // 
            this.balzuUserControl1.Location = new System.Drawing.Point(37, 15);
            this.balzuUserControl1.Name = "balzuUserControl1";
            this.balzuUserControl1.Size = new System.Drawing.Size(341, 217);
            this.balzuUserControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "발주서보기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "발주";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BalzuIngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "BalzuIngForm";
            this.Text = "BalzuIngForm";
            this.Load += new System.EventHandler(this.BalzuIngForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private BalzuUserControl balzuUserControl4;
        private BalzuUserControl balzuUserControl3;
        private BalzuUserControl balzuUserControl2;
        private BalzuUserControl balzuUserControl1;
    }
}