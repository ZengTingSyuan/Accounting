namespace Accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("½Ð¿é¤Jª÷ÃB");
                return;
            }
        }
    }
}
