namespace YardimEli
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.labelYardimEli = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoEllipsis = true;
            this.btnLogIn.Location = new System.Drawing.Point(273, 266);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(96, 41);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Giriş Yap";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(396, 266);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(96, 41);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Kayıt Ol";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // labelYardimEli
            // 
            this.labelYardimEli.AutoSize = true;
            this.labelYardimEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYardimEli.Location = new System.Drawing.Point(223, 52);
            this.labelYardimEli.Name = "labelYardimEli";
            this.labelYardimEli.Size = new System.Drawing.Size(311, 69);
            this.labelYardimEli.TabIndex = 2;
            this.labelYardimEli.Text = "Yardım Eli";
            // 
            // tbxUserName
            // 
            this.tbxUserName.ForeColor = System.Drawing.Color.Gray;
            this.tbxUserName.Location = new System.Drawing.Point(273, 187);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(219, 22);
            this.tbxUserName.TabIndex = 3;
            this.tbxUserName.Text = "Kullanıcı adı";
            // 
            // tbxPassword
            // 
            this.tbxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbxPassword.Location = new System.Drawing.Point(273, 226);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(219, 22);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.labelYardimEli);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnLogIn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label labelYardimEli;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
    }
}

