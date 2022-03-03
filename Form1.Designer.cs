namespace Ex7_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入跑馬燈文字：";
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShow.Location = new System.Drawing.Point(214, 19);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(309, 36);
            this.txtShow.TabIndex = 1;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(25, 171);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(86, 40);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "左移";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(124, 171);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(86, 40);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "右移";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(228, 171);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 40);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "暫停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(333, 171);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(85, 40);
            this.btnFast.TabIndex = 6;
            this.btnFast.Text = "加快";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(436, 171);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(87, 40);
            this.btnSlow.TabIndex = 7;
            this.btnSlow.Text = "減慢";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // ShowText
            // 
            this.ShowText.AutoEllipsis = true;
            this.ShowText.BackColor = System.Drawing.Color.Black;
            this.ShowText.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowText.ForeColor = System.Drawing.Color.Red;
            this.ShowText.Location = new System.Drawing.Point(-300, 0);
            this.ShowText.Margin = new System.Windows.Forms.Padding(0);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(1141, 80);
            this.ShowText.TabIndex = 8;
            this.ShowText.Text = "測試中....";
            this.ShowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowText);
            this.panel1.Location = new System.Drawing.Point(25, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 80);
            this.panel1.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "跑馬燈";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Label ShowText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
    }
}

