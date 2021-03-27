namespace IO_proj
{
    partial class FacilityManagerPanel
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.departmentsListGridView = new System.Windows.Forms.DataGridView();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.depStatsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.partsPerEmpCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.partsPerMonthCountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.partsProducedCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Location = new System.Drawing.Point(500, 348);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // departmentsListGridView
            // 
            this.departmentsListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentsListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsListGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.departmentsListGridView.Location = new System.Drawing.Point(20, 17);
            this.departmentsListGridView.Name = "departmentsListGridView";
            this.departmentsListGridView.RowHeadersVisible = false;
            this.departmentsListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.departmentsListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentsListGridView.Size = new System.Drawing.Size(120, 149);
            this.departmentsListGridView.TabIndex = 2;
            this.departmentsListGridView.Text = "dataGridView1";
            this.departmentsListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsListGridView_CellClick);
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Location = new System.Drawing.Point(160, 17);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.RowHeadersVisible = false;
            this.employeeListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeListGridView.Size = new System.Drawing.Size(415, 149);
            this.employeeListGridView.TabIndex = 0;
            this.employeeListGridView.Text = "dataGridView1";
            // 
            // depStatsLabel
            // 
            this.depStatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.depStatsLabel.AutoSize = true;
            this.depStatsLabel.Location = new System.Drawing.Point(16, 218);
            this.depStatsLabel.Name = "depStatsLabel";
            this.depStatsLabel.Size = new System.Drawing.Size(153, 15);
            this.depStatsLabel.TabIndex = 4;
            this.depStatsLabel.Text = "Statystyki wybranego działu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mój dział:";
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Location = new System.Drawing.Point(77, 25);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(47, 15);
            this.departmentNameLabel.TabIndex = 2;
            this.departmentNameLabel.Text = "<dział>";
            // 
            // partsPerEmpCountLabel
            // 
            this.partsPerEmpCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsPerEmpCountLabel.AutoSize = true;
            this.partsPerEmpCountLabel.Location = new System.Drawing.Point(167, 76);
            this.partsPerEmpCountLabel.Name = "partsPerEmpCountLabel";
            this.partsPerEmpCountLabel.Size = new System.Drawing.Size(47, 15);
            this.partsPerEmpCountLabel.TabIndex = 2;
            this.partsPerEmpCountLabel.Text = "<ilość>";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ilość części na pracownika:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ilość części na miesiąc:";
            // 
            // partsPerMonthCountLabel
            // 
            this.partsPerMonthCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsPerMonthCountLabel.AutoSize = true;
            this.partsPerMonthCountLabel.Location = new System.Drawing.Point(167, 50);
            this.partsPerMonthCountLabel.Name = "partsPerMonthCountLabel";
            this.partsPerMonthCountLabel.Size = new System.Drawing.Size(47, 15);
            this.partsPerMonthCountLabel.TabIndex = 2;
            this.partsPerMonthCountLabel.Text = "<ilość>";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departmentNameLabel);
            this.groupBox1.Controls.Add(this.partsPerEmpCountLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.partsPerMonthCountLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Stan na dzień dzisiejszy:";
            // 
            // partsProducedCountLabel
            // 
            this.partsProducedCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsProducedCountLabel.AutoSize = true;
            this.partsProducedCountLabel.Location = new System.Drawing.Point(147, 50);
            this.partsProducedCountLabel.Name = "partsProducedCountLabel";
            this.partsProducedCountLabel.Size = new System.Drawing.Size(47, 15);
            this.partsProducedCountLabel.TabIndex = 5;
            this.partsProducedCountLabel.Text = "<ilość>";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Wyprodukowano części:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.partsProducedCountLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(251, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // FacilityManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depStatsLabel);
            this.Controls.Add(this.departmentsListGridView);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.employeeListGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FacilityManagerPanel";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView employeeListGridView;
        private System.Windows.Forms.Button logOutButton;       
        private System.Windows.Forms.DataGridView departmentsListGridView;
        private System.Windows.Forms.Label depStatsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label departmentNameLabel;
        private System.Windows.Forms.Label partsPerEmpCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label partsPerMonthCountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label partsProducedCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
