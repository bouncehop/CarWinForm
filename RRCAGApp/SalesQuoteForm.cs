/*
 * Name: Matthew Kang
 * Program: Business Information Technology
 * Course: ADEV-2005 Programming 2
 * Created: 2019-10-30
 * Updated: 2019-11-06
 */

using Kang.Matthew.Business;
using RRCAG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        private const decimal SALES_TAX_RATE = 0.13M;
        //private List<Vehicle> vehicles;
        private BindingSource bindingSource;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;

        /// <summary>
        /// Initializes an instance of the Sales Quote form.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            RetrieveDataFromDatabase();

            this.Load += SalesQuoteForm_Load;
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtTradeInValue.TextChanged += TextBox_TextChanged;
            this.nudYears.ValueChanged += NumericUpDown_ValueChanged;
            this.nudAnnualInterestRate.ValueChanged += NumericUpDown_ValueChanged;
            this.chkStereo.CheckedChanged += Checkbox_CheckedChanged;
            this.chkLeather.CheckedChanged += Checkbox_CheckedChanged;
            this.chkNavigation.CheckedChanged += Checkbox_CheckedChanged;
            this.radStandard.CheckedChanged += RadioButton_CheckedChanged;
            this.radPearlized.CheckedChanged += RadioButton_CheckedChanged;
            this.radCustom.CheckedChanged += RadioButton_CheckedChanged;
            this.btnReset.Click += BtnReset_Click;
            this.mnuClose.Click += MnuClose_Click;
            this.cboVehicle.SelectedIndexChanged += CboVehicle_SelectedIndexChanged;
            this.mnuVehicleInformation.Click += MnuVehicleInformation_Click;
            
            
            

            bindingSource = new BindingSource();
            
            
        }

        /// <summary>
        /// Handles the vehicle information button being clicked.
        /// </summary>
        private void MnuVehicleInformation_Click(object sender, EventArgs e)
        {
            if (this.cboVehicle.SelectedIndex != -1)
            {
                VehicleInformationForm vehicleInfo = new VehicleInformationForm(this.bindingSource);
                vehicleInfo.ShowDialog();
            }
            
        }
        /// <summary>
        /// Handles the vehicle combobox selection being changed.
        /// </summary>
        private void CboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblVehicleSalePrice.Text =
            this.lblOptionsAmount.Text =
            this.lblSubtotalAmount.Text =
            this.lblSalesTaxAmount.Text =
            this.lblTotalAmount.Text =
            this.lblTradeInAmount.Text =
            this.lblAmountDue.Text =
            this.lblMonthlyPayment.Text = String.Empty;
            
            if (this.cboVehicle.SelectedIndex != -1)
            {
                this.mnuVehicleInformation.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the file close menu being clicked.
        /// </summary>
        private void MnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles reset button being clicked.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult resetSelect = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (Enum.Equals(resetSelect, DialogResult.Yes))
            {
                InitialState();
            }
            
        }

        /// <summary>
        /// Returns the form to initial settings.
        /// </summary>
        private void InitialState()
        {
            this.txtTradeInValue.Text = "0";
            
            this.lblVehicleSalePrice.Text =
            this.lblOptionsAmount.Text =
            this.lblSubtotalAmount.Text =
            this.lblSalesTaxAmount.Text =
            this.lblTotalAmount.Text =
            this.lblTradeInAmount.Text =
            this.lblAmountDue.Text =
            this.lblMonthlyPayment.Text = String.Empty;
            this.chkStereo.Checked =
            this.chkLeather.Checked =
            this.chkNavigation.Checked = false;
            this.radStandard.Checked = true;
            this.radPearlized.Checked =
            this.radCustom.Checked = false;
            this.nudYears.Value = 1;
            this.nudAnnualInterestRate.Value = 5;
            this.txtTradeInValue.Focus();
            
        }

        /// <summary>
        /// Handles the radio button's state being changed
        /// </summary>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.lblAmountDue.Text.Equals(String.Empty))
            {
                CalculateSalesQuote();
            }
        }

        /// <summary>
        /// Handles the "Stereo" checkbox's state being changed
        /// </summary>
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.lblAmountDue.Text.Equals(String.Empty))
            {
                CalculateSalesQuote();
            }
        }

        /// <summary>
        /// Handles numericupdown value being changed.
        /// </summary>
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!this.lblAmountDue.Text.Equals(String.Empty))
            {
                decimal rate = this.nudAnnualInterestRate.Value * .01M;
                int numOfPaymentPeriods = (int)this.nudYears.Value * 12;
                decimal presentValue = Decimal.Parse(this.lblAmountDue.Text.Replace(",", "").Substring(1));
                this.lblMonthlyPayment.Text = Financial.GetPayment(rate, numOfPaymentPeriods, presentValue).ToString("C");
            }
        }

        /// <summary>
        /// Handles the textbox text being changed.
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            this.lblOptionsAmount.Text =
            this.lblSubtotalAmount.Text =
            this.lblSalesTaxAmount.Text =
            this.lblTotalAmount.Text =
            this.lblTradeInAmount.Text =
            this.lblAmountDue.Text =
            this.lblMonthlyPayment.Text = String.Empty;
        }

        /// <summary>
        /// Handles the calculate quote button being clicked.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            this.errorProvider.SetIconPadding(this.cboVehicle, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
            decimal vehiclePrice = 0;


            if (this.cboVehicle.SelectedIndex == -1)
            {
                this.errorProvider.SetError(this.cboVehicle, "A vehicle must be selected.");
            }
            else
            {
                this.errorProvider.SetError(this.cboVehicle, "");
                vehiclePrice = (decimal)(double)this.dataset.Tables["VehicleStock"].Rows[this.cboVehicle.SelectedIndex]["BasePrice"];
            }

            if (this.txtTradeInValue.Text.Equals(String.Empty))
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value is a required field.");
            }
            else if (!Decimal.TryParse(this.txtTradeInValue.Text, out decimal tradeIn))
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
            }
            else if (Decimal.Parse(this.txtTradeInValue.Text) < 0)
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot be less than 0.");
            }
            else if (this.cboVehicle.SelectedIndex != -1 && tradeIn > vehiclePrice)
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
            }
            else
            {
                this.errorProvider.SetError(this.txtTradeInValue, "");
            }

            if (this.errorProvider.GetError(this.cboVehicle).Equals(String.Empty) 
                && this.errorProvider.GetError(this.txtTradeInValue).Equals(String.Empty))
            {
                CalculateSalesQuote();
            }



        }
        /// <summary>
        /// Calculates and sets the vehicle sales quote and monthly payments.
        /// </summary>
        private void CalculateSalesQuote()
        {
            
            decimal tradeInAmount = Decimal.Parse(this.txtTradeInValue.Text);
            Accessories accessories = AccessoriesChecked();
            ExteriorFinish exteriorFinish = ExteriorFinishChecked();

            SalesQuote quote = new SalesQuote((decimal)(double)this.dataset.Tables["VehicleStock"].Rows[this.cboVehicle.SelectedIndex]["BasePrice"],
                tradeInAmount, SALES_TAX_RATE, accessories, exteriorFinish);
            this.lblVehicleSalePrice.Text = quote.VehicleSalePrice.ToString("C");
            this.lblOptionsAmount.Text = (quote.AccessoryCost + quote.FinishCost).ToString("N");
            this.lblSubtotalAmount.Text = quote.SubTotal.ToString("C");
            this.lblSalesTaxAmount.Text = quote.SalesTax.ToString("N");
            this.lblTotalAmount.Text = quote.Total.ToString("C");
            this.lblTradeInAmount.Text = (quote.TradeInAmount * -1).ToString("N");
            this.lblAmountDue.Text = quote.AmountDue.ToString("C");

            decimal rate = this.nudAnnualInterestRate.Value * .01M;
            int numOfPaymentPeriods = (int)this.nudYears.Value * 12;
            decimal presentValue = quote.AmountDue;
            this.lblMonthlyPayment.Text = Financial.GetPayment(rate, numOfPaymentPeriods, presentValue).ToString("C");
            
            
        }

        /// <summary>
        /// Returns the accessories choices chosen.
        /// </summary>
        /// <returns>Returns the Accessories Enum chosen by the user.</returns>
        private Accessories AccessoriesChecked()
        {
            Accessories accessories = Accessories.None;

            if (this.chkStereo.Checked && this.chkLeather.Checked && this.chkNavigation.Checked)
            {
                accessories = Accessories.All;
            }
            else if (this.chkStereo.Checked && this.chkLeather.Checked)
            {
                accessories = Accessories.StereoAndLeather;
            }
            else if (this.chkStereo.Checked && this.chkNavigation.Checked)
            {
                accessories = Accessories.StereoAndNavigation;
            }
            else if (this.chkLeather.Checked && this.chkNavigation.Checked)
            {
                accessories = Accessories.LeatherAndNavigation;
            }
            else if (this.chkNavigation.Checked)
            {
                accessories = Accessories.ComputerNavigation;
            }
            else if (this.chkLeather.Checked)
            {
                accessories = Accessories.LeatherInterior;
            }
            else if (this.chkStereo.Checked)
            {
                accessories = Accessories.StereoSystem;
            }

            return accessories;
        }

        /// <summary>
        /// Returns the exterior finish choice chosen.
        /// </summary>
        /// <returns>Returns the ExteriorFinish Enum chosen by the user.</returns>
        private ExteriorFinish ExteriorFinishChecked()
        {
            ExteriorFinish exteriorFinish = ExteriorFinish.Standard;

            if (this.radCustom.Checked)
            {
                exteriorFinish = ExteriorFinish.Custom;
            }
            else if (this.radPearlized.Checked)
            {
                exteriorFinish = ExteriorFinish.Pearlized;
            }

            return exteriorFinish;
        }

        /// <summary>
        /// Handles the form being loaded.
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            BindControls();
            this.lblSalesTaxRate.Text = String.Format("Sales Tax ({0}):", SALES_TAX_RATE.ToString("#%"));
            this.cboVehicle.SelectedIndex = -1;
            this.mnuVehicleInformation.Enabled = false;
            this.txtTradeInValue.Select();

            if (this.dataset.Tables["VehicleStock"].Rows.Count < 1)
            {
                this.Opacity = 0;
                this.Close();
                MessageBox.Show("There are no vehicles in stock.", "Sales Quote Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        /// <summary>
        /// Data binds the controls.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = this.dataset.Tables["VehicleStock"];
            this.cboVehicle.DataSource = this.bindingSource;
            this.cboVehicle.DisplayMember = "StockNumber";
            
        }

        /// <summary>
        /// Queries the database and populates a dataset.
        /// </summary>
        private void RetrieveDataFromDatabase()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='AMDatabase.mdb'";
            this.connection = new OleDbConnection();
            this.connection.ConnectionString = connectionString;
            this.connection.Open();

            OleDbCommand selectCommand = new OleDbCommand();
            selectCommand.CommandText = "SELECT * FROM VehicleStock WHERE SoldBy = 0 AND StockNumber IS NOT NULL AND BasePrice IS NOT NULL";
            selectCommand.Connection = this.connection;

            this.adapter = new OleDbDataAdapter();
            this.adapter.SelectCommand = selectCommand;

            this.dataset = new DataSet();

            this.adapter.Fill(this.dataset, "VehicleStock");
        }

    }
}
