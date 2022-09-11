using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CMPG223DEMO
{
    public partial class SignUpPhysician : Form
    {
        public SignUpPhysician()
        {
            InitializeComponent();
        }
        Physician physician = new Physician();
        private void SignUp_Click(object sender, EventArgs e)
        {
            physician.firstName = firstNameButton.Text;
            physician.lastName = lastNameButton.Text;
            physician.contactNumber = contactNumberButton.Text;
            physician.email = emailButtom.Text;
            physician.descr = descrButton.Text;
            physician.insertUser();
        }
        public void viewDetails()
        {
            physician.email = emailView.Text;
            if (physician.email == "" || physician.email == null)
            {
                MessageBox.Show("please enter a valid email");
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("SELECT firstName, lastName, contactNumber, email, descr FROM Physician WHERE email='" + emailView.Text + "'", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            if (physician.email != "")
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("details does not exist for the given email below");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewDetails();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            physician.email = emailView.Text;
            if (physician.isValidEmail(emailView.Text) == false)
            {
                physician.delete();
                this.Close();
            }
            else
            {
                MessageBox.Show("email does not exist in our database");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            physician.email = emailView.Text;
            if (physician.isValidEmail(emailView.Text) == false)
            {
                updatePhysician update = new updatePhysician();
                update.ShowDialog();


            }
            else
            {
                MessageBox.Show("email does not exist in our database");
            }
        }

        private void PatientF_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medication medication = new Medication();
            medication.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Records records = new Patient_Records();
            records.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
