namespace Sport
{
    partial class Authorization
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEnterGuest = new System.Windows.Forms.Button();
            this.tbCaptcha = new System.Windows.Forms.TextBox();
            this.lbC1 = new System.Windows.Forms.Label();
            this.lbC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(154, 20);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(145, 26);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "loginDEjrm2018";
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(154, 60);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "Cpb+Im";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(21, 151);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(115, 34);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEnterGuest
            // 
            this.btnEnterGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnterGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterGuest.Location = new System.Drawing.Point(142, 151);
            this.btnEnterGuest.Name = "btnEnterGuest";
            this.btnEnterGuest.Size = new System.Drawing.Size(168, 34);
            this.btnEnterGuest.TabIndex = 3;
            this.btnEnterGuest.Text = "Войти как гость";
            this.btnEnterGuest.UseVisualStyleBackColor = false;
            // 
            // tbCaptcha
            // 
            this.tbCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCaptcha.Location = new System.Drawing.Point(201, 106);
            this.tbCaptcha.Name = "tbCaptcha";
            this.tbCaptcha.Size = new System.Drawing.Size(98, 26);
            this.tbCaptcha.TabIndex = 4;
            this.tbCaptcha.Visible = false;
            // 
            // lbC1
            // 
            this.lbC1.AutoSize = true;
            this.lbC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC1.Location = new System.Drawing.Point(128, 109);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(29, 20);
            this.lbC1.TabIndex = 5;
            this.lbC1.Text = "p1";
            this.lbC1.Visible = false;
            this.lbC1.Click += new System.EventHandler(this.tbCaptcha_Click);
            // 
            // lbC2
            // 
            this.lbC2.AutoSize = true;
            this.lbC2.BackColor = System.Drawing.Color.Transparent;
            this.lbC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC2.Location = new System.Drawing.Point(150, 106);
            this.lbC2.Name = "lbC2";
            this.lbC2.Size = new System.Drawing.Size(29, 20);
            this.lbC2.TabIndex = 5;
            this.lbC2.Text = "p2";
            this.lbC2.Visible = false;
            this.lbC2.Click += new System.EventHandler(this.tbCaptcha_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 202);
            this.Controls.Add(this.lbC2);
            this.Controls.Add(this.lbC1);
            this.Controls.Add(this.tbCaptcha);
            this.Controls.Add(this.btnEnterGuest);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEnterGuest;
        private System.Windows.Forms.TextBox tbCaptcha;
        private System.Windows.Forms.Label lbC1;
        private System.Windows.Forms.Label lbC2;
    }
}

