
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
            cmbUser = new ComboBox();
            label6 = new Label();
            txtNewUser = new TextBox();
            btnAddUser = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(294, 80);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(178, 27);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(197, 73);
            label1.Name = "label1";
            label1.Size = new Size(78, 36);
            label1.TabIndex = 1;
            label1.Text = "日期:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(197, 122);
            label2.Name = "label2";
            label2.Size = new Size(78, 36);
            label2.TabIndex = 2;
            label2.Text = "金額:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(294, 129);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(180, 27);
            txtAmount.TabIndex = 3;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(507, 76);
            label3.Name = "label3";
            label3.Size = new Size(78, 36);
            label3.TabIndex = 4;
            label3.Text = "分類:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "飲食", "交通", "購物", "娛樂", "日用品", "房租", "醫療", "社交", "禮物", "數位", "薪水", "零用錢", "獎金", "回饋", "交易", "股息", "租金", "投資", "其他" });
            cmbCategory.Location = new Point(592, 83);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 27);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(507, 122);
            label4.Name = "label4";
            label4.Size = new Size(78, 36);
            label4.TabIndex = 6;
            label4.Text = "類型:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "支出", "收入" });
            cmbType.Location = new Point(592, 131);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(174, 27);
            cmbType.TabIndex = 7;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(45, 172);
            label5.Name = "label5";
            label5.Size = new Size(78, 36);
            label5.TabIndex = 8;
            label5.Text = "備註:";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(757, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 48);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(335, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 48);
            btnClear.TabIndex = 11;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(738, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 48);
            btnSave.TabIndex = 12;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(28, 303);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new Size(933, 258);
            dgvRecords.TabIndex = 13;
            dgvRecords.CellContentClick += dgvRecords_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 231);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 48);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(149, 32);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(164, 27);
            cmbUser.TabIndex = 15;
            cmbUser.SelectedIndexChanged += btnAdduser_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label6.Location = new Point(28, 21);
            label6.Name = "label6";
            label6.Size = new Size(115, 38);
            label6.TabIndex = 16;
            label6.Text = "使用者:";
            // 
            // txtNewUser
            // 
            txtNewUser.BackColor = Color.White;
            txtNewUser.Cursor = Cursors.IBeam;
            txtNewUser.ForeColor = SystemColors.WindowText;
            txtNewUser.Location = new Point(730, 23);
            txtNewUser.Name = "txtNewUser";
            txtNewUser.RightToLeft = RightToLeft.No;
            txtNewUser.Size = new Size(136, 27);
            txtNewUser.TabIndex = 17;
            txtNewUser.TextChanged += txtNewUser_TextChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoEllipsis = true;
            btnAddUser.Location = new Point(878, 23);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 18;
            btnAddUser.Text = "新增使用者";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("新細明體-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label7.Location = new Point(609, 27);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 19;
            label7.Text = "使用者名稱";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1002, 594);
            Controls.Add(label7);
            Controls.Add(btnAddUser);
            Controls.Add(txtNewUser);
            Controls.Add(label6);
            Controls.Add(cmbUser);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
        private ComboBox cmbUser;
        private Label label6;
        private TextBox txtNewUser;
        private Button btnAddUser;
        private Label label7;
    }
}
