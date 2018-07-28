using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManager.Staff;

namespace PatientManager
{
    public partial class FormStaffOnShift : Form
    {
        public FormStaffOnShift()
        {
            InitializeComponent();
            List<CCL> CCLs = SetUpCCLs();
            PutStaffInLists(CCLs);
        }

        List<CCL> SetUpCCLs()
        {
            List<CCL> CCLs = new List<CCL>();
            CCL JessicaJ = new CCL("Jessica J", true);
            CCL AprilG = new CCL("April G", true);
            CCL MichelleS = new CCL("Michelle S", true);
            CCLs.Add(JessicaJ);
            CCLs.Add(AprilG);
            CCLs.Add(MichelleS);
            return CCLs;
        }


        void PutStaffInLists(List<CCL> CCLs)
        {
            foreach (Nurse nurse in CCLs)
            {
                CCLcheckedListBox.Items.Add(nurse);
            }
        }
    }
}
