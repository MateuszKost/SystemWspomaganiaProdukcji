namespace IO_proj
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.actionButton = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContainer.Controls.Add(this.actionButton, 0, 1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 2;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.mainContainer.Size = new System.Drawing.Size(397, 259);
            this.mainContainer.TabIndex = 0;
            // 
            // actionButton
            // 
            this.actionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionButton.Location = new System.Drawing.Point(6, 228);
            this.actionButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(82, 26);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "Zarejestruj";
            this.actionButton.UseMnemonic = false;
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 259);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(300, 200);
            this.Name = "LoginForm";
            this.Text = "Zaloguj";
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.FormClosed += ExitApp;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Button actionButton;
    }
}

