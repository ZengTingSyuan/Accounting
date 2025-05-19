using System.Text.Json;

namespace Accounting
{
    public partial class Form1 : Form
    {

        List<Record> records = new List<Record>();


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAndDisplayRecords()
        {
            string filePath = "records.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("�䤣���ɮסA�Х��x�s��ơC", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                records = JsonSerializer.Deserialize<List<Record>>(json) ?? new List<Record>();

                // ��ܨ� DataGridView
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("���J��ƥ��ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cmbType.SelectedItem?.ToString() ?? "";
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string note = textBox1.Text.Trim();
            DateTime date = dtpDate.Value;

            // �ˬd���B�榡
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("�п�J���T�����B", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �ˬd�O�_���|��
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("�п�������P����", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �إ߬���
            Record newRecord = new Record
            {
                Date = date,
                Type = type,
                Category = category,
                Amount = amount,
                Note = note
            };

            // �[�쥿�T�� List
            records.Add(newRecord);

            // ��̷ܳs���
            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;

            // �M�����
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;

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
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            try
            {
                string json = JsonSerializer.Serialize(records, options);
                File.WriteAllText("records.json", json);
                MessageBox.Show("��Ƥw���\�x�s�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�x�s���ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAndDisplayRecords();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow == null)
            {
                MessageBox.Show("�Х�����@�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvRecords.CurrentRow.Index;
            if (index >= 0 && index < records.Count)
            {
                // �T�{�O�_�R��
                var result = MessageBox.Show("�T�w�n�R���o����ƶܡH", "�T�{", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    records.RemoveAt(index);
                    // ��s�e��
                    dgvRecords.DataSource = null;
                    dgvRecords.DataSource = records;
                    MessageBox.Show("�R�����\�I");
                }
            }
        }
    }

}
