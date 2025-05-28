using System.IO;
using System.Linq;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Accounting
{
    public partial class Form1 : Form
    {

        List<Record> records = new List<Record>();

        List<User> users = new List<User>();
        User currentUser = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAndDisplayRecords()
        {
            if (currentUser == null)
                return;

            string filePath = $"{currentUser.Username}_records.json";

            if (!File.Exists(filePath))
            {
                records = new List<Record>();
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                records = JsonSerializer.Deserialize<List<Record>>(json) ?? new List<Record>();

                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("���J��ƥ��ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveUsers()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText("users.json", json);
        }

        private void LoadUsers()
        {
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }

            cmbUser.DataSource = null;
            cmbUser.DataSource = users;
            cmbUser.DisplayMember = "Username";
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
                ��� = date,
                ���B = amount,
                ���� = type,
                ���� = category,
                �Ƶ� = note,
                �ϥΪ� = currentUser?.Username
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
            if (currentUser == null)
            {
                MessageBox.Show("�Х���ܨϥΪ̡I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            try
            {
                string json = JsonSerializer.Serialize(records, options);
                File.WriteAllText($"{currentUser.Username}_records.json", json);
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
            LoadUsers();

            if (users.Count == 0)
            {
                var defaultUser = new User { Username = "�w�]�ϥΪ�" };
                users.Add(defaultUser);
                SaveUsers();
            }

            cmbUser.DataSource = null;
            cmbUser.DataSource = users;
            cmbUser.DisplayMember = "Username";

            currentUser = users.FirstOrDefault();
            cmbUser.SelectedItem = currentUser;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUser = cmbUser.SelectedItem as User;
            LoadAndDisplayRecords();
        }

        private void txtNewUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }




        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string newUser = txtNewUser.Text.Trim();
            if (string.IsNullOrWhiteSpace(newUser))
            {
                MessageBox.Show("�п�J�ϥΪ̦W��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.Any(u => u.Username == newUser))
            {
                MessageBox.Show("�ϥΪ̤w�s�b", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var user = new User { Username = newUser };
            users.Add(user);
            SaveUsers();

            cmbUser.DataSource = null;
            cmbUser.DataSource = users;
            cmbUser.DisplayMember = "Username";
            cmbUser.SelectedItem = user;

            txtNewUser.Clear();

            MessageBox.Show("�s�W�ϥΪ̦��\�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
