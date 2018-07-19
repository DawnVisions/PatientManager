using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManager.Patients;


namespace PatientManager
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (anticipatedRadio.Checked)
            {
                DeliveryType type;
                if (vagRadio.Checked)
                {
                    type = new Vag();
                }
                else if (csRadio.Checked)
                {
                    type = new CSection();
                }
                else if (gynButton.Checked)
                {
                    type = new Gyn();
                }
                AnticipatedPatient newPatient = new AnticipatedPatient(nameBox.Text, AttendingBox.Text, nicuCheck.Checked, confidCheck.Checked, nonEngCheck.Checked, pihCheck.Checked, medicaidCheck.Checked, type);
                //give newPatient to FamilySuites
            }
            else if (deliveredRadio.Checked)
            {
                DeliveryType type;
                if (vagRadio.Checked)
                {
                    type = new Vag();
                }
                else if (csRadio.Checked)
                {
                    type = new CSection();
                }
                else if (gynButton.Checked)
                {
                    type = new Gyn();
                }
                DeliveredPatient newPatient = new DeliveredPatient(nameBox.Text, AttendingBox.Text, nicuCheck.Checked, confidCheck.Checked, nonEngCheck.Checked, pihCheck.Checked, medicaidCheck.Checked, type, delivDate.Text, roomBox.text);
                //give newPatient to FamilySuites
            }
            else
            {
                typeGroup.ForeColor = System.Drawing.Color.Maroon;
            }
        }
    }
}
