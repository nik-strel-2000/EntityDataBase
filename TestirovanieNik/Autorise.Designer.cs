namespace TestirovanieNik
{
    partial class Autorise
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
            this.SingInBt = new System.Windows.Forms.Button();
            this.LoginTx = new System.Windows.Forms.TextBox();
            this.PasswordTx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SingInBt
            // 
            this.SingInBt.Location = new System.Drawing.Point(218, 303);
            this.SingInBt.Name = "SingInBt";
            this.SingInBt.Size = new System.Drawing.Size(94, 29);
            this.SingInBt.TabIndex = 0;
            this.SingInBt.Text = "Войти";
            this.SingInBt.UseVisualStyleBackColor = true;
            this.SingInBt.Click += new System.EventHandler(this.SingInBt_Click);
            // 
            // LoginTx
            // 
            this.LoginTx.Location = new System.Drawing.Point(186, 165);
            this.LoginTx.Name = "LoginTx";
            this.LoginTx.PlaceholderText = "Логин";
            this.LoginTx.Size = new System.Drawing.Size(158, 27);
            this.LoginTx.TabIndex = 1;
            // 
            // PasswordTx
            // 
            this.PasswordTx.Location = new System.Drawing.Point(186, 239);
            this.PasswordTx.Name = "PasswordTx";
            this.PasswordTx.PasswordChar = '*';
            this.PasswordTx.PlaceholderText = "Пароль";
            this.PasswordTx.Size = new System.Drawing.Size(158, 27);
            this.PasswordTx.TabIndex = 2;
            // 
            // Autorise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 510);
            this.Controls.Add(this.PasswordTx);
            this.Controls.Add(this.LoginTx);
            this.Controls.Add(this.SingInBt);
            this.Name = "Autorise";
            this.Text = "Autorise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SingInBt;
        private TextBox LoginTx;
        private TextBox PasswordTx;
    }
}