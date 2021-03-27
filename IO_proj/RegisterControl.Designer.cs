namespace ProductionManagementSystem
{
    partial class RegisterControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordCfrmTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(414, 453);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(182, 63);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Zarejestruj";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(307, 163);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(473, 47);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.Tag = "Login";
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Location = new System.Drawing.Point(307, 73);
            this.PeselTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(473, 47);
            this.PeselTextBox.TabIndex = 1;
            this.PeselTextBox.Tag = "PESEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "PESEL:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(307, 249);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(473, 47);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Tag = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Potwierdź hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasło:";
            // 
            // PasswordCfrmTextBox
            // 
            this.PasswordCfrmTextBox.Location = new System.Drawing.Point(307, 339);
            this.PasswordCfrmTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PasswordCfrmTextBox.Name = "PasswordCfrmTextBox";
            this.PasswordCfrmTextBox.PasswordChar = '*';
            this.PasswordCfrmTextBox.Size = new System.Drawing.Size(473, 47);
            this.PasswordCfrmTextBox.TabIndex = 1;
            this.PasswordCfrmTextBox.Tag = "Potwierdź hasło";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordCfrmTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeselTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(970, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PeselTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordCfrmTextBox;
    }
}
