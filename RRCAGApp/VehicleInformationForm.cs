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
    public partial class VehicleInformationForm : Form
    {
        private BindingSource bindingSource;
        //private DataTable dt;
        
        /// <summary>
        /// Initializes an isntance of the Vehicle Information form.
        /// </summary>
        public VehicleInformationForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Initializes an instance of the Vehicle Information form with the binding source.
        /// </summary>
        /// <param name="b">The binding source for data binding to Sales Quote form.</param>
        public VehicleInformationForm(BindingSource b)
        {
            InitializeComponent();
            this.bindingSource = b;
            //this.dt = b;
            this.Load += VehicleInformationForm_Load;
            this.btnClose.Click += BtnClose_Click;
            
        }

        /// <summary>
        /// Handles the Close button being clicked.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the form being loaded.
        /// </summary>
        private void VehicleInformationForm_Load(object sender, EventArgs e)
        {
            BindControls();  
        }

        /// <summary>
        /// Data binds the controls.
        /// </summary>
        private void BindControls()
        {
            Binding idBind = new Binding("Text", bindingSource, "StockNumber");
            Binding yearBind = new Binding("Text", bindingSource, "ManufacturedYear");
            Binding manufacturerBind = new Binding("Text", bindingSource, "Make");
            Binding modelBind = new Binding("Text", bindingSource, "Model");
            Binding mileageBind = new Binding("Text", bindingSource, "Mileage");
            Binding transmissionBind = new Binding("Text", bindingSource, "Automatic");
            Binding colourBind = new Binding("Text", bindingSource, "Colour");
            Binding priceBind = new Binding("Text", bindingSource, "BasePrice");

            this.lblStockID.DataBindings.Add(idBind);
            this.lblYear.DataBindings.Add(yearBind);
            this.lblManufacturer.DataBindings.Add(manufacturerBind);
            this.lblModel.DataBindings.Add(modelBind);
            this.lblMileage.DataBindings.Add(mileageBind);
            this.lblTransmission.DataBindings.Add(transmissionBind);
            this.lblColour.DataBindings.Add(colourBind);
            this.lblPrice.DataBindings.Add(priceBind);

            priceBind.FormattingEnabled = true;
            priceBind.FormatString = "C";
            this.lblTransmission.Text = this.lblTransmission.Text.Equals("True") ? "Automatic" : "Manual";
            if (!this.lblMileage.Text.Equals(String.Empty))
            {
                this.lblMileage.Text = String.Format("{0:n0}", int.Parse(this.lblMileage.Text));
            }
            
            this.Text = this.lblStockID.Text + " - " + lblYear.Text + " " + lblManufacturer.Text + " " + lblModel.Text;

        }
    }
}
