namespace HotelManagementSystemm
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label4 = new Label();
            HMS = new Label();
            DocName = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            DocPass = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(HMS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 93);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(459, 9);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.BackColor = Color.Transparent;
            HMS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HMS.ForeColor = Color.White;
            HMS.Location = new Point(192, 25);
            HMS.Name = "HMS";
            HMS.Size = new Size(82, 41);
            HMS.TabIndex = 0;
            HMS.Text = "HMS";
            // 
            // DocName
            // 
            DocName.BorderColor = Color.Purple;
            DocName.CustomizableEdges = customizableEdges5;
            DocName.DefaultText = "";
            DocName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocName.Font = new Font("Segoe UI", 9F);
            DocName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocName.Location = new Point(99, 151);
            DocName.Margin = new Padding(3, 4, 3, 4);
            DocName.Name = "DocName";
            DocName.PasswordChar = '\0';
            DocName.PlaceholderForeColor = Color.Purple;
            DocName.PlaceholderText = "DocName";
            DocName.SelectedText = "";
            DocName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DocName.Size = new Size(286, 47);
            DocName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(139, 313);
            button1.Name = "button1";
            button1.Size = new Size(213, 61);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DocPass
            // 
            DocPass.BorderColor = Color.Purple;
            DocPass.CustomizableEdges = customizableEdges7;
            DocPass.DefaultText = "";
            DocPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocPass.Font = new Font("Segoe UI", 9F);
            DocPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocPass.Location = new Point(99, 228);
            DocPass.Margin = new Padding(3, 4, 3, 4);
            DocPass.Name = "DocPass";
            DocPass.PasswordChar = '*';
            DocPass.PlaceholderForeColor = Color.Purple;
            DocPass.PlaceholderText = "DocPassword";
            DocPass.SelectedText = "";
            DocPass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DocPass.Size = new Size(286, 47);
            DocPass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(192, 407);
            label1.Name = "label1";
            label1.Size = new Size(85, 41);
            label1.TabIndex = 1;
            label1.Text = "Clear";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 491);
            Controls.Add(label1);
            Controls.Add(DocPass);
            Controls.Add(button1);
            Controls.Add(DocName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label HMS;
        private Guna.UI2.WinForms.Guna2TextBox DocName;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox DocPass;
        private Label label1;
        private Label label4;
    }
}
