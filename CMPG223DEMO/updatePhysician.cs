using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223DEMO
{
    public partial class updatePhysician : Form
    {
        public updatePhysician()
        {
            InitializeComponent();
        }

        public Physician physician = new Physician();
        private void update_Click(object sender, EventArgs e)
        {
            if (physician.isValidEmail(emailNeededToUpdate.Text) == false)
            {
                physician.emailNeededToUpdate = emailNeededToUpdate.Text;
                physician.firstName = firstNameButton.Text;
                physician.lastName = lastNameButton.Text;
                physician.contactNumber = contactNumberButton.Text;
                physician.email = emailButtom.Text;
                physician.descr = descrButton.Text;
                if (physician.update() == 0)
                {
                    this.Close();

                }
            }

            else if (physician.isValidEmail(emailNeededToUpdate.Text) == true)
            {
                MessageBox.Show("email does not exist our database");
            }
            
        }
    }
}
