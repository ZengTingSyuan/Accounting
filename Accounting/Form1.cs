using System.Text.Json;

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
            // 1. �ˬd�O�_�����S��
            if (string.IsNullOrWhiteSpace(cmbType.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("�ж�g�Ҧ����", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. �����ഫ���B
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("�п�J���T�����B", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Ū����J���
            string type = cmbType.SelectedItem?.ToString() ?? "";
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string note = textBox1.Text.Trim();
            DateTime date = dtpDate.Value;

            // 4. �إ� Record �å[�J List
            Record newRecord = new Record
            {
                Date = date,
                Type = type,
                Category = category,
                Amount = amount,
                Note = note
            };

            // 5. �M�ſ�J���
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;

            // 6. ��ܦ��\����
            MessageBox.Show("�s�W���\�I", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Record> testRecords = new List<Record>
    {
        new Record
        {
            Date = DateTime.Now,
            Type = "��X",
            Category = "����",
            Amount = 120,
            Note = "���\"
        },
        new Record
        {
            Date = DateTime.Now,
            Type = "���J",
            Category = "�~��",
            Amount = 30000,
            Note = "���u���J"
        }
    };

            // �ǦC�Ʀ� JSON �r��æs��
            try
            {
                string json = JsonSerializer.Serialize(testRecords, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping

                });
                File.WriteAllText("test_records.json", json);

                MessageBox.Show("���լ����w�x�s�� test_records.json�I", "���զ��\", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�x�s���ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
    
}
