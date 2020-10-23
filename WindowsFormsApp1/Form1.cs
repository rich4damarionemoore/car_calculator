using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAutomobileCost : Form
    {
        public frmAutomobileCost()
        {
            InitializeComponent();
        }

        private void Ca_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitExpenses(object sender, EventArgs e)
        {
            /* 1. Get User Information From Text Inputs*/
            /* a. Get Text From Input Text Fields*/
            String carNoteStr = inTxtCarNote.Text;
            String carInsureStr = inTxtCarInsurance.Text;
            String carGasStr = inTxtCarGas.Text;
            String carOilStr = inTxtCarOil.Text;
            String carRepairStr = inTxtCarRepairs.Text;
            String carRegStr = inTxtCarRegistration.Text;

            /* b. Convert Text Fields To Double Data Types To Do Calculations */
            Double carNoteDbl = Convert.ToDouble(carNoteStr);
            Double carInsureDbl = Convert.ToDouble(carInsureStr);
            Double carGasDbl = Convert.ToDouble(carGasStr);
            Double carOilDbl = Convert.ToDouble(carOilStr);
            Double carRepairDbl = Convert.ToDouble(carRepairStr);
            Double carRegDbl = Convert.ToDouble(carRegStr);
            /* 2. Calculate The Montly Expense & Annual Expense*/
            /* Monthly Expense Equation: Car Note + Car Inusrance + Monthly Gas + Monthly Oil + Monthly Repairs + Monthly Registration
             * Yearly Expense Equation: Monthly Expense * 12;
             */
            Double monthlyExpense = carNoteDbl + carInsureDbl + carGasDbl + carOilDbl + carRepairDbl + carRegDbl;
            Double yearlyExpense = monthlyExpense * 12;
            /* 3. Clear Old Data & Return Value To Text Output Area*/
            outTxtResults.Text = ""; //Clear Text Area
            outTxtResults.Text = "***Final Results * **" +Environment.NewLine; //Add Final Results To Output  
            outTxtResults.AppendText( "Total Monthly Cost: " +monthlyExpense.ToString("C") + Environment.NewLine);
            outTxtResults.AppendText( "Total Yearly Cost: " +yearlyExpense.ToString("C") + Environment.NewLine);
        }






    }
}
