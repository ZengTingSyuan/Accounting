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

            string filePath = $"{currentUser.Username}_records.json";//把每個使用者json檔前面都有自己名稱

            if (!File.Exists(filePath))
            {
                records = new List<Record>();
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;//參考chatgpt問他如何每個使用者有自己的檔案
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
                MessageBox.Show("載入資料失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveUsers()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText("users.json", json);
        }

        private void LoadUsers()//問chatgpt如何讀取資料(有微調)
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

            
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))// 檢查有沒有缺空
            {
                MessageBox.Show("請輸入正確的金額", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon有問chatgpt有建議可以加的東西嗎
                return;
            }

            
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(category))// 檢查有沒有缺空
            {
                MessageBox.Show("請選擇類型與分類", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon有問chatgpt有建議可以加的東西嗎
                return;
            }

            
            Record newRecord = new Record
            {
                日期 = date,
                金額 = amount,
                分類 = type,
                類型 = category,
                備註 = note,
                使用者 = currentUser?.Username//讓datagrid顯示並記錄
            };

            
            records.Add(newRecord);// 加到正確的 List

            
            dgvRecords.DataSource = null;// 顯示最新資料
            dgvRecords.DataSource = records;

            
            cmbType.SelectedIndex = -1;// 清空欄位
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;

            MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;//把有填入的格子清除
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
            if (currentUser == null)//讀取格子是否空著
            {
                MessageBox.Show("請先選擇使用者！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon有問chatgpt有建議可以加的東西嗎
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
                MessageBox.Show("資料已成功儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon有問chatgpt有建議可以加的東西嗎
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);//icon有問chatgpt有建議可以加的東西嗎
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
                var defaultUser = new User { Username = "預設使用者" };//問chatgpt如果還沒用過程式怎麼預設一個使用者
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
                MessageBox.Show("請先選取一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon有問chatgpt有建議可以加的東西嗎
                return;
            }
            int index = dgvRecords.CurrentRow.Index;
            if (index >= 0 && index < records.Count) // 確認是否刪除
            {
               
                var result = MessageBox.Show("確定要刪除這筆資料嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//icon有問chatgpt有建議可以加的東西嗎
                if (result == DialogResult.Yes)
                {
                    records.RemoveAt(index);
                    
                    dgvRecords.DataSource = null;// 更新畫面(把紀錄清除)
                    dgvRecords.DataSource = records;
                    MessageBox.Show("刪除成功！");
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
                MessageBox.Show("請輸入使用者名稱", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);//icon有問chatgpt有建議可以加的東西嗎
                return;
            }

            if (users.Any(u => u.Username == newUser))
            {
                MessageBox.Show("使用者已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon有問chatgpt有建議可以加的東西嗎
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

            MessageBox.Show("新增使用者成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);//icon有問chatgpt有建議可以加的東西嗎
        }
    }

}
