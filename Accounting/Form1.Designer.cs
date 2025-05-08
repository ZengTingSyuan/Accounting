
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
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(102, 29);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(178, 27);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 36);
            label1.TabIndex = 1;
            label1.Text = "日期:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(327, 22);
            label2.Name = "label2";
            label2.Size = new Size(78, 36);
            label2.TabIndex = 2;
            label2.Text = "金額:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(424, 29);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(180, 27);
            txtAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(637, 22);
            label3.Name = "label3";
            label3.Size = new Size(78, 36);
            label3.TabIndex = 4;
            label3.Text = "分類:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "飲食", "交通", "購物", "娛樂", "日用品", "房租", "醫療", "社交", "禮物", "數位", "薪水", "零用錢", "獎金", "回饋", "交易", "股息", "租金", "投資", "其他" });
            cmbCategory.Location = new Point(721, 29);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 27);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(938, 22);
            label4.Name = "label4";
            label4.Size = new Size(78, 36);
            label4.TabIndex = 6;
            label4.Text = "類型:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "支出", "收入" });
            cmbType.Location = new Point(1022, 29);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(174, 27);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(78, 36);
            label5.TabIndex = 8;
            label5.Text = "備註:";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1094, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(750, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 51);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(911, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 51);
            btnClear.TabIndex = 11;
            btnClear.Text = "編輯";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1064, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 51);
            btnSave.TabIndex = 12;
            btnSave.Text = "刪除";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(35, 168);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new Size(644, 242);
            dgvRecords.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 450);
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
            Name = "Form1";
            Text = " ";
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
    }
}
