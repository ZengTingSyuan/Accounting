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
                MessageBox.Show("找不到檔案，請先儲存資料。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                records = JsonSerializer.Deserialize<List<Record>>(json) ?? new List<Record>();

                // 顯示到 DataGridView
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入資料失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // 檢查金額格式
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("請輸入正確的金額", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查是否有漏填
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("請選擇類型與分類", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 建立紀錄
            Record newRecord = new Record
            {
                Date = date,
                Type = type,
                Category = category,
                Amount = amount,
                Note = note
            };

            // 加到正確的 List
            records.Add(newRecord);

            // 顯示最新資料
            dgvRecords.DataSource = null;
            dgvRecords.DataSource = records;

            // 清空欄位
            cmbType.SelectedIndex = -1;
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
                MessageBox.Show("資料已成功儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("請先選取一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvRecords.CurrentRow.Index;
            if (index >= 0 && index < records.Count)
            {
                // 確認是否刪除
                var result = MessageBox.Show("確定要刪除這筆資料嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    records.RemoveAt(index);
                    // 更新畫面
                    dgvRecords.DataSource = null;
                    dgvRecords.DataSource = records;
                    MessageBox.Show("刪除成功！");
                }
            }
        }
    }

}
