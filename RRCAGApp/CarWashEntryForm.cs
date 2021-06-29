using Kang.Matthew.Business;
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
    public partial class CarWashEntryForm : Form
    {
        private BindingList<CarWashPackage> packages;
        private BindingList<FragranceType> fragrances;
        private BindingList<string> interiorServices;
        private BindingList<string> exteriorServices;
        
        private BindingSource pkgBindingSource;
        private BindingSource frgBindingSource;
        private BindingSource intrBindingSource;
        private BindingSource extrBindingSource;

        /// <summary>
        /// Initializes an instance of the Car Wash Entry Form.
        /// </summary>
        public CarWashEntryForm()
        {
            InitializeComponent();

            this.Load += CarWashEntryForm_Load;
            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuFileGenerateInvoice.Click += MnuFileGenerateInvoice_Click;
            this.cboPackage.DropDownClosed += CboPackage_DropDownClosed;
            
            this.packages = new BindingList<CarWashPackage>();
            this.fragrances = new BindingList<FragranceType>();
            this.interiorServices = new BindingList<string>();
            this.exteriorServices = new BindingList<string>();

            this.pkgBindingSource = new BindingSource();
            this.frgBindingSource = new BindingSource();
            this.intrBindingSource = new BindingSource();
            this.extrBindingSource = new BindingSource();

            this.packages.Add(new CarWashPackage("Standard"));
            this.packages.Add(new CarWashPackage("Deluxe"));
            this.packages.Add(new CarWashPackage("Executive"));
            this.packages.Add(new CarWashPackage("Luxury"));
        }

        /// <summary>
        /// Handles the generate invoice file menu being clicked.
        /// </summary>
        private void MnuFileGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoice = new CarWashInvoiceForm(this.pkgBindingSource);
            carWashInvoice.ShowDialog();
            InitialState();
        }

      
        /// <summary>
        /// Handles the exit menu file being clicked.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the fragrance combobox selection being changed.
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.packages.Count != 0 && this.fragrances.Count != 0 && this.cboPackage.SelectedIndex != -1)
            {
                for (int i = 0; i < this.packages.Count; i++)
                {
                    this.packages[i] = new CarWashPackage(this.packages[i].PackageChoice, 
                        this.fragrances[this.cboFragrance.SelectedIndex].Fragrance,
                        this.fragrances[this.cboFragrance.SelectedIndex].FragrancePrice);
                }

            }

        }

        /// <summary>
        /// Handles the package combobox being closed.
        /// </summary>
        private void CboPackage_DropDownClosed(object sender, EventArgs e)
        {
            if (this.cboPackage.SelectedIndex == 0)
            {
                this.packages[0] = new CarWashPackage(this.packages[this.cboPackage.SelectedIndex].PackageChoice,
                    this.fragrances[this.cboFragrance.SelectedIndex].Fragrance,
                    this.fragrances[this.cboFragrance.SelectedIndex].FragrancePrice);
            }
        }

        /// <summary>
        /// Handles the fragrance combobox selection being changed.
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.packages.Count != 0 && this.fragrances.Count != 0 && this.cboPackage.SelectedIndex != -1)
            {
                this.interiorServices.Clear();
                this.interiorServices.Add(this.packages[this.cboPackage.SelectedIndex].Fragrance);
                this.interiorServices.Add(this.packages[this.cboPackage.SelectedIndex].Carpets);
                this.interiorServices.Add(this.packages[this.cboPackage.SelectedIndex].Upholstery);
                this.interiorServices.Add(this.packages[this.cboPackage.SelectedIndex].Coat);

                this.exteriorServices.Clear();
                this.exteriorServices.Add(this.packages[this.cboPackage.SelectedIndex].HandWash);
                this.exteriorServices.Add(this.packages[this.cboPackage.SelectedIndex].HandWax);
                this.exteriorServices.Add(this.packages[this.cboPackage.SelectedIndex].WheelPolish);
                this.exteriorServices.Add(this.packages[this.cboPackage.SelectedIndex].DetailEngine);
                this.mnuFileGenerateInvoice.Enabled = true;

                if (this.cboPackage.SelectedIndex == 0)
                {
                    this.packages[0] = new CarWashPackage(this.packages[this.cboPackage.SelectedIndex].PackageChoice,
                        this.fragrances[this.cboFragrance.SelectedIndex].Fragrance,
                        this.fragrances[this.cboFragrance.SelectedIndex].FragrancePrice);
                }
            }
        }

        /// <summary>
        /// Data binds the controls.
        /// </summary>
        private void BindControls()
        {
            this.pkgBindingSource.DataSource = this.packages;
            this.cboPackage.DataSource = this.pkgBindingSource;

            this.cboPackage.DisplayMember = "PackageChoice";

            this.frgBindingSource.DataSource = this.fragrances;
            this.cboFragrance.DataSource = this.frgBindingSource;

            this.cboFragrance.DisplayMember = "Fragrance";

            this.intrBindingSource.DataSource = this.interiorServices;
            this.lstInterior.DataSource = this.intrBindingSource;

            this.extrBindingSource.DataSource = this.exteriorServices;
            this.lstExterior.DataSource = this.extrBindingSource;


            Binding subtotalBind = new Binding("Text", pkgBindingSource, "Subtotal");
            Binding pstBind = new Binding("Text", pkgBindingSource, "PstCharged");
            Binding gstBind = new Binding("Text", pkgBindingSource, "GstCharged");
            Binding totalBind = new Binding("Text", pkgBindingSource, "Total");
            this.lblCarWashSubtotal.DataBindings.Add(subtotalBind);
            this.lblCarWashPST.DataBindings.Add(pstBind);
            this.lblCarWashGST.DataBindings.Add(gstBind);
            this.lblCarWashTotal.DataBindings.Add(totalBind);
            subtotalBind.FormattingEnabled = true;
            gstBind.FormattingEnabled = true;
            pstBind.FormattingEnabled = true;
            totalBind.FormattingEnabled = true;
            this.cboPackage.FormattingEnabled = true;
            this.cboFragrance.FormattingEnabled = true;
            subtotalBind.FormatString = "C";
            gstBind.FormatString = "C";
            totalBind.FormatString = "C";   
            
        }
        /// <summary>
        /// Returns to the initial state of the form.
        /// </summary>
        private void InitialState()
        {
            this.cboPackage.SelectedIndex = -1;
            this.cboFragrance.SelectedIndex = 4;
            this.lblCarWashSubtotal.Text = String.Empty;
            this.lblCarWashPST.Text = String.Empty;
            this.lblCarWashGST.Text = String.Empty;
            this.lblCarWashTotal.Text = String.Empty;
            this.interiorServices.Clear();
            this.exteriorServices.Clear();
            this.cboPackage.Focus();
        }

        /// <summary>
        /// Handles the form being loaded.
        /// </summary>
        private void CarWashEntryForm_Load(object sender, EventArgs e)
        {

            BindControls();
           

            FileStream stream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            SortedDictionary<string, decimal> sortedList = new SortedDictionary<string, decimal>();

            while (reader.Peek() != -1)
            {
                string[] content = reader.ReadLine().Split(',');
                string fragrance = content[0].Trim();
                string fragrancePrice = content[1].Trim();
                decimal price = 0;
                
                try
                {
                    price = decimal.Parse(fragrancePrice);
                }
                catch
                {
                    this.Close();
                    MessageBox.Show("An error occured while reading the file.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sortedList.Add(fragrance, price);
                
            }
            reader.Close();
            stream.Dispose();
            
            foreach (KeyValuePair<string, decimal> pair in sortedList)
            {
                this.fragrances.Add(new FragranceType(pair.Key, pair.Value));
            }

            InitialState();
 
        }
        
    }

}
