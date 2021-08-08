using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace project_bueno_vista
{
    public partial class Form1 : Form
    {
        string selected_applicant_full_name = "";
        string selected_applicant_e_mail = "";
        string selected_applicant_linkedin = "";

        private readonly Search_Form frm1; //readonly is optional (For safety purposes)

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Search_Form frm)
        {
            InitializeComponent();

            frm1 = frm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selected_applicant_full_name = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString() + " " + row.Cells["surnameDataGridViewTextBoxColumn"].Value.ToString();
                selected_applicant_e_mail = row.Cells["eMailDataGridViewTextBoxColumn"].Value.ToString();
                selected_applicant_linkedin = row.Cells["linkedInProfileDataGridViewTextBoxColumn"].Value.ToString();
                selected_applicant_name_textBox.Text = selected_applicant_full_name;
                selected_applicant_email_textBox.Text = selected_applicant_e_mail;
                selected_applicant_lnkedin_textBox.Text = selected_applicant_linkedin;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bueno_vista_databaseDataSet.Applicants' table. You can move, or remove it, as needed.
            this.applicantsTableAdapter.Fill(this.bueno_vista_databaseDataSet.Applicants);
            applicantsBindingSource.DataSource = this.bueno_vista_databaseDataSet.Applicants;
            panel1.Enabled = false;

            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                nameTextBox.Focus();
                this.bueno_vista_databaseDataSet.Applicants.AddApplicantsRow(this.bueno_vista_databaseDataSet.Applicants.NewApplicantsRow());
                applicantsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            nameTextBox.Focus();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            applicantsBindingSource.ResetBindings(false);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                applicantsBindingSource.EndEdit();
                applicantsTableAdapter.Update(this.bueno_vista_databaseDataSet.Applicants);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                applicantsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.Fill(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void delete_all_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.DeleteAll();
            this.applicantsTableAdapter.Fill(this.bueno_vista_databaseDataSet.Applicants);

            selected_applicant_name_textBox.Clear();
            selected_applicant_email_textBox.Clear();
            selected_applicant_lnkedin_textBox.Clear();
        }

        private void new_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                nameTextBox.Focus();
                this.bueno_vista_databaseDataSet.Applicants.AddApplicantsRow(this.bueno_vista_databaseDataSet.Applicants.NewApplicantsRow());
                applicantsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void next_box_Click(object sender, EventArgs e)
        {
            applicantsBindingSource.MoveNext();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            applicantsBindingSource.MovePrevious();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByName(this.bueno_vista_databaseDataSet.Applicants, search_box_name.Text);
        }

        private void search_surname_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchBySurname(this.bueno_vista_databaseDataSet.Applicants, search_surname_textbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.searchbyEmail(this.bueno_vista_databaseDataSet.Applicants, search_email_textBox.Text);
        }

        private void search_country_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByCountry(this.bueno_vista_databaseDataSet.Applicants, search_country_textBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.searchbyLocation(this.bueno_vista_databaseDataSet.Applicants, search_location_textBox.Text);
        }

        private void linkedin_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByLinkedIn(this.bueno_vista_databaseDataSet.Applicants, search_linkedin_textBox.Text);
        }

        private void github_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByGitHub(this.bueno_vista_databaseDataSet.Applicants, search_GitHub_textBox.Text);
        }

        private void search_website_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByPersonalWebsite(this.bueno_vista_databaseDataSet.Applicants, search_personal_website_textBox.Text);
        }

        private void search_major_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByMajor(this.bueno_vista_databaseDataSet.Applicants, search_major_textBox.Text);
        }

        private void search_school_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchBySchool(this.bueno_vista_databaseDataSet.Applicants, search_school_textBox.Text);
        }

        private void search_college_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByCollegeYear(this.bueno_vista_databaseDataSet.Applicants, search_college_year_textBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByProgrammingLanguage(this.bueno_vista_databaseDataSet.Applicants, programming_language_textbox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SearchByDatabaseLanguage(this.bueno_vista_databaseDataSet.Applicants, search_database_language_textBox.Text);
        }

        private void sort_by_year_of_graduation_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByYear_Of_Graduation(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void sort_by_work_experience_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.Sort_By_Years_Of_Work_Experience(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void sort_by_group_projects_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByGroupProjects(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void sort_by_hackathons_button_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByHackathons(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByPersonalProjects(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void sort_by_number_of_known_apis_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByNumberOfKnownAPIs(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.SortByDiversityProjects(this.bueno_vista_databaseDataSet.Applicants);
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
                    panel1.Enabled = true;
                    nameTextBox.Focus();
                    this.bueno_vista_databaseDataSet.Applicants.AddApplicantsRow(this.bueno_vista_databaseDataSet.Applicants.NewApplicantsRow());
                    applicantsBindingSource.MoveLast();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                panel1.Enabled = false;
                MessageBox.Show("The applicant information has not been considered eligible for database entry.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void submit_button_Click(object sender, EventArgs e)
        {

            string line_1 = "Selected Applicant Information";
            string line_2 = "********************************************************";
            string line_3 = "Full Name: " + selected_applicant_name_textBox.Text;
            string line_4 = "E-Mail: " + selected_applicant_email_textBox.Text;
            string line_5 = "LinkedIn Profile: " + selected_applicant_lnkedin_textBox.Text;
            string line_6 = "********************************************************";
            string line_7 = "Notice: If the applicant does not respond to neither e-mail nor LinkedIn message, the applicant will not be eligible for the interview.";
            string line_8 = "********************************************************";
            string line_9 = "2021 © Developers Without Limits Studio. All rights are reserved.";
            string[] applicant_information = new string[] {line_1, line_2, line_3, line_4, line_5, line_6, line_7, line_8, line_9};
            try
            {
                StreamWriter write_file = new StreamWriter("selected_applicant_information.txt");

                for (int i = 0; i < applicant_information.Length; i++)
                {
                    write_file.WriteLine(applicant_information[i]);
                }

                write_file.Close();

                MessageBox.Show("The applicant information has been writen to text file. Please check the original location to " +
                    "make sure whether the file has been created properly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex)
            {
                MessageBox.Show("Unable to write applicant to the text file. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void new_button_toolstrip_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                nameTextBox.Focus();
                this.bueno_vista_databaseDataSet.Applicants.AddApplicantsRow(this.bueno_vista_databaseDataSet.Applicants.NewApplicantsRow());
                applicantsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 new_window = new Form1();
            new_window.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                applicantsBindingSource.EndEdit();
                applicantsTableAdapter.Update(this.bueno_vista_databaseDataSet.Applicants);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            nameTextBox.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                applicantsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.Fill(this.bueno_vista_databaseDataSet.Applicants);
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.applicantsTableAdapter.DeleteAll();
            this.applicantsTableAdapter.Fill(this.bueno_vista_databaseDataSet.Applicants);

            selected_applicant_name_textBox.Clear();
            selected_applicant_email_textBox.Clear();
            selected_applicant_lnkedin_textBox.Clear();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // These codes are for printing
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void x480ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Size = new Size(1302, 1054);
        }

        private void x1054ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Size = new Size(1942, 1054);
        }

        private void activeBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.Black;
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.Brown;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.DarkBlue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.DarkGreen;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.LightYellow;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.DarkGray;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
        }

        private void x862ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Size = new Size(1302, 836);
        }

        private void activeCaptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void activeWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.AppWorkspace;
        }

        private void buttonShadowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonShadow;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Info;
        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonFace;
        }


        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Search_Form open_search = new Search_Form();
            open_search.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            elibility_form open_checker = new elibility_form();
            open_checker.ShowDialog();
        }

        private void aboutSBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About new_info = new About();
            new_info.ShowDialog();
        }
    }

}
 