
namespace Accounting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            cmbType = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            dgvRecords = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(79, 23);
            dtpDate.Margin = new Padding(2, 2, 2, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(139, 23);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(9, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 1;
            label1.Text = "日期:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(254, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 2;
            label2.Text = "金額:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(330, 23);
            txtAmount.Margin = new Padding(2, 2, 2, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(141, 23);
            txtAmount.TabIndex = 3;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(495, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 4;
            label3.Text = "分類:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "飲食", "交通", "購物", "娛樂", "日用品", "房租", "醫療", "社交", "禮物", "數位", "薪水", "零用錢", "獎金", "回饋", "交易", "股息", "租金", "投資", "其他" });
            cmbCategory.Location = new Point(561, 23);
            cmbCategory.Margin = new Padding(2, 2, 2, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(136, 23);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(730, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 6;
            label4.Text = "類型:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "支出", "收入" });
            cmbType.Location = new Point(795, 23);
            cmbType.Margin = new Padding(2, 2, 2, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(136, 23);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(9, 77);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 8;
            label5.Text = "備註:";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 84);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(852, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(602, 149);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(602, 233);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 50);
            btnClear.TabIndex = 11;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(780, 149);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 12;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(27, 133);
            dgvRecords.Margin = new Padding(2, 2, 2, 2);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new Size(501, 191);
            dgvRecords.TabIndex = 13;
            dgvRecords.CellContentClick += dgvRecords_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(780, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 355);
            Controls.Add(btnDelete);
            Controls.Add(dgvRecords);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(cmbType);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private ComboBox cmbType;
        private Label label5;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dgvRecords;
        private Button btnDelete;
    }
}
