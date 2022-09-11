using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        Physician physician = new Physician();
        private void generateR_Click(object sender, EventArgs e)
        {
            if (feedbackR.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("SELECT p.patientID, CONCAT(UPPER(LEFT(p.firstName, 1)), LOWER(substring(firstName, 2, length(firstName)))) AS firstName, " +
                    "CONCAT(UPPER(LEFT(firstName, 1)), LOWER(SUBSTRING(firstName, 2, LENGTH(firstName)))) AS lastName, p.lastName, " +
                    "ROUND(SUM(f.ratings)/COUNT(f.feedbackID)) AS feeedbackAverage FROM Patient p JOIN Feedback f ON" +
                    " (p.patientID = f.patientID) WHERE f.ratings >0 GROUP BY p.patientID", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if(age15N24.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("select p.patientID, CONCAT(UPPER(LEFT(p.firstName, 1)), LOWER(substring(p.firstName, 2, length(p.firstName)))) AS firstName, " +
                    "CONCAT(UPPER(LEFT(p.lastName, 1)), LOWER(SUBSTRING(p.lastName, 2, LENGTH(p.lastName)))) AS lastName, p.contactNumber, p.email, count(a.appointmentID) " +
                    "AS sumOfAppointmentMade FROM Patient p JOIN Appointment a on (a.patientID = p.patientID) WHERE (age >=15 AND p.age <=24) GROUP BY a.patientID ORDER BY p.lastName", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (age0N14.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("select p.patientID, CONCAT(UPPER(LEFT(p.firstName, 1)), LOWER(substring(p.firstName, 2, length(p.firstName)))) AS firstName, " +
                    "CONCAT(UPPER(LEFT(p.lastName, 1)), LOWER(SUBSTRING(p.lastName, 2, LENGTH(p.lastName)))) AS lastName, p.contactNumber, p.email, count(a.appointmentID) " +
                    "AS sumOfAppointmentMade FROM Patient p JOIN Appointment a on (a.patientID = p.patientID) WHERE (age >=0 AND age <=14) GROUP BY a.patientID ORDER BY p.lastName", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (age55N64.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("select p.patientID, CONCAT(UPPER(LEFT(p.firstName, 1)), LOWER(substring(p.firstName, 2, length(p.firstName)))) AS firstName, " +
                    "CONCAT(UPPER(LEFT(p.lastName, 1)), LOWER(SUBSTRING(p.lastName, 2, LENGTH(p.lastName)))) AS lastName, p.contactNumber, p.email, count(a.appointmentID) " +
                    "AS sumOfAppointmentMade FROM Patient p JOIN Appointment a on (a.patientID = p.patientID) WHERE (age >=55 AND p.age <=64) GROUP BY a.patientID ORDER BY p.lastName", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (age65M.Checked == true)
            {
 
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("select p.patientID, CONCAT(UPPER(LEFT(p.firstName, 1)), LOWER(substring(p.firstName, 2, length(p.firstName)))) AS firstName, " +
                    "CONCAT(UPPER(LEFT(p.lastName, 1)), LOWER(SUBSTRING(p.lastName, 2, LENGTH(p.lastName)))) AS lastName, p.contactNumber, p.email, count(a.appointmentID) " +
                    "AS sumOfAppointmentMade FROM Patient p JOIN Appointment a on (a.patientID = p.patientID) WHERE (age >=65) GROUP BY a.patientID ORDER BY p.lastName", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (medApp.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("SELECT p.patient_recordID, COUNT(p.appointmentID), COUNT(p.medicationID), m.name, m.brand, m.descr, a.date, a.time FROM " +
                    "Patient_Record p JOIN Appointment a  ON (p.appointmentID = a.appointmentID) JOIN Medication m ON (m.medicationID = p.medicationID) GROUP BY m.medicationID", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }

        }

        private void exist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
