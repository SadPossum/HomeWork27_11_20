
namespace HomeWork27_11_20.Views
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.specialtiesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.groupsButton);
            this.MenuPanel.Controls.Add(this.specialtiesButton);
            this.MenuPanel.Controls.Add(this.studentsButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(335, 95);
            this.MenuPanel.TabIndex = 0;
            // 
            // specialtiesButton
            // 
            this.specialtiesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.specialtiesButton.Location = new System.Drawing.Point(0, 0);
            this.specialtiesButton.Name = "specialtiesButton";
            this.specialtiesButton.Size = new System.Drawing.Size(104, 95);
            this.specialtiesButton.TabIndex = 2;
            this.specialtiesButton.Text = "specialties";
            this.specialtiesButton.UseVisualStyleBackColor = true;
            // 
            // groupsButton
            // 
            this.groupsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsButton.Location = new System.Drawing.Point(104, 0);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(121, 95);
            this.groupsButton.TabIndex = 1;
            this.groupsButton.Text = "groups";
            this.groupsButton.UseVisualStyleBackColor = true;
            // 
            // studentsButton
            // 
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentsButton.Location = new System.Drawing.Point(225, 0);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(110, 95);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "students";
            this.studentsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 95);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button specialtiesButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button groupsButton;
    }
}