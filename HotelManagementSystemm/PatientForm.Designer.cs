namespace HotelManagementSystemm
{
    partial class PatientForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            HMS = new Label();
            PatId = new Guna.UI2.WinForms.Guna2TextBox();
            PatName = new Guna.UI2.WinForms.Guna2TextBox();
            PatAddress = new Guna.UI2.WinForms.Guna2TextBox();
            PatPhone = new Guna.UI2.WinForms.Guna2TextBox();
            PatAge = new Guna.UI2.WinForms.Guna2TextBox();
            PatDisease = new Guna.UI2.WinForms.Guna2TextBox();
            PatGenderCmb = new ComboBox();
            PatBloodCmb = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            PatientGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
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
            panel1.Size = new Size(1336, 113);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(586, 62);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 2;
            label1.Text = "PATIENT";
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.BackColor = Color.Transparent;
            HMS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HMS.ForeColor = Color.White;
            HMS.Location = new Point(447, 21);
            HMS.Name = "HMS";
            HMS.Size = new Size(475, 41);
            HMS.TabIndex = 0;
            HMS.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatId
            // 
            PatId.CustomizableEdges = customizableEdges1;
            PatId.DefaultText = "";
            PatId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatId.Font = new Font("Segoe UI", 9F);
            PatId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatId.Location = new Point(90, 142);
            PatId.Margin = new Padding(3, 4, 3, 4);
            PatId.Name = "PatId";
            PatId.PasswordChar = '\0';
            PatId.PlaceholderText = "PatientId";
            PatId.SelectedText = "";
            PatId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PatId.Size = new Size(286, 50);
            PatId.TabIndex = 3;
            PatId.TextChanged += guna2TextBox1_TextChanged;
            // 
            // PatName
            // 
            PatName.CustomizableEdges = customizableEdges3;
            PatName.DefaultText = "";
            PatName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatName.Font = new Font("Segoe UI", 9F);
            PatName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatName.Location = new Point(90, 200);
            PatName.Margin = new Padding(3, 4, 3, 4);
            PatName.Name = "PatName";
            PatName.PasswordChar = '\0';
            PatName.PlaceholderText = "PatientName";
            PatName.SelectedText = "";
            PatName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PatName.Size = new Size(286, 50);
            PatName.TabIndex = 4;
            // 
            // PatAddress
            // 
            PatAddress.CustomizableEdges = customizableEdges5;
            PatAddress.DefaultText = "";
            PatAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatAddress.Font = new Font("Segoe UI", 9F);
            PatAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatAddress.Location = new Point(90, 258);
            PatAddress.Margin = new Padding(3, 4, 3, 4);
            PatAddress.Name = "PatAddress";
            PatAddress.PasswordChar = '\0';
            PatAddress.PlaceholderText = "PatientAddress";
            PatAddress.SelectedText = "";
            PatAddress.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PatAddress.Size = new Size(286, 50);
            PatAddress.TabIndex = 5;
            // 
            // PatPhone
            // 
            PatPhone.CustomizableEdges = customizableEdges7;
            PatPhone.DefaultText = "";
            PatPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatPhone.Font = new Font("Segoe UI", 9F);
            PatPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatPhone.Location = new Point(90, 316);
            PatPhone.Margin = new Padding(3, 4, 3, 4);
            PatPhone.Name = "PatPhone";
            PatPhone.PasswordChar = '\0';
            PatPhone.PlaceholderText = "PatientPhone";
            PatPhone.SelectedText = "";
            PatPhone.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PatPhone.Size = new Size(286, 50);
            PatPhone.TabIndex = 6;
            // 
            // PatAge
            // 
            PatAge.CustomizableEdges = customizableEdges9;
            PatAge.DefaultText = "";
            PatAge.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatAge.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatAge.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatAge.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatAge.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatAge.Font = new Font("Segoe UI", 9F);
            PatAge.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatAge.Location = new Point(90, 374);
            PatAge.Margin = new Padding(3, 4, 3, 4);
            PatAge.Name = "PatAge";
            PatAge.PasswordChar = '\0';
            PatAge.PlaceholderText = "PatientAge";
            PatAge.SelectedText = "";
            PatAge.ShadowDecoration.CustomizableEdges = customizableEdges10;
            PatAge.Size = new Size(286, 50);
            PatAge.TabIndex = 7;
            // 
            // PatDisease
            // 
            PatDisease.CustomizableEdges = customizableEdges11;
            PatDisease.DefaultText = "";
            PatDisease.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatDisease.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatDisease.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatDisease.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatDisease.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatDisease.Font = new Font("Segoe UI", 9F);
            PatDisease.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatDisease.Location = new Point(90, 511);
            PatDisease.Margin = new Padding(3, 4, 3, 4);
            PatDisease.Name = "PatDisease";
            PatDisease.PasswordChar = '\0';
            PatDisease.PlaceholderText = "Major Disease";
            PatDisease.SelectedText = "";
            PatDisease.ShadowDecoration.CustomizableEdges = customizableEdges12;
            PatDisease.Size = new Size(286, 50);
            PatDisease.TabIndex = 8;
            // 
            // PatGenderCmb
            // 
            PatGenderCmb.FormattingEnabled = true;
            PatGenderCmb.Items.AddRange(new object[] { "Male", "Female", "Others" });
            PatGenderCmb.Location = new Point(90, 431);
            PatGenderCmb.Name = "PatGenderCmb";
            PatGenderCmb.Size = new Size(286, 28);
            PatGenderCmb.TabIndex = 9;
            PatGenderCmb.Text = "Gender";
            PatGenderCmb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PatBloodCmb
            // 
            PatBloodCmb.FormattingEnabled = true;
            PatBloodCmb.Items.AddRange(new object[] { "A+", "B+", "A-", "B-", "AB+", "AB-", "O+", "O-" });
            PatBloodCmb.Location = new Point(90, 476);
            PatBloodCmb.Name = "PatBloodCmb";
            PatBloodCmb.Size = new Size(286, 28);
            PatBloodCmb.TabIndex = 10;
            PatBloodCmb.Text = "Blood Group";
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(176, 648);
            button4.Name = "button4";
            button4.Size = new Size(110, 47);
            button4.TabIndex = 14;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(295, 579);
            button3.Name = "button3";
            button3.Size = new Size(110, 47);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(176, 579);
            button2.Name = "button2";
            button2.Size = new Size(110, 47);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 579);
            button1.Name = "button1";
            button1.Size = new Size(110, 47);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(859, 125);
            label2.Name = "label2";
            label2.Size = new Size(204, 41);
            label2.TabIndex = 3;
            label2.Text = "PATIENTS LIST";
            // 
            // PatientGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PatientGV.ColumnHeadersHeight = 25;
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PatientGV.DefaultCellStyle = dataGridViewCellStyle3;
            PatientGV.GridColor = Color.FromArgb(231, 229, 255);
            PatientGV.Location = new Point(548, 169);
            PatientGV.Name = "PatientGV";
            PatientGV.RowHeadersVisible = false;
            PatientGV.RowHeadersWidth = 51;
            PatientGV.Size = new Size(761, 510);
            PatientGV.TabIndex = 15;
            PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PatientGV.ThemeStyle.BackColor = Color.White;
            PatientGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            PatientGV.ThemeStyle.HeaderStyle.BackColor = Color.Lime;
            PatientGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PatientGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            PatientGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PatientGV.ThemeStyle.HeaderStyle.Height = 25;
            PatientGV.ThemeStyle.ReadOnly = false;
            PatientGV.ThemeStyle.RowsStyle.BackColor = Color.Lime;
            PatientGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PatientGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            PatientGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            PatientGV.ThemeStyle.RowsStyle.Height = 29;
            PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            PatientGV.CellContentClick += PatientGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1285, 21);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 712);
            Controls.Add(PatientGV);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatBloodCmb);
            Controls.Add(PatGenderCmb);
            Controls.Add(PatDisease);
            Controls.Add(PatAge);
            Controls.Add(PatPhone);
            Controls.Add(PatAddress);
            Controls.Add(PatName);
            Controls.Add(PatId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label HMS;
        private Guna.UI2.WinForms.Guna2TextBox PatId;
        private Guna.UI2.WinForms.Guna2TextBox PatName;
        private Guna.UI2.WinForms.Guna2TextBox PatAddress;
        private Guna.UI2.WinForms.Guna2TextBox PatPhone;
        private Guna.UI2.WinForms.Guna2TextBox PatAge;
        private Guna.UI2.WinForms.Guna2TextBox PatDisease;
        private ComboBox PatGenderCmb;
        private ComboBox PatBloodCmb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView PatientGV;
        private Label label4;
    }
}