using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class CarWashInvoiceForm : InvoiceForm
    {
        BindingSource bindingSource;

        /// <summary>
        /// Initializes an instance of the Car Wash Invoice Form.
        /// </summary>
        public CarWashInvoiceForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Initializes an instance of the Car Wash Invoice Form with the binding source.
        /// </summary>
        /// <param name="b">The binding source for data binding to Car Wash Entry Form</param>
        public CarWashInvoiceForm(BindingSource b)
        {
            InitializeComponent();

            this.bindingSource = b;
            this.Load += CarWashInvoiceForm_Load;
            this.FormClosing += CarWashInvoiceForm_FormClosing;
            
        }

        private void CarWashInvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the form being loaded.
        /// </summary>
        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            BindControls();  
        }

        /// <summary>
        /// Data binds the controls
        /// </summary>
        private void BindControls()
        {
            Binding packageBind = new Binding("Text", bindingSource, "PackagePrice");
            Binding fragranceBind = new Binding("Text", bindingSource, "FragrancePrice");
            Binding subtotalBind = new Binding("Text", bindingSource, "Subtotal");
            Binding taxesBind = new Binding("Text", bindingSource, "Taxes");
            Binding totalBind = new Binding("Text", bindingSource, "Total");
            this.lblInvoiceTitle.Text = "Car Wash Invoice";
            this.lblPackagePrice.DataBindings.Add(packageBind);
            this.lblFragrancePrice.DataBindings.Add(fragranceBind);
            this.lblSubtotal.DataBindings.Add(subtotalBind);
            this.lblTaxes.DataBindings.Add(taxesBind);
            this.lblTotal.DataBindings.Add(totalBind);
            packageBind.FormattingEnabled = true;
            subtotalBind.FormattingEnabled = true;
            totalBind.FormattingEnabled = true;
            packageBind.FormatString = "C";
            subtotalBind.FormatString = "C";
            totalBind.FormatString = "C";
            if (this.lblFragrancePrice.Text.Equals("0"))
            {
                this.lblFragrancePrice.Text = "0.00";
            }
            


        }
    }
}
