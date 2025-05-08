namespace Accounting
{
    public partial class Form1 : Form
    {
        public object Records { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Ū����J�����
            string type = cmbType.SelectedItem?.ToString() ?? "";
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string note = textBox1.Text.Trim();
            DateTime date = dtpDate.Value;

            // �����ഫ���B
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("�п�J���T�����B");
                return;
            }

            // 2. �ˬd�O�_���|��
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("�п�������P����");
                return;
            }

            // 3. �إ� Record ����å[�J List
            Record newRecord = new Record
            {
                Date = date,
                Type = type,
                Category = category,
                Amount = amount,
                Note = note
            };

            // 4. �M�����
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            
            dtpDate.Value = DateTime.Now;

            MessageBox.Show("�s�W���\�I");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
