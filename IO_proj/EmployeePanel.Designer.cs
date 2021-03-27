namespace IO_proj
{
    partial class EmployeePanel
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.partsAssembledTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punkty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.formCreatorGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.formCreatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Punkty nagród";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Przepracowane godziny";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Zarobki";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dodatkowe dni wolne";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(476, 280);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 47);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // partsAssembledTextBox
            // 
            this.partsAssembledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partsAssembledTextBox.Location = new System.Drawing.Point(212, 78);
            this.partsAssembledTextBox.Name = "partsAssembledTextBox";
            this.partsAssembledTextBox.Size = new System.Drawing.Size(100, 23);
            this.partsAssembledTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wytworzone elementy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Czas pracy:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wytworzone elementy:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Location = new System.Drawing.Point(505, 355);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.MinimumWidth = 8;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // elementy
            // 
            this.elementy.HeaderText = "elementy";
            this.elementy.MinimumWidth = 8;
            this.elementy.Name = "elementy";
            this.elementy.ReadOnly = true;
            this.elementy.Width = 150;
            // 
            // norma
            // 
            this.norma.HeaderText = "norma";
            this.norma.MinimumWidth = 8;
            this.norma.Name = "norma";
            this.norma.ReadOnly = true;
            this.norma.Width = 150;
            // 
            // punkty
            // 
            this.punkty.HeaderText = "punkty";
            this.punkty.MinimumWidth = 8;
            this.punkty.Name = "punkty";
            this.punkty.ReadOnly = true;
            this.punkty.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.Size = new System.Drawing.Size(584, 203);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // formCreatorGroupBox
            // 
            this.formCreatorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formCreatorGroupBox.Controls.Add(this.dateTimePicker);
            this.formCreatorGroupBox.Controls.Add(this.partsAssembledTextBox);
            this.formCreatorGroupBox.Controls.Add(this.label1);
            this.formCreatorGroupBox.Controls.Add(this.label2);
            this.formCreatorGroupBox.Location = new System.Drawing.Point(86, 246);
            this.formCreatorGroupBox.Name = "formCreatorGroupBox";
            this.formCreatorGroupBox.Size = new System.Drawing.Size(316, 132);
            this.formCreatorGroupBox.TabIndex = 5;
            this.formCreatorGroupBox.TabStop = false;
            this.formCreatorGroupBox.Text = "Formularz dnia pracy";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(90, 40);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formCreatorGroupBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.saveButton);
            this.Name = "EmployeePanel";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.formCreatorGroupBox.ResumeLayout(false);
            this.formCreatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox partsAssembledTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementy;
        private System.Windows.Forms.DataGridViewTextBoxColumn norma;
        private System.Windows.Forms.DataGridViewTextBoxColumn punkty;
        private System.Windows.Forms.GroupBox formCreatorGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
