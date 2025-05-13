
namespace Bank_Accounts_Application
{
   public partial class Form1 : Form
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
            label1 = new Label();
            label2 = new Label();
            AmountNum = new NumericUpDown();
            OwnerTxt = new TextBox();
            CreateAccountBtn = new Button();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            BankAccountGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 50);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 364);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(201, 375);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(150, 27);
            AmountNum.TabIndex = 2;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(196, 61);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(170, 27);
            OwnerTxt.TabIndex = 3;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(141, 134);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(225, 65);
            CreateAccountBtn.TabIndex = 4;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(420, 373);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(236, 61);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(677, 373);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(224, 61);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(399, 61);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 51;
            BankAccountGrid.Size = new Size(527, 285);
            BankAccountGrid.TabIndex = 7;
            BankAccountGrid.CellContentClick += BankAccountGrid_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 458);
            Controls.Add(BankAccountGrid);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(OwnerTxt);
            Controls.Add(AmountNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += CreateAccountBtn_Click;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form loaded!");
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown AmountNum;
        private TextBox OwnerTxt;
        private Button CreateAccountBtn;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private DataGridView BankAccountGrid;
    }
}
