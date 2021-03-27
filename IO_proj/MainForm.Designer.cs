using IO_proj;
using System.Windows.Forms;

namespace ProductionManagementSystem
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeeTab1 = new System.Windows.Forms.TabPage();
            this.employeeTab2 = new System.Windows.Forms.TabPage();
            this.managerTab1 = new System.Windows.Forms.TabPage();
            this.managerTab2 = new System.Windows.Forms.TabPage();
            this.adminTab1 = new System.Windows.Forms.TabPage();
            this.adminTab2 = new System.Windows.Forms.TabPage();
            this.adminTab3 = new System.Windows.Forms.TabPage();
            this.adminTab4 = new System.Windows.Forms.TabPage();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(607, 406);
            this.tabControl.TabIndex = 0;
            // 
            // employeeTab1
            // 
            this.employeeTab1.Location = new System.Drawing.Point(10, 58);
            this.employeeTab1.Name = "employeeTab1";
            this.employeeTab1.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab1.Size = new System.Drawing.Size(1548, 844);
            this.employeeTab1.TabIndex = 0;
            this.employeeTab1.Text = "Formularz";
            this.employeeTab1.UseVisualStyleBackColor = true;
            // 
            // employeeTab2
            // 
            this.employeeTab2.Location = new System.Drawing.Point(10, 58);
            this.employeeTab2.Name = "employeeTab2";
            this.employeeTab2.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab2.Size = new System.Drawing.Size(1548, 844);
            this.employeeTab2.TabIndex = 0;
            this.employeeTab2.Text = "Twój Profil";
            this.employeeTab2.UseVisualStyleBackColor = true;
            // 
            // managerTab1
            // 
            this.managerTab1.Location = new System.Drawing.Point(10, 58);
            this.managerTab1.Name = "managerTab1";
            this.managerTab1.Padding = new System.Windows.Forms.Padding(3);
            this.managerTab1.Size = new System.Drawing.Size(1548, 844);
            this.managerTab1.TabIndex = 0;
            this.managerTab1.Text = "Dane pracowników";
            this.managerTab1.UseVisualStyleBackColor = true;
            // 
            // managerTab2
            // 
            this.managerTab2.Location = new System.Drawing.Point(10, 58);
            this.managerTab2.Name = "managerTab2";
            this.managerTab2.Padding = new System.Windows.Forms.Padding(3);
            this.managerTab2.Size = new System.Drawing.Size(1548, 844);
            this.managerTab2.TabIndex = 0;
            this.managerTab2.Text = "Statystyki działu";
            this.managerTab2.UseVisualStyleBackColor = true;
            // 
            // adminTab1
            // 
            this.adminTab1.Location = new System.Drawing.Point(10, 58);
            this.adminTab1.Name = "adminTab1";
            this.adminTab1.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab1.Size = new System.Drawing.Size(1548, 844);
            this.adminTab1.TabIndex = 0;
            this.adminTab1.Text = "Dane pracowników";
            this.adminTab1.UseVisualStyleBackColor = true;
            // 
            // adminTab2
            // 
            this.adminTab2.Location = new System.Drawing.Point(10, 58);
            this.adminTab2.Name = "adminTab2";
            this.adminTab2.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab2.Size = new System.Drawing.Size(1548, 844);
            this.adminTab2.TabIndex = 0;
            this.adminTab2.Text = "Dodaj pracownika";
            this.adminTab2.UseVisualStyleBackColor = true;
            // 
            // adminTab3
            // 
            this.adminTab3.Location = new System.Drawing.Point(10, 58);
            this.adminTab3.Name = "adminTab3";
            this.adminTab3.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab3.Size = new System.Drawing.Size(1548, 844);
            this.adminTab3.TabIndex = 0;
            this.adminTab3.Text = "Zarządzaj pracownikami";
            this.adminTab3.UseVisualStyleBackColor = true;
            // 
            // adminTab4
            // 
            this.adminTab4.Location = new System.Drawing.Point(10, 58);
            this.adminTab4.Name = "adminTab4";
            this.adminTab4.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab4.Size = new System.Drawing.Size(1548, 844);
            this.adminTab4.TabIndex = 0;
            this.adminTab4.Text = "Wprowadź nagrody";
            this.adminTab4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 406);
            this.Controls.Add(this.tabControl);
            this.Location = new System.Drawing.Point(300, 200);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.FormClosed += ExitApp;

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage employeeTab1;
        private System.Windows.Forms.TabPage employeeTab2;
        private System.Windows.Forms.TabPage managerTab1;
        private System.Windows.Forms.TabPage managerTab2;
        private System.Windows.Forms.TabPage adminTab1;
        private System.Windows.Forms.TabPage adminTab2;
        private System.Windows.Forms.TabPage adminTab3;
        private System.Windows.Forms.TabPage adminTab4;
        
        

    }
}