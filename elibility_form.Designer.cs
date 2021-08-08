
namespace project_bueno_vista
{
    partial class elibility_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.no_radioButton = new System.Windows.Forms.RadioButton();
            this.yes_radio_button = new System.Windows.Forms.RadioButton();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.primary_database_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.programming_language_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.dot_net_projects_textBox = new System.Windows.Forms.TextBox();
            this.check_eligibility_button = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.doctorate_radioButton = new System.Windows.Forms.RadioButton();
            this.master_s_degree_radioButton = new System.Windows.Forms.RadioButton();
            this.bachelor_s_degree_radioButton = new System.Windows.Forms.RadioButton();
            this.associate_s_radioButton = new System.Windows.Forms.RadioButton();
            this.high_school_radioButton = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.groupBox24);
            this.panel2.Controls.Add(this.groupBox23);
            this.panel2.Controls.Add(this.groupBox22);
            this.panel2.Controls.Add(this.groupBox21);
            this.panel2.Controls.Add(this.check_eligibility_button);
            this.panel2.Controls.Add(this.groupBox20);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 212);
            this.panel2.TabIndex = 37;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.no_radioButton);
            this.groupBox24.Controls.Add(this.yes_radio_button);
            this.groupBox24.Location = new System.Drawing.Point(439, 90);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(200, 72);
            this.groupBox24.TabIndex = 50;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "LinkedIn Profile";
            // 
            // no_radioButton
            // 
            this.no_radioButton.AutoSize = true;
            this.no_radioButton.Location = new System.Drawing.Point(118, 30);
            this.no_radioButton.Name = "no_radioButton";
            this.no_radioButton.Size = new System.Drawing.Size(39, 17);
            this.no_radioButton.TabIndex = 7;
            this.no_radioButton.TabStop = true;
            this.no_radioButton.Text = "No";
            this.no_radioButton.UseVisualStyleBackColor = true;
            // 
            // yes_radio_button
            // 
            this.yes_radio_button.AutoSize = true;
            this.yes_radio_button.Location = new System.Drawing.Point(37, 30);
            this.yes_radio_button.Name = "yes_radio_button";
            this.yes_radio_button.Size = new System.Drawing.Size(43, 17);
            this.yes_radio_button.TabIndex = 6;
            this.yes_radio_button.TabStop = true;
            this.yes_radio_button.Text = "Yes";
            this.yes_radio_button.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.primary_database_combobox);
            this.groupBox23.Location = new System.Drawing.Point(439, 12);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(200, 72);
            this.groupBox23.TabIndex = 49;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Primary Database Language";
            // 
            // primary_database_combobox
            // 
            this.primary_database_combobox.FormattingEnabled = true;
            this.primary_database_combobox.Items.AddRange(new object[] {
            "Oracle",
            "MySQL",
            "Microsoft SQL Server",
            "PostgreSQL",
            "MongoDB",
            "DB2",
            "Redis",
            "SQLite",
            "Microsoft Access"});
            this.primary_database_combobox.Location = new System.Drawing.Point(18, 30);
            this.primary_database_combobox.Name = "primary_database_combobox";
            this.primary_database_combobox.Size = new System.Drawing.Size(164, 21);
            this.primary_database_combobox.TabIndex = 47;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.programming_language_comboBox);
            this.groupBox22.Location = new System.Drawing.Point(231, 90);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(200, 72);
            this.groupBox22.TabIndex = 48;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Primary Programming Language";
            // 
            // programming_language_comboBox
            // 
            this.programming_language_comboBox.FormattingEnabled = true;
            this.programming_language_comboBox.Items.AddRange(new object[] {
            "HTML/CSS",
            "Python",
            "Java",
            "JavaScript",
            "Swift",
            "C++",
            "C#",
            "R",
            "Golang",
            "PHP",
            "TypeScript",
            "Scala",
            "Shell",
            "PowerShell",
            "Perl",
            "Haskell",
            "Kotlin",
            "Visual Basic .NET",
            "Delphi",
            "MATLAB",
            "Groovy",
            "Lua",
            "Rust",
            "Ruby"});
            this.programming_language_comboBox.Location = new System.Drawing.Point(18, 30);
            this.programming_language_comboBox.Name = "programming_language_comboBox";
            this.programming_language_comboBox.Size = new System.Drawing.Size(164, 21);
            this.programming_language_comboBox.TabIndex = 47;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.dot_net_projects_textBox);
            this.groupBox21.Location = new System.Drawing.Point(231, 12);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(200, 72);
            this.groupBox21.TabIndex = 6;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Number of .NET Projects";
            // 
            // dot_net_projects_textBox
            // 
            this.dot_net_projects_textBox.Location = new System.Drawing.Point(18, 30);
            this.dot_net_projects_textBox.Name = "dot_net_projects_textBox";
            this.dot_net_projects_textBox.Size = new System.Drawing.Size(164, 20);
            this.dot_net_projects_textBox.TabIndex = 47;
            // 
            // check_eligibility_button
            // 
            this.check_eligibility_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_eligibility_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_eligibility_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_eligibility_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_eligibility_button.Location = new System.Drawing.Point(249, 169);
            this.check_eligibility_button.Name = "check_eligibility_button";
            this.check_eligibility_button.Size = new System.Drawing.Size(157, 37);
            this.check_eligibility_button.TabIndex = 14;
            this.check_eligibility_button.Text = "Check Eligibility";
            this.check_eligibility_button.UseVisualStyleBackColor = false;
            this.check_eligibility_button.Click += new System.EventHandler(this.check_eligibility_button_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.doctorate_radioButton);
            this.groupBox20.Controls.Add(this.master_s_degree_radioButton);
            this.groupBox20.Controls.Add(this.bachelor_s_degree_radioButton);
            this.groupBox20.Controls.Add(this.associate_s_radioButton);
            this.groupBox20.Controls.Add(this.high_school_radioButton);
            this.groupBox20.Location = new System.Drawing.Point(22, 11);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(200, 151);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Highest Academic Degree";
            // 
            // doctorate_radioButton
            // 
            this.doctorate_radioButton.AutoSize = true;
            this.doctorate_radioButton.Location = new System.Drawing.Point(16, 124);
            this.doctorate_radioButton.Name = "doctorate_radioButton";
            this.doctorate_radioButton.Size = new System.Drawing.Size(72, 17);
            this.doctorate_radioButton.TabIndex = 5;
            this.doctorate_radioButton.TabStop = true;
            this.doctorate_radioButton.Text = "Doctorate";
            this.doctorate_radioButton.UseVisualStyleBackColor = true;
            // 
            // master_s_degree_radioButton
            // 
            this.master_s_degree_radioButton.AutoSize = true;
            this.master_s_degree_radioButton.Location = new System.Drawing.Point(16, 97);
            this.master_s_degree_radioButton.Name = "master_s_degree_radioButton";
            this.master_s_degree_radioButton.Size = new System.Drawing.Size(103, 17);
            this.master_s_degree_radioButton.TabIndex = 4;
            this.master_s_degree_radioButton.TabStop = true;
            this.master_s_degree_radioButton.Text = "Master`s Degree";
            this.master_s_degree_radioButton.UseVisualStyleBackColor = true;
            // 
            // bachelor_s_degree_radioButton
            // 
            this.bachelor_s_degree_radioButton.AutoSize = true;
            this.bachelor_s_degree_radioButton.Location = new System.Drawing.Point(16, 71);
            this.bachelor_s_degree_radioButton.Name = "bachelor_s_degree_radioButton";
            this.bachelor_s_degree_radioButton.Size = new System.Drawing.Size(113, 17);
            this.bachelor_s_degree_radioButton.TabIndex = 3;
            this.bachelor_s_degree_radioButton.TabStop = true;
            this.bachelor_s_degree_radioButton.Text = "Bachelor`s Degree";
            this.bachelor_s_degree_radioButton.UseVisualStyleBackColor = true;
            // 
            // associate_s_radioButton
            // 
            this.associate_s_radioButton.AutoSize = true;
            this.associate_s_radioButton.Location = new System.Drawing.Point(16, 46);
            this.associate_s_radioButton.Name = "associate_s_radioButton";
            this.associate_s_radioButton.Size = new System.Drawing.Size(117, 17);
            this.associate_s_radioButton.TabIndex = 2;
            this.associate_s_radioButton.TabStop = true;
            this.associate_s_radioButton.Text = "Associate`s Degree";
            this.associate_s_radioButton.UseVisualStyleBackColor = true;
            // 
            // high_school_radioButton
            // 
            this.high_school_radioButton.AutoSize = true;
            this.high_school_radioButton.Checked = true;
            this.high_school_radioButton.Location = new System.Drawing.Point(16, 20);
            this.high_school_radioButton.Name = "high_school_radioButton";
            this.high_school_radioButton.Size = new System.Drawing.Size(83, 17);
            this.high_school_radioButton.TabIndex = 1;
            this.high_school_radioButton.TabStop = true;
            this.high_school_radioButton.Text = "High School";
            this.high_school_radioButton.UseVisualStyleBackColor = true;
            // 
            // elibility_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(658, 210);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "elibility_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Check Applicant Eligibility";
            this.panel2.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.RadioButton no_radioButton;
        private System.Windows.Forms.RadioButton yes_radio_button;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.ComboBox primary_database_combobox;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.ComboBox programming_language_comboBox;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TextBox dot_net_projects_textBox;
        private System.Windows.Forms.Button check_eligibility_button;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.RadioButton doctorate_radioButton;
        private System.Windows.Forms.RadioButton master_s_degree_radioButton;
        private System.Windows.Forms.RadioButton bachelor_s_degree_radioButton;
        private System.Windows.Forms.RadioButton associate_s_radioButton;
        private System.Windows.Forms.RadioButton high_school_radioButton;
    }
}