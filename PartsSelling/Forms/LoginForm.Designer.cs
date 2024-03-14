namespace PartsSelling
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pbMotorOil = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnRemember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorOil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMotorOil
            // 
            this.pbMotorOil.BackColor = System.Drawing.Color.Transparent;
            this.pbMotorOil.Image = ((System.Drawing.Image)(resources.GetObject("pbMotorOil.Image")));
            this.pbMotorOil.Location = new System.Drawing.Point(916, 325);
            this.pbMotorOil.Name = "pbMotorOil";
            this.pbMotorOil.Size = new System.Drawing.Size(145, 164);
            this.pbMotorOil.TabIndex = 0;
            this.pbMotorOil.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1034, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(992, 16);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(693, 503);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(322, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ВОЙТИ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(699, 237);
            this.tbLogin.MaxLength = 20;
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(315, 40);
            this.tbLogin.TabIndex = 4;
            this.tbLogin.Text = "naumovaa";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(699, 331);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(315, 40);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "XHYMDz";
            // 
            // btnRemember
            // 
            this.btnRemember.BackColor = System.Drawing.Color.Transparent;
            this.btnRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemember.FlatAppearance.BorderSize = 0;
            this.btnRemember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemember.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemember.ForeColor = System.Drawing.Color.White;
            this.btnRemember.Location = new System.Drawing.Point(697, 411);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(15, 16);
            this.btnRemember.TabIndex = 6;
            this.btnRemember.UseVisualStyleBackColor = false;
            this.btnRemember.Click += new System.EventHandler(this.btnRemember_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnRemember);
            this.Controls.Add(this.pbMotorOil);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pbMotorOil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMotorOil;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRemember;
    }
}

