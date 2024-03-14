namespace PartsSelling.Forms
{
    partial class CaptchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchForm));
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbCaptch = new System.Windows.Forms.TextBox();
            this.pbCaptch = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(45, 505);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(322, 50);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "ПОДТВЕРДИТЬ ВВОД";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbCaptch
            // 
            this.tbCaptch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCaptch.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCaptch.Location = new System.Drawing.Point(48, 440);
            this.tbCaptch.MaxLength = 20;
            this.tbCaptch.Multiline = true;
            this.tbCaptch.Name = "tbCaptch";
            this.tbCaptch.Size = new System.Drawing.Size(315, 40);
            this.tbCaptch.TabIndex = 9;
            // 
            // pbCaptch
            // 
            this.pbCaptch.Location = new System.Drawing.Point(43, 106);
            this.pbCaptch.Name = "pbCaptch";
            this.pbCaptch.Size = new System.Drawing.Size(325, 255);
            this.pbCaptch.TabIndex = 11;
            this.pbCaptch.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(308, 19);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(351, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 580);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbCaptch);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbCaptch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.Text = "CaptchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbCaptch;
        private System.Windows.Forms.PictureBox pbCaptch;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}