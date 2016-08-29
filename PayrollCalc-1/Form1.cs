using System;
using System.Windows.Forms;
/* Author: Zachar Betters
 * Date: 24 August, 2016
 * Class: CIS 209
 * Teacher: Eric Mailman
 * Title: Payroll Calculator 1
 * Description: This program will calculate the gross pay of the given data. 
 */


namespace PayrollCalc_1 {
    public partial class Payroll_Calc : Form {
        public Payroll_Calc() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { }
     
        private void btnExit_Click_1(object sender, EventArgs e) { Close(); }

        private void btnCalc_Click_1(object sender, EventArgs e) {
            decimal hourlyRate, grossPay, hoursWorked;  //declares these variables to be decimals

            if (decimal.TryParse(tbHoursWorked.Text, out hoursWorked) &&   //if the entered data are decimals 
                    decimal.TryParse(tbHourlyRate.Text, out hourlyRate))
            {

                grossPay = hourlyRate * hoursWorked; //calculattes answer and outputs it in a message box
                MessageBox.Show("The gross pay is: $" + grossPay, "Pay");

            }
            else //if entered data is blank or something other than a number 
                MessageBox.Show("You must enter data in order for me to calculate it!", "Error");
        }

        private void btnClear_Click_1(object sender, EventArgs e) {
            tbHourlyRate.Text = String.Empty;
            tbHoursWorked.Text = String.Empty;
        }
    }
}
