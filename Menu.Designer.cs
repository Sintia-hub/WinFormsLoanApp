namespace WinFormsApp2
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.lblLoanFee = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.txtLoanFee = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotalLoan = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lLoanType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(598, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(679, 33);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Location = new System.Drawing.Point(408, 86);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(100, 25);
            this.lblIDNum.TabIndex = 3;
            this.lblIDNum.Text = "ID Number";
            this.lblIDNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLoanFee
            // 
            this.lblLoanFee.AutoSize = true;
            this.lblLoanFee.Location = new System.Drawing.Point(13, 164);
            this.lblLoanFee.Name = "lblLoanFee";
            this.lblLoanFee.Size = new System.Drawing.Size(82, 25);
            this.lblLoanFee.TabIndex = 4;
            this.lblLoanFee.Text = "Loan Fee";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Location = new System.Drawing.Point(416, 261);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(92, 25);
            this.lblTotalLoan.TabIndex = 5;
            this.lblTotalLoan.Text = "Total Loan";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(12, 233);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(73, 25);
            this.lblMonths.TabIndex = 6;
            this.lblMonths.Text = "Months";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(12, 311);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(111, 25);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Interest Rate";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(554, 167);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(150, 33);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.Text = "Select";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 9;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(554, 85);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(150, 31);
            this.txtIDNum.TabIndex = 10;
            // 
            // txtLoanFee
            // 
            this.txtLoanFee.Location = new System.Drawing.Point(184, 161);
            this.txtLoanFee.Name = "txtLoanFee";
            this.txtLoanFee.Size = new System.Drawing.Size(150, 31);
            this.txtLoanFee.TabIndex = 11;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(184, 233);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(150, 31);
            this.txtMonths.TabIndex = 12;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(184, 305);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(150, 31);
            this.txtRate.TabIndex = 13;
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.Location = new System.Drawing.Point(554, 258);
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.Size = new System.Drawing.Size(150, 31);
            this.txtTotalLoan.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(501, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lLoanType
            // 
            this.lLoanType.AutoSize = true;
            this.lLoanType.Location = new System.Drawing.Point(408, 167);
            this.lLoanType.Name = "lLoanType";
            this.lLoanType.Size = new System.Drawing.Size(92, 25);
            this.lLoanType.TabIndex = 16;
            this.lLoanType.Text = "Loan Type";
            this.lLoanType.Click += new System.EventHandler(this.lLoanType_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lLoanType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalLoan);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtLoanFee);
            this.Controls.Add(this.txtIDNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblTotalLoan);
            this.Controls.Add(this.lblLoanFee);
            this.Controls.Add(this.lblIDNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserName;
        private Label labelUserName;
        private Label lblName;
        private Label lblIDNum;
        private Label lblLoanFee;
        private Label lblTotalLoan;
        private Label lblMonths;
        private Label lblRate;
        private ComboBox comboBoxType;
        private TextBox txtName;
        private TextBox txtIDNum;
        private TextBox txtLoanFee;
        private TextBox txtMonths;
        private TextBox txtRate;
        private TextBox txtTotalLoan;
        private Button btnSave;
        private Label lLoanType;
    }
}