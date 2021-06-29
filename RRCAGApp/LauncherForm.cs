/*
 * Name: Matthew Kang
 * Program: Business Information Technology
 * Course: ADEV-2005 Programming 2
 * Created: 2019-10-30
 * Updated: 2019-11-06
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class LauncherForm : Form
    {
        /// <summary>
        /// Initializes an instance of the Launcher form.
        /// </summary>
        public LauncherForm()
        {
            InitializeComponent();

            this.Load += LauncherForm_Load;
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuDataVehicle.Click += MnuDataVehicle_Click;

        }

        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleDataForm vehicleDataForm = new VehicleDataForm();
                vehicleDataForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the car wash menu being clicked.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            if (File.Exists("fragrances.txt"))
            {

                try
                {
                    
                    CarWashEntryForm carWashEntryForm = new CarWashEntryForm();
                    carWashEntryForm.ShowDialog();
                }
                catch (FormatException)
                {
                    MessageBox.Show("An error occured while reading the file.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Fragrances data file not found.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        /// <summary>
        /// Handles the Exit menu being clicked.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the About menu being clicked.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Sales Quote menu being clicked.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            try
            {
                SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
                salesQuoteForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        /// <summary>
        /// Handles form being loaded.
        /// </summary>
        private void LauncherForm_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
