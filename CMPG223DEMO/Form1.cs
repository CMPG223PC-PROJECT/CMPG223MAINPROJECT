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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            
        }

        public Patient patient = new Patient();

        private void INSERT_Click(object sender, EventArgs e)
        {
             // { firstName = firstNameButton.Text, lastName = lastNameButton.Text, email = emailButtom.Text, age = ageButton.Text };
            patient.firstName = firstNameButton.Text;
            patient.lastName = lastNameButton.Text;
            patient.contactNumber = contactNumberButton.Text;
            patient.email = emailButtom.Text;
            patient.age = ageButton.Text;
            patient.insertUser();
            

        }

        public void viewDetails()
        {
            patient.email = emailView.Text;
            if (patient.email == "" || patient.email ==null)
            {
                MessageBox.Show("please enter a valid email address");
            }
            else
            {
                patient.con = new MySqlConnection(patient.connection);
                patient.con.Open();
                patient.table = new DataTable();
                patient.adapter = new MySqlDataAdapter("SELECT firstName, lastName, contactNumber, email, age FROM Patient WHERE email='" + emailView.Text + "'", patient.con);
                patient.adapter.Fill(patient.table);
                dataGridView1.DataSource = patient.table;
                //MessageBox.Show("Save Data");
                patient.con.Close();
            }
            if (patient.email != "")
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
            patient.email = emailView.Text;

            if (patient.patientID() == -1)
            {
                MessageBox.Show("email does not exist in our database");
            }
            else if (patient.rfi() !="")
            {
                MessageBox.Show(patient.rfi());
            }
            else
            {
                patient.delete();
               
            }
            
            

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            patient.email = emailView.Text;
           
            if (patient.isValidEmail(emailView.Text) == false)
            {
                updateSignIn update = new updateSignIn();
                update.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("email does not exist in our database");
            }

        }

        private void PhysicianF_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPhysician rd = new SignUpPhysician();
            rd.ShowDialog();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoitment appoitment = new Appoitment();
            appoitment.ShowDialog();
        }

        private void redirectFeedBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            feedback feedback = new feedback();
            feedback.ShowDialog();
        }
    }
}
