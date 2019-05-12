using System;
using System.Windows.Forms;
using winform.WebserviceTutorial;

namespace winform
{ 
    public partial class Form1 : Form
    {
        private WebServiceSoapClient service = new WebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                int c = service.Add(a, b);
                tbResult.Text = c.ToString();
            }
            catch
            {

            }
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            dtgvStudents.DataSource = service.GetAllStudents();
        }
    }
}
