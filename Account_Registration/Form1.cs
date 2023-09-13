namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = long.Parse(textBox1.Text);
            StudentInfoClass.Program = textBox2.Text.ToString();
            StudentInfoClass.LastName = textBox3.Text.ToString();
            StudentInfoClass.FirstName = textBox4.Text.ToString();
            StudentInfoClass.MiddleName = textBox5.Text.ToString();
            StudentInfoClass.Age = long.Parse(textBox6.Text);
            StudentInfoClass.ContactNo = long.Parse(textBox7.Text);
            StudentInfoClass.Address = textBox8.Text.ToString();

            FrmConfirm formCon = new FrmConfirm();
            DialogResult dialogResult = new DialogResult();
            dialogResult = formCon.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox8.Text = " ";

            }

        }
    }
}