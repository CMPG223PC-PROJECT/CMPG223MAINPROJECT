using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class updatePatientRecord : Form
    {
        public updatePatientRecord()
        {
            InitializeComponent();
        }

        Patient_Records rec = new Patient_Records();
        Physician physician = new Physician();
        private void update_Click(object sender, EventArgs e)
        {
            bool idToVal = int.TryParse(idOfPatientRecord.Text, out int id);
            if (idOfPatientRecord.Text == string.Empty)
            {
                MessageBox.Show("first box is empty");

            }else if (idToVal == false)
            {
                MessageBox.Show("Please enter correct value for box 1");
            }else if (diaBox.Text == string.Empty)
            {
                MessageBox.Show("diagnosis box is empty");
            }else if (preBox.Text == string.Empty)
            {
                MessageBox.Show("prescribtion box is empty");
            }
            else if (rec.isTherePatientRecord(id) == false)
            {
                MessageBox.Show("there is no record for such id");
            }else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("UPDATE Patient_Record SET diagnosis='" + diaBox.Text + "', prescribtion='" + preBox.Text + "' WHERE patient_recordID='" + id + "'", physician.con);
                MessageBox.Show("Data has been updated successfully");
                physician.cmd.ExecuteNonQuery();
                physician.con.Close();
                this.Close();
            }
        }
    }
}
