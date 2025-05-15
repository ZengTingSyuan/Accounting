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
            // 1. 檢查是否有欄位沒填
            if (string.IsNullOrWhiteSpace(cmbType.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("請填寫所有欄位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 嘗試轉換金額
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("請輸入正確的金額", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. 讀取輸入資料
            string type = cmbType.SelectedItem?.ToString() ?? "";
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            string note = textBox1.Text.Trim();
            DateTime date = dtpDate.Value;

            // 4. 建立 Record 並加入 List
            Record newRecord = new Record
            {
                Date = date,
                Type = type,
                Category = category,
                Amount = amount,
                Note = note
            };

            // 5. 清空輸入欄位
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            textBox1.Clear();
            dtpDate.Value = DateTime.Now;

            // 6. 顯示成功提示
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
            List<Record> testRecords = new List<Record>
    {
        new Record
        {
            Date = DateTime.Now,
            Type = "支出",
            Category = "食物",
            Amount = 120,
            Note = "午餐"
        },
        new Record
        {
            Date = DateTime.Now,
            Type = "收入",
            Category = "薪水",
            Amount = 30000,
            Note = "打工收入"
        }
    };

            // 序列化成 JSON 字串並存檔
            try
            {
                string json = JsonSerializer.Serialize(testRecords, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping

                });
                File.WriteAllText("test_records.json", json);

                MessageBox.Show("測試紀錄已儲存為 test_records.json！", "測試成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
    
}
