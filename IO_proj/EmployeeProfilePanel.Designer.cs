using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ProductionManagementSystem
{
    partial class EmployeeProfilePanel
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelCurrentUserPoints = new System.Windows.Forms.Label();
            this.userDataListNames = new System.Windows.Forms.ListBox();
            this.userDataListValues = new System.Windows.Forms.ListBox();
            this.prizePicker = new System.Windows.Forms.ComboBox();
            this.getPrizeButton = new System.Windows.Forms.Button();
            this.prizeInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(182, 118);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(131, 15);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Ilość punktów na dzień:";
            // 
            // labelToday
            // 
            this.labelToday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelToday.AutoSize = true;
            this.labelToday.Location = new System.Drawing.Point(316, 118);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(97, 15);
            this.labelToday.TabIndex = 0;
            this.labelToday.Text = "05 listopada 2020";
            // 
            // labelCurrentUserPoints
            // 
            this.labelCurrentUserPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentUserPoints.AutoSize = true;
            this.labelCurrentUserPoints.Location = new System.Drawing.Point(278, 143);
            this.labelCurrentUserPoints.Name = "labelCurrentUserPoints";
            this.labelCurrentUserPoints.Size = new System.Drawing.Size(84, 15);
            this.labelCurrentUserPoints.TabIndex = 0;
            this.labelCurrentUserPoints.Text = "<pointsValue>";
            // 
            // userDataListNames
            // 
            this.userDataListNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataListNames.FormattingEnabled = true;
            this.userDataListNames.ItemHeight = 15;
            this.userDataListNames.Items.AddRange(new object[] {
            "Imię i nazwisko:",
            "PESEL:",
            "Data urodzenia:",
            "Adres:",
            "Twój dział:"});
            this.userDataListNames.Location = new System.Drawing.Point(97, 33);
            this.userDataListNames.Name = "userDataListNames";
            this.userDataListNames.Size = new System.Drawing.Size(412, 79);
            this.userDataListNames.TabIndex = 1;
            this.userDataListNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // userDataListValues
            // 
            this.userDataListValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataListValues.FormattingEnabled = true;
            this.userDataListValues.ItemHeight = 15;
            this.userDataListValues.Location = new System.Drawing.Point(201, 33);
            this.userDataListValues.Name = "userDataListValues";
            this.userDataListValues.Size = new System.Drawing.Size(308, 79);
            this.userDataListValues.TabIndex = 2;
            this.userDataListValues.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // prizePicker
            // 
            this.prizePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prizePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prizePicker.FormattingEnabled = true;
            this.prizePicker.Location = new System.Drawing.Point(56, 262);
            this.prizePicker.Name = "prizePicker";
            this.prizePicker.Size = new System.Drawing.Size(171, 23);
            this.prizePicker.TabIndex = 3;
            // 
            // getPrizeButton
            // 
            this.getPrizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getPrizeButton.Location = new System.Drawing.Point(425, 263);
            this.getPrizeButton.Name = "getPrizeButton";
            this.getPrizeButton.Size = new System.Drawing.Size(119, 22);
            this.getPrizeButton.TabIndex = 4;
            this.getPrizeButton.Text = "Odbierz nagrodę";
            this.getPrizeButton.UseVisualStyleBackColor = true;
            this.getPrizeButton.Click += new System.EventHandler(this.getPrizeButtonAction);
            // 
            // prizeInfoLabel
            // 
            this.prizeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prizeInfoLabel.AutoSize = true;
            this.prizeInfoLabel.Location = new System.Drawing.Point(408, 303);
            this.prizeInfoLabel.Name = "prizeInfoLabel";
            this.prizeInfoLabel.Size = new System.Drawing.Size(155, 30);
            this.prizeInfoLabel.TabIndex = 5;
            this.prizeInfoLabel.Text = "Wysłanie zgłoszenia nastąpi \n  po zatwierdzeniu wyboru";
            // 
            // EmployeeProfilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prizeInfoLabel);
            this.Controls.Add(this.getPrizeButton);
            this.Controls.Add(this.prizePicker);
            this.Controls.Add(this.userDataListValues);
            this.Controls.Add(this.userDataListNames);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.labelCurrentUserPoints);
            this.Name = "EmployeeProfilePanel";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelCurrentUserPoints;
        private ListBox userDataListValues;
        private ListBox userDataListNames;
        private ComboBox prizePicker;
        private Button getPrizeButton;
        private Label prizeInfoLabel;
    }
}
