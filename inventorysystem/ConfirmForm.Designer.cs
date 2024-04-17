namespace inventorysystem
{
    partial class ConfirmForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.confirm_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 271);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 26);
            this.panel2.TabIndex = 70;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // clear_btn
            // 
            this.clear_btn.ActiveBorderThickness = 1;
            this.clear_btn.ActiveCornerRadius = 20;
            this.clear_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.clear_btn.ActiveForecolor = System.Drawing.Color.White;
            this.clear_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.clear_btn.BackColor = System.Drawing.Color.Silver;
            this.clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_btn.BackgroundImage")));
            this.clear_btn.ButtonText = "ClearOrder";
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.clear_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.clear_btn.IdleBorderThickness = 1;
            this.clear_btn.IdleCornerRadius = 20;
            this.clear_btn.IdleFillColor = System.Drawing.Color.White;
            this.clear_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.clear_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.clear_btn.Location = new System.Drawing.Point(348, 360);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(78, 39);
            this.clear_btn.TabIndex = 97;
            this.clear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.ActiveBorderThickness = 1;
            this.confirm_btn.ActiveCornerRadius = 20;
            this.confirm_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.confirm_btn.ActiveForecolor = System.Drawing.Color.White;
            this.confirm_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.confirm_btn.BackColor = System.Drawing.Color.Silver;
            this.confirm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_btn.BackgroundImage")));
            this.confirm_btn.ButtonText = "ConfirmOrder";
            this.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.confirm_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirm_btn.IdleBorderThickness = 1;
            this.confirm_btn.IdleCornerRadius = 20;
            this.confirm_btn.IdleFillColor = System.Drawing.Color.White;
            this.confirm_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.confirm_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.confirm_btn.Location = new System.Drawing.Point(458, 360);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(88, 39);
            this.confirm_btn.TabIndex = 98;
            this.confirm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 117;
            this.label10.Text = "Hello";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(84, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 116;
            this.label9.Text = "userid";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 410);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmForm";
            this.Text = "ConfirmForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 confirm_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 clear_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}