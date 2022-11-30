using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class MenuForm : Form
    {

        public MenuForm(string username, string password)
        {
            InitializeComponent();
            
            labelUserName.Text = ":" + username;
            comboBoxType.Items.Add("Personal Loan");
            comboBoxType.Items.Add("Home Loan");
            comboBoxType.Items.Add("Vehicle Loan");
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lLoanType_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double loanFee, totalLoan, rate=0;
            int months;
            loanFee = Convert.ToDouble(txtLoanFee.Text);
           // rate= Convert.ToDouble(txtRate.Text);
            months=Convert.ToInt32(txtMonths.Text);

            if(comboBoxType.SelectedItem.ToString()=="Personal Loan")
             {
                rate = 5;
             }
             else if(comboBoxType.SelectedItem.ToString()=="Home Loan")
             {
                rate = 10;
             } 
             else if( comboBoxType.SelectedItem.ToString()=="Vehicle Loan")
             {
                rate = 15;
             }
             else
             {
                 MessageBox.Show("Please select the correct loan type");
             }
            txtRate.Text = rate.ToString();
            totalLoan = loanFee + (loanFee * (rate/100)) * months ;
            txtTotalLoan.Text = totalLoan.ToString();
            MessageBox.Show("The total of your loan is: R" + totalLoan);
        }
    }
}
