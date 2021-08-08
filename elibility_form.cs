using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_bueno_vista
{
    public partial class elibility_form : Form
    {
        Form1 main = new Form1();
        public elibility_form()
        {
            InitializeComponent();
        }

        private void check_eligibility_button_Click(object sender, EventArgs e)
        {
            int eligibility_score = 0;
            bool academic_condition = associate_s_radioButton.Checked == true || bachelor_s_degree_radioButton.Checked == true || master_s_degree_radioButton.Checked == true || doctorate_radioButton.Checked == true;
            bool dot_net_projects = Convert.ToInt32(dot_net_projects_textBox.Text) >= 5;
            bool knows_c_sharp = programming_language_comboBox.SelectedItem == "C#";
            bool knows_mysql = primary_database_combobox.SelectedItem == "MySQL" || primary_database_combobox.SelectedItem == "Microsoft SQL Server";
            bool has_linkedin = yes_radio_button.Checked == true;
            if (academic_condition && dot_net_projects && knows_c_sharp && knows_mysql && has_linkedin)
            {
                MessageBox.Show("The applicant information has been considered eligible for database entry.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    main.Enabled = true;
                    main.nameTextBox.Focus();
                    main.bueno_vista_databaseDataSet.Applicants.AddApplicantsRow(main.bueno_vista_databaseDataSet.Applicants.NewApplicantsRow());
                    main.applicantsBindingSource.MoveLast();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                main.panel1.Enabled = false;
                MessageBox.Show("The applicant information has not been considered eligible for database entry.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
