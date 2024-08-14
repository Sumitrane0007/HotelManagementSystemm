namespace HotelManagementSystemm
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            HMS = new Label();
            label1 = new Label();
            Myprogressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.BackColor = Color.Transparent;
            HMS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HMS.ForeColor = Color.White;
            HMS.Location = new Point(156, 42);
            HMS.Name = "HMS";
            HMS.Size = new Size(475, 41);
            HMS.TabIndex = 1;
            HMS.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(324, 94);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 2;
            label1.Text = "Version 1.0";
            // 
            // Myprogressbar
            // 
            Myprogressbar.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogressbar.Font = new Font("Segoe UI", 12F);
            Myprogressbar.ForeColor = Color.White;
            Myprogressbar.Location = new Point(278, 162);
            Myprogressbar.Minimum = 0;
            Myprogressbar.Name = "Myprogressbar";
            Myprogressbar.ProgressColor = Color.MediumBlue;
            Myprogressbar.ProgressColor2 = Color.RoyalBlue;
            Myprogressbar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Myprogressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogressbar.Size = new Size(196, 196);
            Myprogressbar.TabIndex = 3;
            Myprogressbar.Text = "guna2CircleProgressBar1";
            Myprogressbar.ValueChanged += guna2CircleProgressBar1_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(Myprogressbar);
            Controls.Add(label1);
            Controls.Add(HMS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HMS;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogressbar;
        private System.Windows.Forms.Timer timer1;
    }
}