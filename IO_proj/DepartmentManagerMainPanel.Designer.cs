namespace ProductionManagementSystem
{
    partial class DepartmentManagerMainPanel
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
            this.myDepartmentLabel = new System.Windows.Forms.Label();
            this.partsPerMonthLabel = new System.Windows.Forms.Label();
            this.partsPerEmpLabel = new System.Windows.Forms.Label();
            this.partsPerMonthCountLabel = new System.Windows.Forms.Label();
            this.myDepartmentNameLabel = new System.Windows.Forms.Label();
            this.partsPerEmpCountLabel = new System.Windows.Forms.Label();
            this.currentDayStatusLabel = new System.Windows.Forms.Label();
            this.partsProducedLabel = new System.Windows.Forms.Label();
            this.partsProducedCountLabel = new System.Windows.Forms.Label();
            this.currentStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.departmentStatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.currentStatusGroupBox.SuspendLayout();
            this.departmentStatisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDepartmentLabel
            // 
            this.myDepartmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myDepartmentLabel.AutoSize = true;
            this.myDepartmentLabel.Location = new System.Drawing.Point(13, 25);
            this.myDepartmentLabel.Name = "myDepartmentLabel";
            this.myDepartmentLabel.Size = new System.Drawing.Size(58, 15);
            this.myDepartmentLabel.TabIndex = 1;
            this.myDepartmentLabel.Text = "Mój dział:";
            // 
            // partsPerMonthLabel
            // 
            this.partsPerMonthLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsPerMonthLabel.AutoSize = true;
            this.partsPerMonthLabel.Location = new System.Drawing.Point(12, 50);
            this.partsPerMonthLabel.Name = "partsPerMonthLabel";
            this.partsPerMonthLabel.Size = new System.Drawing.Size(127, 15);
            this.partsPerMonthLabel.TabIndex = 1;
            this.partsPerMonthLabel.Text = "Ilość części na miesiąc:";
            // 
            // partsPerEmpLabel
            // 
            this.partsPerEmpLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsPerEmpLabel.AutoSize = true;
            this.partsPerEmpLabel.Location = new System.Drawing.Point(13, 76);
            this.partsPerEmpLabel.Name = "partsPerEmpLabel";
            this.partsPerEmpLabel.Size = new System.Drawing.Size(148, 15);
            this.partsPerEmpLabel.TabIndex = 1;
            this.partsPerEmpLabel.Text = "Ilość części na pracownika:";
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
            // myDepartmentNameLabel
            // 
            this.myDepartmentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myDepartmentNameLabel.AutoSize = true;
            this.myDepartmentNameLabel.Location = new System.Drawing.Point(77, 25);
            this.myDepartmentNameLabel.Name = "myDepartmentNameLabel";
            this.myDepartmentNameLabel.Size = new System.Drawing.Size(47, 15);
            this.myDepartmentNameLabel.TabIndex = 2;
            this.myDepartmentNameLabel.Text = "<dział>";
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
            // currentDayStatusLabel
            // 
            this.currentDayStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentDayStatusLabel.AutoSize = true;
            this.currentDayStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentDayStatusLabel.Location = new System.Drawing.Point(6, 16);
            this.currentDayStatusLabel.Name = "currentDayStatusLabel";
            this.currentDayStatusLabel.Size = new System.Drawing.Size(175, 20);
            this.currentDayStatusLabel.TabIndex = 3;
            this.currentDayStatusLabel.Text = "Stan na dzień dzisiejszy:";
            // 
            // partsProducedLabel
            // 
            this.partsProducedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsProducedLabel.AutoSize = true;
            this.partsProducedLabel.Location = new System.Drawing.Point(6, 50);
            this.partsProducedLabel.Name = "partsProducedLabel";
            this.partsProducedLabel.Size = new System.Drawing.Size(135, 15);
            this.partsProducedLabel.TabIndex = 4;
            this.partsProducedLabel.Text = "Wyprodukowano części:";
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
            // currentStatusGroupBox
            // 
            this.currentStatusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentStatusGroupBox.Controls.Add(this.currentDayStatusLabel);
            this.currentStatusGroupBox.Controls.Add(this.partsProducedCountLabel);
            this.currentStatusGroupBox.Controls.Add(this.partsProducedLabel);
            this.currentStatusGroupBox.Location = new System.Drawing.Point(255, 245);
            this.currentStatusGroupBox.Name = "currentStatusGroupBox";
            this.currentStatusGroupBox.Size = new System.Drawing.Size(200, 135);
            this.currentStatusGroupBox.TabIndex = 6;
            this.currentStatusGroupBox.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Location = new System.Drawing.Point(511, 357);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // departmentStatisticsGroupBox
            // 
            this.departmentStatisticsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentStatisticsGroupBox.Controls.Add(this.myDepartmentLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.myDepartmentNameLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerEmpCountLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerEmpLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerMonthLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerMonthCountLabel);
            this.departmentStatisticsGroupBox.Location = new System.Drawing.Point(20, 245);
            this.departmentStatisticsGroupBox.Name = "departmentStatisticsGroupBox";
            this.departmentStatisticsGroupBox.Size = new System.Drawing.Size(229, 135);
            this.departmentStatisticsGroupBox.TabIndex = 7;
            this.departmentStatisticsGroupBox.TabStop = false;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(11, 11);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.RowHeadersWidth = 62;
            this.employeesDataGridView.Size = new System.Drawing.Size(575, 200);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.Text = "dataGridView1";
            // 
            // DepartmentManagerMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.departmentStatisticsGroupBox);
            this.Controls.Add(this.currentStatusGroupBox);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "DepartmentManagerMainPanel";
            this.Size = new System.Drawing.Size(600, 400);
            this.currentStatusGroupBox.ResumeLayout(false);
            this.currentStatusGroupBox.PerformLayout();
            this.departmentStatisticsGroupBox.ResumeLayout(false);
            this.departmentStatisticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label myDepartmentLabel;
        private System.Windows.Forms.Label partsPerMonthLabel;
        private System.Windows.Forms.Label partsPerEmpLabel;
        private System.Windows.Forms.Label partsPerMonthCountLabel;
        private System.Windows.Forms.Label myDepartmentNameLabel;
        private System.Windows.Forms.Label partsPerEmpCountLabel;
        private System.Windows.Forms.Label currentDayStatusLabel;
        private System.Windows.Forms.Label partsProducedLabel;
        private System.Windows.Forms.Label partsProducedCountLabel;
        private System.Windows.Forms.GroupBox currentStatusGroupBox;
        private System.Windows.Forms.GroupBox departmentStatisticsGroupBox;
        private System.Windows.Forms.Button logOutButton;
    }
}
