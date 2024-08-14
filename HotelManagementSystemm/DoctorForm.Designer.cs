namespace HotelManagementSystemm
{
    partial class DoctorForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            HMS = new Label();
            DocId = new Guna.UI2.WinForms.Guna2TextBox();
            DocPass = new Guna.UI2.WinForms.Guna2TextBox();
            DocExp = new Guna.UI2.WinForms.Guna2TextBox();
            DocName = new Guna.UI2.WinForms.Guna2TextBox();
            DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(HMS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 113);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(435, 62);
            label1.Name = "label1";
            label1.Size = new Size(137, 41);
            label1.TabIndex = 2;
            label1.Text = "DOCTOR";
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.BackColor = Color.Transparent;
            HMS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HMS.ForeColor = Color.White;
            HMS.Location = new Point(307, 9);
            HMS.Name = "HMS";
            HMS.Size = new Size(475, 41);
            HMS.TabIndex = 0;
            HMS.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DocId
            // 
            DocId.CustomizableEdges = customizableEdges1;
            DocId.DefaultText = "";
            DocId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocId.Font = new Font("Segoe UI", 9F);
            DocId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocId.Location = new Point(49, 174);
            DocId.Margin = new Padding(3, 4, 3, 4);
            DocId.Name = "DocId";
            DocId.PasswordChar = '\0';
            DocId.PlaceholderText = "DocId";
            DocId.SelectedText = "";
            DocId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DocId.Size = new Size(286, 43);
            DocId.TabIndex = 2;
            // 
            // DocPass
            // 
            DocPass.CustomizableEdges = customizableEdges3;
            DocPass.DefaultText = "";
            DocPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocPass.Font = new Font("Segoe UI", 9F);
            DocPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocPass.Location = new Point(49, 360);
            DocPass.Margin = new Padding(3, 4, 3, 4);
            DocPass.Name = "DocPass";
            DocPass.PasswordChar = '\0';
            DocPass.PlaceholderText = "Password";
            DocPass.SelectedText = "";
            DocPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DocPass.Size = new Size(286, 43);
            DocPass.TabIndex = 3;
            // 
            // DocExp
            // 
            DocExp.CustomizableEdges = customizableEdges5;
            DocExp.DefaultText = "";
            DocExp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocExp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocExp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocExp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocExp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocExp.Font = new Font("Segoe UI", 9F);
            DocExp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocExp.Location = new Point(49, 300);
            DocExp.Margin = new Padding(3, 4, 3, 4);
            DocExp.Name = "DocExp";
            DocExp.PasswordChar = '\0';
            DocExp.PlaceholderText = "Years of Experience";
            DocExp.SelectedText = "";
            DocExp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DocExp.Size = new Size(286, 43);
            DocExp.TabIndex = 4;
            // 
            // DocName
            // 
            DocName.CustomizableEdges = customizableEdges7;
            DocName.DefaultText = "";
            DocName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DocName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DocName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DocName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DocName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DocName.Font = new Font("Segoe UI", 9F);
            DocName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DocName.Location = new Point(49, 237);
            DocName.Margin = new Padding(3, 4, 3, 4);
            DocName.Name = "DocName";
            DocName.PasswordChar = '\0';
            DocName.PlaceholderText = "DocName";
            DocName.SelectedText = "";
            DocName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DocName.Size = new Size(286, 43);
            DocName.TabIndex = 5;
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DoctorGV.ColumnHeadersHeight = 25;
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DoctorGV.DefaultCellStyle = dataGridViewCellStyle3;
            DoctorGV.GridColor = Color.FromArgb(231, 229, 255);
            DoctorGV.Location = new Point(472, 133);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersVisible = false;
            DoctorGV.RowHeadersWidth = 51;
            DoctorGV.Size = new Size(618, 427);
            DoctorGV.TabIndex = 6;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DoctorGV.ThemeStyle.BackColor = Color.White;
            DoctorGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DoctorGV.ThemeStyle.HeaderStyle.BackColor = Color.Lime;
            DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DoctorGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DoctorGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DoctorGV.ThemeStyle.HeaderStyle.Height = 25;
            DoctorGV.ThemeStyle.ReadOnly = false;
            DoctorGV.ThemeStyle.RowsStyle.BackColor = Color.Lime;
            DoctorGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DoctorGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DoctorGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DoctorGV.ThemeStyle.RowsStyle.Height = 29;
            DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 444);
            button1.Name = "button1";
            button1.Size = new Size(110, 47);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(143, 444);
            button2.Name = "button2";
            button2.Size = new Size(110, 47);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(262, 444);
            button3.Name = "button3";
            button3.Size = new Size(110, 47);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(143, 513);
            button4.Name = "button4";
            button4.Size = new Size(110, 47);
            button4.TabIndex = 10;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1079, 19);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 636);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocName);
            Controls.Add(DocExp);
            Controls.Add(DocPass);
            Controls.Add(DocId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label HMS;
        private Guna.UI2.WinForms.Guna2TextBox DocId;
        private Guna.UI2.WinForms.Guna2TextBox DocPass;
        private Guna.UI2.WinForms.Guna2TextBox DocExp;
        private Guna.UI2.WinForms.Guna2TextBox DocName;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
    }
}