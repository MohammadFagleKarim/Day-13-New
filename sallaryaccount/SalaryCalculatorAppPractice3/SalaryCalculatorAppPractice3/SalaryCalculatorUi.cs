using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        Salary salary = new Salary();

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
           double bs = Convert.ToDouble(basicAmountTextBox.Text);
           double hr=Convert.ToDouble(homeRentTextBox.Text);
           double md= Convert.ToDouble(medicalAllowanceTextBox.Text);

            salary.employeeName = employeeNameTextBox.Text;
            MessageBox.Show(salary.Calculate(bs, hr, md));




        }
    }
}
