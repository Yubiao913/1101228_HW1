using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 房貸試算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }
        private void InitializeDefaultValues()
        {
            rdoDownPayPercent.Checked = true;
            txtDownPayInput.Text = "20"; // 預設自備款 20%
            txtInterestRate.Text = "2.15"; // 預設利率

            // 下拉選單初始化
            cmbLoanTerm.Items.AddRange(new object[] { "10", "20", "30", "40" });
            cmbLoanTerm.SelectedIndex = 1; // 預設 20 年

            cmbGracePeriod.Items.AddRange(new object[] { "0", "1", "2", "3", "5" });
            cmbGracePeriod.SelectedIndex = 0; // 預設無寬限期
        }

        // 補上這段，解決第一個錯誤
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 留空即可，不需要寫程式碼
        }

        // 補上這段，解決第二個錯誤
        private void Form1_Load(object sender, EventArgs e)
        {
            // 留空即可，不需要寫程式碼
        }

        // 自備款切換提示標籤（選擇性優化 UI）
        private void rdoDownPayPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDownPayPercent.Checked)
                txtDownPayInput.Text = "20"; // 切換回百分比預設
        }

        private void rdoDownPayAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDownPayAmount.Checked)
                txtDownPayInput.Text = "2000000"; // 切換回金額預設
        }

        // 「開始計算」按鈕事件
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // === 5% 輸入驗證與防呆機制 ===
            if (!double.TryParse(txtHousePrice.Text, out double housePrice) || housePrice <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價（必須大於 0 的數字）！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDownPayInput.Text, out double downPayInput) || downPayInput < 0)
            {
                MessageBox.Show("請輸入正確的自備款數值！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtInterestRate.Text, out double annualRate) || annualRate <= 0)
            {
                MessageBox.Show("請輸入正確的貸款利率！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double loanTermYears = Convert.ToDouble(cmbLoanTerm.SelectedItem);
            double gracePeriodYears = Convert.ToDouble(cmbGracePeriod.SelectedItem);

            if (gracePeriodYears >= loanTermYears)
            {
                MessageBox.Show("寬限期不能大於或等於貸款年限！", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // === 核心功能計算 (50%) ===

            // 1. 計算自備款與貸款總額
            double downPayment = 0;
            if (rdoDownPayPercent.Checked)
            {
                if (downPayInput > 100)
                {
                    MessageBox.Show("自備款百分比不能超過 100%！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                downPayment = housePrice * (downPayInput / 100.0);
            }
            else
            {
                downPayment = downPayInput;
            }

            double loanAmount = housePrice - downPayment;
            if (loanAmount <= 0)
            {
                MessageBox.Show("自備款已大於或等於房屋總價，無需貸款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. 利率與期數轉換
            double monthlyRate = (annualRate / 12.0) / 100.0; // 月利率
            int totalMonths = (int)(loanTermYears * 12);       // 總貸款月數
            int graceMonths = (int)(gracePeriodYears * 12);    // 寬限期月數

            double monthlyPaymentWithPrincipal = 0; // 寬限期後的月繳本息
            double monthlyPaymentGrace = 0;         // 寬限期內的月繳利息
            double firstPrincipal = 0;
            double firstInterest = 0;
            double totalInterest = 0;
            double totalRepayment = 0;

            // 3. 房貸公式計算（本息平均攤還法）
            // 寬限期內只付利息
            monthlyPaymentGrace = loanAmount * monthlyRate;

            // 寬限期後（或無寬限期）的每月本息
            int remainingMonths = totalMonths - graceMonths;
            if (monthlyRate == 0)
            {
                monthlyPaymentWithPrincipal = loanAmount / remainingMonths;
            }
            else
            {
                // 本息平均攤還公式: [貸款額 * 月利率 * (1+月利率)^期數] / [(1+月利率)^期數 - 1]
                monthlyPaymentWithPrincipal = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, remainingMonths))
                                              / (Math.Pow(1 + monthlyRate, remainingMonths) - 1);
            }

            // 首期本金與利息判斷
            if (graceMonths > 0)
            {
                firstPrincipal = 0;
                firstInterest = monthlyPaymentGrace;

                // 總利息 = (寬限期月數 * 寬限期月繳) + (剩餘月數 * 本息月繳) - 貸款本金
                totalRepayment = (graceMonths * monthlyPaymentGrace) + (remainingMonths * monthlyPaymentWithPrincipal);
                totalInterest = totalRepayment - loanAmount;
            }
            else
            {
                firstInterest = loanAmount * monthlyRate;
                firstPrincipal = monthlyPaymentWithPrincipal - firstInterest;

                totalRepayment = totalMonths * monthlyPaymentWithPrincipal;
                totalInterest = totalRepayment - loanAmount;
            }

            // === 介面格式化輸出 (千分位與小數點後兩位) ===
            lblLoanAmount.Text = loanAmount.ToString("N2");

            if (graceMonths > 0)
            {
                lblMonthlyPayment.Text = $"前 {gracePeriodYears} 年(寬限期): {monthlyPaymentGrace.ToString("N2")}\n第 {gracePeriodYears + 1} 年起: {monthlyPaymentWithPrincipal.ToString("N2")}";
            }
            else
            {
                lblMonthlyPayment.Text = monthlyPaymentWithPrincipal.ToString("N2");
            }

            lblFirstPrincipal.Text = firstPrincipal.ToString("N2");
            lblFirstInterest.Text = firstInterest.ToString("N2");
            lblTotalInterest.Text = totalInterest.ToString("N2");
            lblTotalRepayment.Text = totalRepayment.ToString("N2");
        }

        // 「清除重設」按鈕事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Clear();
            InitializeDefaultValues();

            lblLoanAmount.Text = "-";
            lblMonthlyPayment.Text = "-";
            lblFirstPrincipal.Text = "-";
            lblFirstInterest.Text = "-";
            lblTotalInterest.Text = "-";
            lblTotalRepayment.Text = "-";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
