namespace ProductionManagementSystem
{
    partial class EmployeeManagementPanel
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
            this.moveEmployeeLabel = new System.Windows.Forms.Label();
            this.removeEmployeeLabel = new System.Windows.Forms.Label();
            this.chooseEmployeeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.peselMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.confirmEmployeeButton = new System.Windows.Forms.Button();
            this.confirmedEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeInfoLabel = new System.Windows.Forms.Label();
            this.depNameLabel = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.depChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.moveEmployeeButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveEmployeeLabel
            // 
            this.moveEmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveEmployeeLabel.AutoSize = true;
            this.moveEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveEmployeeLabel.Location = new System.Drawing.Point(49, 263);
            this.moveEmployeeLabel.Name = "moveEmployeeLabel";
            this.moveEmployeeLabel.Size = new System.Drawing.Size(143, 17);
            this.moveEmployeeLabel.TabIndex = 0;
            this.moveEmployeeLabel.Text = "Przenieś do innego działu";
            // 
            // removeEmployeeLabel
            // 
            this.removeEmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeEmployeeLabel.AutoSize = true;
            this.removeEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeEmployeeLabel.Location = new System.Drawing.Point(420, 233);
            this.removeEmployeeLabel.Name = "removeEmployeeLabel";
            this.removeEmployeeLabel.Size = new System.Drawing.Size(91, 17);
            this.removeEmployeeLabel.TabIndex = 0;
            this.removeEmployeeLabel.Text = "Usuń z systemu";
            // 
            // chooseEmployeeLabel
            // 
            this.chooseEmployeeLabel.AutoSize = true;
            this.chooseEmployeeLabel.Location = new System.Drawing.Point(49, 16);
            this.chooseEmployeeLabel.Name = "chooseEmployeeLabel";
            this.chooseEmployeeLabel.Size = new System.Drawing.Size(131, 15);
            this.chooseEmployeeLabel.TabIndex = 1;
            this.chooseEmployeeLabel.Text = "Wpisz dane pracownika";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(101, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.Location = new System.Drawing.Point(101, 72);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 23);
            this.surnameBox.TabIndex = 3;
            // 
            // peselMaskedBox
            // 
            this.peselMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peselMaskedBox.Location = new System.Drawing.Point(101, 101);
            this.peselMaskedBox.Mask = "00000000000";
            this.peselMaskedBox.Name = "peselMaskedBox";
            this.peselMaskedBox.Size = new System.Drawing.Size(100, 23);
            this.peselMaskedBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 15);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(22, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Location = new System.Drawing.Point(22, 104);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(38, 15);
            this.peselLabel.TabIndex = 5;
            this.peselLabel.Text = "PESEL";
            // 
            // confirmEmployeeButton
            // 
            this.confirmEmployeeButton.Location = new System.Drawing.Point(121, 130);
            this.confirmEmployeeButton.Name = "confirmEmployeeButton";
            this.confirmEmployeeButton.Size = new System.Drawing.Size(59, 29);
            this.confirmEmployeeButton.TabIndex = 6;
            this.confirmEmployeeButton.Text = "Ok";
            this.confirmEmployeeButton.UseVisualStyleBackColor = true;
            this.confirmEmployeeButton.Click += new System.EventHandler(this.ConfirmEmployeeData);
            // 
            // confirmedEmployeeLabel
            // 
            this.confirmedEmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmedEmployeeLabel.AutoSize = true;
            this.confirmedEmployeeLabel.Location = new System.Drawing.Point(220, 46);
            this.confirmedEmployeeLabel.Name = "confirmedEmployeeLabel";
            this.confirmedEmployeeLabel.Size = new System.Drawing.Size(263, 15);
            this.confirmedEmployeeLabel.TabIndex = 7;
            this.confirmedEmployeeLabel.Text = "Wprowadzone dane odpowiadają pracownikowi:";
            // 
            // employeeInfoLabel
            // 
            this.employeeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeInfoLabel.AutoSize = true;
            this.employeeInfoLabel.Location = new System.Drawing.Point(220, 75);
            this.employeeInfoLabel.Name = "employeeInfoLabel";
            this.employeeInfoLabel.Size = new System.Drawing.Size(201, 15);
            this.employeeInfoLabel.TabIndex = 8;
            this.employeeInfoLabel.Text = "<Imię><Nazwisko><Pesel><Adres>";
            // 
            // depNameLabel
            // 
            this.depNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depNameLabel.AutoSize = true;
            this.depNameLabel.Location = new System.Drawing.Point(220, 130);
            this.depNameLabel.Name = "depNameLabel";
            this.depNameLabel.Size = new System.Drawing.Size(78, 15);
            this.depNameLabel.TabIndex = 9;
            this.depNameLabel.Text = "Obecny dział:";
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Location = new System.Drawing.Point(304, 130);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(47, 15);
            this.departmentNameLabel.TabIndex = 10;
            this.departmentNameLabel.Text = "<dział>";
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeEmployeeButton.Location = new System.Drawing.Point(394, 297);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(139, 54);
            this.removeEmployeeButton.TabIndex = 11;
            this.removeEmployeeButton.Text = "Usuń pracownika";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton);
            // 
            // depChoiceComboBox
            // 
            this.depChoiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.depChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depChoiceComboBox.FormattingEnabled = true;
            this.depChoiceComboBox.Location = new System.Drawing.Point(64, 294);
            this.depChoiceComboBox.Name = "depChoiceComboBox";
            this.depChoiceComboBox.Size = new System.Drawing.Size(131, 23);
            this.depChoiceComboBox.TabIndex = 12;
            // 
            // moveEmployeeButton
            // 
            this.moveEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveEmployeeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moveEmployeeButton.Location = new System.Drawing.Point(64, 320);
            this.moveEmployeeButton.Name = "moveEmployeeButton";
            this.moveEmployeeButton.Size = new System.Drawing.Size(130, 23);
            this.moveEmployeeButton.TabIndex = 11;
            this.moveEmployeeButton.Text = "Przenieś pracownika";
            this.moveEmployeeButton.UseVisualStyleBackColor = true;
            this.moveEmployeeButton.Click += new System.EventHandler(this.MoveEmployeeButton);
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.warningLabel.Location = new System.Drawing.Point(358, 354);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(208, 15);
            this.warningLabel.TabIndex = 13;
            this.warningLabel.Text = "Uwaga! Tej operacji nie można cofnąć.";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(394, 250);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(142, 15);
            this.label34.TabIndex = 14;
            this.label34.Text = "Odbiera prawa logowania";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dane pracownika zostają";
            // 
            // EmployeeManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.moveEmployeeButton);
            this.Controls.Add(this.depChoiceComboBox);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.departmentNameLabel);
            this.Controls.Add(this.depNameLabel);
            this.Controls.Add(this.employeeInfoLabel);
            this.Controls.Add(this.confirmedEmployeeLabel);
            this.Controls.Add(this.confirmEmployeeButton);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peselMaskedBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.chooseEmployeeLabel);
            this.Controls.Add(this.removeEmployeeLabel);
            this.Controls.Add(this.moveEmployeeLabel);
            this.Name = "EmployeeManagementPanel";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moveEmployeeLabel;
        private System.Windows.Forms.Label removeEmployeeLabel;
        private System.Windows.Forms.Label chooseEmployeeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.MaskedTextBox peselMaskedBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Button confirmEmployeeButton;
        private System.Windows.Forms.Label confirmedEmployeeLabel;
        private System.Windows.Forms.Label employeeInfoLabel;
        private System.Windows.Forms.Label depNameLabel;
        private System.Windows.Forms.Label getDepartmentNameLabel;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.ComboBox depChoiceComboBox;
        private System.Windows.Forms.Button moveEmployeeButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label departmentNameLabel;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label1;
    }
}
