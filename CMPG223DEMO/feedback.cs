using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        public Patient patient = new Patient();
        private void button1_Click(object sender, EventArgs e)
        {
            bool ratingsIsValid = int.TryParse(ratingsBox.Text, out int isRatingsValid);
            patient.email = emailBox.Text;
            int id = patient.patientID();
            if (patient.email == "" || patient.email == null)
            {
                MessageBox.Show("email box is empty");
            }
            else if (ratingsBox.Text =="" || ratingsBox.Text ==null)
            {
                MessageBox.Show("ratings box is empty");
            }
            else if (ratingsIsValid == false)
            {
                MessageBox.Show("ratings box is invalid");
            }else if (isRatingsValid < 0 || isRatingsValid > 10)
            {
                MessageBox.Show("please choose a number betweeen 0 and 10");
            }
            else if (patient.isValidEmail(emailBox.Text) == true)
            {
                MessageBox.Show("email does not exist in our database");
            }
            else
            {
                patient.con = new MySqlConnection(patient.connection);
                patient.con.Open();
                patient.cmd = new MySqlCommand("INSERT INTO  Feedback (patientID, comments, ratings) VALUES('" + id + "', '" + commentsBox.Text + "', '" + ratingsBox.Text + "')", patient.con);
                patient.readData = patient.cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Data has been saved successfully");
                while (patient.readData.Read())
                {
                }

                patient.con.Close();
                this.Hide();

            }
           
           
        }
    }
}
