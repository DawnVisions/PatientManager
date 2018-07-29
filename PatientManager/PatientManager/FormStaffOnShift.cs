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
            PutStaffInLists();
        }

        void PutStaffInLists()
        {
            List<CCL> CCLs = SetUpCCLs();
            List<Nurse> PPNurses = SetUpPPnurses();
            List<PCT> Unlicensed = SetUpPCT();

            foreach (Nurse nurse in CCLs)
            {
                CCLcheckedListBox.Items.Add(nurse);
                RNcheckedListBox.Items.Add(nurse);
            }

            foreach (Nurse nurse in PPNurses)
            {
                RNcheckedListBox.Items.Add(nurse);
            }

            foreach (PCT pct in Unlicensed)
            {
                PCTcheckedListBox.Items.Add(pct);
            }
        }

        List<CCL> SetUpCCLs()
        {
            List<CCL> CCLs = new List<CCL>();
            CCLs.Add(new CCL("Jen C"));
            CCLs.Add(new CCL("Jen E"));
            CCLs.Add(new CCL("Jessica J"));
            CCLs.Add(new CCL("April G"));
            CCLs.Add(new CCL("Michelle S"));
            return CCLs;
        }

        List<Nurse> SetUpPPnurses()
        {
            List<Nurse> PPNurses = new List<Nurse>();
            PPNurses.Add(new CorePostpartum("Amanda A", canWorkNursery: true));
            PPNurses.Add(new CorePostpartum("Michelle A", canWorkNursery: true));
            PPNurses.Add(new CorePostpartum("Jen B", canWorkNursery: true));
            PPNurses.Add(new CorePostpartum("Heidi E", canWorkNursery: false));
            PPNurses.Add(new CorePostpartum("Brenda G", canWorkNursery: false));
            PPNurses.Add(new CorePostpartum("Lindsey H", canWorkNursery: false));
            PPNurses.Add(new CorePostpartum("Kelsey H", canWorkNursery: false));
            PPNurses.Add(new CorePostpartum("Lori K", canWorkNursery: false));
            PPNurses.Add(new CorePostpartum("Kami L", canWorkNursery: true));
            PPNurses.Add(new CorePostpartum("Loretta S", canWorkNursery: true));
            PPNurses.Add(new CorePostpartum("Sally W", canWorkNursery: false));
            return PPNurses;
        }

        List<PCT> SetUpPCT()
        {
            List<PCT> Unlicensed = new List<PCT>();
            Unlicensed.Add(new PCT("Carol A"));
            Unlicensed.Add(new PCT("Adelle B"));
            Unlicensed.Add(new PCT("Laura B"));
            Unlicensed.Add(new PCT("Pam B"));
            Unlicensed.Add(new PCT("Kathryn C"));
            Unlicensed.Add(new PCT("Michelle C"));
            Unlicensed.Add(new PCT("Pat C"));
            Unlicensed.Add(new PCT("Chelsea D"));
            Unlicensed.Add(new PCT("Mary G"));
            Unlicensed.Add(new PCT("Christina H"));
            Unlicensed.Add(new PCT("Sadie M"));
            Unlicensed.Add(new PCT("Rhonda P"));
            Unlicensed.Add(new PCT("Bethany R"));
            Unlicensed.Add(new PCT("Jasmine S"));
            return Unlicensed;
        }

        private void AddToShift_Click(object sender, EventArgs e)
        {
            
        }
    }
}
