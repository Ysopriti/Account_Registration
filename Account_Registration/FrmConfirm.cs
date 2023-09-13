using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);


        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            studentNum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            program.Text = DelProgram(StudentInfoClass.Program);
            lastName.Text = DelLastName(StudentInfoClass.LastName);
            firstName.Text = DelFirstName(StudentInfoClass.FirstName);
            middleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            age.Text = DelNumAge(StudentInfoClass.Age).ToString();
            contactNum.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            address.Text = DelAddress(StudentInfoClass.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
