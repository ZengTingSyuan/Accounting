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

            string filePath = $"{currentUser.Username}_records.json";//��C�ӨϥΪ�json�ɫe�������ۤv�W��

            if (!File.Exists(filePath))
            {
                records = new List<Record>();
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;//�Ѧ�chatgpt�ݥL�p��C�ӨϥΪ̦��ۤv���ɮ�
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

        private void LoadUsers()//��chatgpt�p��Ū�����(���L��)
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

            
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))// �ˬd���S���ʪ�
            {
                MessageBox.Show("�п�J���T�����B", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon����chatgpt����ĳ�i�H�[���F���
                return;
            }

            
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(category))// �ˬd���S���ʪ�
            {
                MessageBox.Show("�п�������P����", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon����chatgpt����ĳ�i�H�[���F���
                return;
            }

            
            Record newRecord = new Record
            {
                ��� = date,
                ���B = amount,
                ���� = type,
                ���� = category,
                �Ƶ� = note,
                �ϥΪ� = currentUser?.Username//��datagrid��ܨðO��
            };

            
            records.Add(newRecord);// �[�쥿�T�� List

            
            dgvRecords.DataSource = null;// ��̷ܳs���
            dgvRecords.DataSource = records;

            
            cmbType.SelectedIndex = -1;// �M�����
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
            dtpDate.Value = DateTime.Now;//�⦳��J����l�M��
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
            if (currentUser == null)//Ū����l�O�_�ŵ�
            {
                MessageBox.Show("�Х���ܨϥΪ̡I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon����chatgpt����ĳ�i�H�[���F���
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
                MessageBox.Show("��Ƥw���\�x�s�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon����chatgpt����ĳ�i�H�[���F���
            }
            catch (Exception ex)
            {
                MessageBox.Show("�x�s���ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);//icon����chatgpt����ĳ�i�H�[���F���
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
                var defaultUser = new User { Username = "�w�]�ϥΪ�" };//��chatgpt�p�G�٨S�ιL�{�����w�]�@�ӨϥΪ�
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
                MessageBox.Show("�Х�����@�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon����chatgpt����ĳ�i�H�[���F���
                return;
            }
            int index = dgvRecords.CurrentRow.Index;
            if (index >= 0 && index < records.Count) // �T�{�O�_�R��
            {
               
                var result = MessageBox.Show("�T�w�n�R���o����ƶܡH", "�T�{", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//icon����chatgpt����ĳ�i�H�[���F���
                if (result == DialogResult.Yes)
                {
                    records.RemoveAt(index);
                    
                    dgvRecords.DataSource = null;// ��s�e��(������M��)
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
                MessageBox.Show("�п�J�ϥΪ̦W��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon����chatgpt����ĳ�i�H�[���F���
                return;
            }

            if (users.Any(u => u.Username == newUser))
            {
                MessageBox.Show("�ϥΪ̤w�s�b", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon����chatgpt����ĳ�i�H�[���F���
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

            MessageBox.Show("�s�W�ϥΪ̦��\�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon����chatgpt����ĳ�i�H�[���F���
        }
    }

}
