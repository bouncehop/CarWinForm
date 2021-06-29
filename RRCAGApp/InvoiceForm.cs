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
    public partial class InvoiceForm : Form
    {
        /// <summary>
        /// Initializes an instance of the Invoice form.
        /// </summary>
        public InvoiceForm()
        {
            InitializeComponent();

            this.Load += InvoiceForm_Load;

        }

        /// <summary>
        /// Handles the load event of the form.
        /// </summary>
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.lblCurrentDate.Text = DateTime.Today.ToString("MM\\/dd\\/yyyy");
            
        }
    }
}
