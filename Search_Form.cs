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
    public partial class Search_Form : Form
    {
        Form1 main = new Form1();

        public Search_Form()
        {
            InitializeComponent();
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {

        }

           private void search_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByName(main.bueno_vista_databaseDataSet.Applicants, search_box_name.Text);
            main.Show();
        }

        private void search_surname_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchBySurname(main.bueno_vista_databaseDataSet.Applicants, search_surname_textbox.Text);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.searchbyEmail(main.bueno_vista_databaseDataSet.Applicants, search_email_textBox.Text);
            main.Show();
        }

        private void search_country_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByCountry(main.bueno_vista_databaseDataSet.Applicants, search_country_textBox.Text);
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.searchbyLocation(main.bueno_vista_databaseDataSet.Applicants, search_location_textBox.Text);
            main.Show();
        }

        private void linkedin_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByLinkedIn(main.bueno_vista_databaseDataSet.Applicants, search_linkedin_textBox.Text);
            main.Show();
        }

        private void github_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByGitHub(main.bueno_vista_databaseDataSet.Applicants, search_GitHub_textBox.Text);
            main.Show();
        }

        private void search_website_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByPersonalWebsite(main.bueno_vista_databaseDataSet.Applicants, search_personal_website_textBox.Text);
            main.Show();
        }

        private void search_major_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByMajor(main.bueno_vista_databaseDataSet.Applicants, search_major_textBox.Text);
            main.Show();
        }

        private void search_school_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchBySchool(main.bueno_vista_databaseDataSet.Applicants, search_school_textBox.Text);
            main.Show();
        }

        private void search_college_button_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByCollegeYear(main.bueno_vista_databaseDataSet.Applicants, search_college_year_textBox.Text);
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByProgrammingLanguage(main.bueno_vista_databaseDataSet.Applicants, programming_language_textbox.Text);
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main.applicantsTableAdapter.SearchByDatabaseLanguage(main.bueno_vista_databaseDataSet.Applicants, search_database_language_textBox.Text);
            main.Show();
        }
    }
}
