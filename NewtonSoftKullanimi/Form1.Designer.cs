namespace NewtonSoftKullanimi
{
    partial class Form1
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
            this.txtJsonVeriGir = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSerilaze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJsonVeriGir
            // 
            this.txtJsonVeriGir.Location = new System.Drawing.Point(141, 12);
            this.txtJsonVeriGir.Multiline = true;
            this.txtJsonVeriGir.Name = "txtJsonVeriGir";
            this.txtJsonVeriGir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJsonVeriGir.Size = new System.Drawing.Size(300, 172);
            this.txtJsonVeriGir.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(141, 228);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(300, 117);
            this.txtResponse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veri Gir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(174, 190);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Deserilaze";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(255, 190);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSerilaze
            // 
            this.btnSerilaze.Location = new System.Drawing.Point(336, 190);
            this.btnSerilaze.Name = "btnSerilaze";
            this.btnSerilaze.Size = new System.Drawing.Size(75, 23);
            this.btnSerilaze.TabIndex = 6;
            this.btnSerilaze.Text = "Serilaze";
            this.btnSerilaze.UseVisualStyleBackColor = true;
            this.btnSerilaze.Click += new System.EventHandler(this.btnSerilaze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 433);
            this.Controls.Add(this.btnSerilaze);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtJsonVeriGir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJsonVeriGir;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSerilaze;
    }
}

