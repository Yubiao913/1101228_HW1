namespace 房貸試算器
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDownPayInput = new System.Windows.Forms.TextBox();
            this.rdoDownPayAmount = new System.Windows.Forms.RadioButton();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.rdoDownPayPercent = new System.Windows.Forms.RadioButton();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.cmbLoanTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGracePeriod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(156, 42);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(0, 15);
            this.lblLoanAmount.TabIndex = 9;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(156, 75);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(0, 15);
            this.lblMonthlyPayment.TabIndex = 10;
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(156, 116);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(0, 15);
            this.lblFirstPrincipal.TabIndex = 11;
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Location = new System.Drawing.Point(156, 143);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(0, 15);
            this.lblFirstInterest.TabIndex = 12;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(156, 172);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(0, 15);
            this.lblTotalInterest.TabIndex = 13;
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(156, 201);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(0, 15);
            this.lblTotalRepayment.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTotalRepayment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTotalInterest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFirstInterest);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblFirstPrincipal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMonthlyPayment);
            this.groupBox2.Controls.Add(this.lblLoanAmount);
            this.groupBox2.Location = new System.Drawing.Point(459, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 231);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "試算結果顯示";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "貸款總金額：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "每月應繳金額：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "首期本金：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "首期利息：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "總利息支出：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "總還款金額：";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(522, 269);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 46);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "開始計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(711, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除重設";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDownPayInput
            // 
            this.txtDownPayInput.Location = new System.Drawing.Point(124, 136);
            this.txtDownPayInput.Name = "txtDownPayInput";
            this.txtDownPayInput.Size = new System.Drawing.Size(100, 25);
            this.txtDownPayInput.TabIndex = 3;
            this.txtDownPayInput.Text = "20";
            this.txtDownPayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoDownPayAmount
            // 
            this.rdoDownPayAmount.AutoSize = true;
            this.rdoDownPayAmount.Location = new System.Drawing.Point(255, 95);
            this.rdoDownPayAmount.Name = "rdoDownPayAmount";
            this.rdoDownPayAmount.Size = new System.Drawing.Size(132, 19);
            this.rdoDownPayAmount.TabIndex = 1;
            this.rdoDownPayAmount.TabStop = true;
            this.rdoDownPayAmount.Text = "自備款金額 (元)";
            this.rdoDownPayAmount.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(109, 186);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 25);
            this.txtInterestRate.TabIndex = 4;
            this.txtInterestRate.Text = "2.15";
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.txtInterestRate_TextChanged);
            // 
            // rdoDownPayPercent
            // 
            this.rdoDownPayPercent.AutoSize = true;
            this.rdoDownPayPercent.Location = new System.Drawing.Point(124, 95);
            this.rdoDownPayPercent.Name = "rdoDownPayPercent";
            this.rdoDownPayPercent.Size = new System.Drawing.Size(125, 19);
            this.rdoDownPayPercent.TabIndex = 0;
            this.rdoDownPayPercent.TabStop = true;
            this.rdoDownPayPercent.Text = "自備款比例(%)";
            this.rdoDownPayPercent.UseVisualStyleBackColor = true;
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Location = new System.Drawing.Point(109, 47);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(188, 25);
            this.txtHousePrice.TabIndex = 2;
            this.txtHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbLoanTerm
            // 
            this.cmbLoanTerm.FormattingEnabled = true;
            this.cmbLoanTerm.Location = new System.Drawing.Point(109, 237);
            this.cmbLoanTerm.Name = "cmbLoanTerm";
            this.cmbLoanTerm.Size = new System.Drawing.Size(58, 23);
            this.cmbLoanTerm.TabIndex = 5;
            this.cmbLoanTerm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "自備款方式：";
            // 
            // cmbGracePeriod
            // 
            this.cmbGracePeriod.FormattingEnabled = true;
            this.cmbGracePeriod.Location = new System.Drawing.Point(296, 237);
            this.cmbGracePeriod.Name = "cmbGracePeriod";
            this.cmbGracePeriod.Size = new System.Drawing.Size(58, 23);
            this.cmbGracePeriod.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "自備款輸入：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "貸款利率：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "貸款年限：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "貸款年限：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "元";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "%";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbGracePeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbLoanTerm);
            this.groupBox1.Controls.Add(this.txtHousePrice);
            this.groupBox1.Controls.Add(this.rdoDownPayPercent);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.rdoDownPayAmount);
            this.groupBox1.Controls.Add(this.txtDownPayInput);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 287);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入條件設定";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "房貸試算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDownPayInput;
        private System.Windows.Forms.RadioButton rdoDownPayAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.RadioButton rdoDownPayPercent;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.ComboBox cmbLoanTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGracePeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

