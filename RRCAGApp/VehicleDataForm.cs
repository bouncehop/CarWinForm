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
    public partial class VehicleDataForm : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;

        /// <summary>
        /// Initializes a new instances of the VehicleDataForm class.
        /// </summary>
        public VehicleDataForm()
        {
            InitializeComponent();

            this.Load += VehicleDataForm_Load;
            this.FormClosing += VehicleDataForm_FormClosing;
            this.mnuFileSave.Click += MnuFileSave_Click;
            this.mnuEditDelete.Click += MnuEditDelete_Click;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged;
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            

            this.bindingSource = new BindingSource();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the  Data Grid View item.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
           if (this.dgvVehicles.CurrentRow.Selected 
                && this.dgvVehicles.Rows.IndexOf(this.dgvVehicles.CurrentRow) != this.dgvVehicles.Rows.Count - 1)
            {
                this.mnuEditDelete.Enabled = true;
            }
           else
            {
                this.mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the CellValueChanged event of the  Data Grid View item.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bindingSource.EndEdit();
            this.Text = "* Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the File Close menu item.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the Edit Delete menu item.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            string stockNum = this.dgvVehicles.CurrentRow.Cells[1].Value.ToString() + "?";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete stock item " + stockNum, "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.dgvVehicles.Rows.Remove(this.dgvVehicles.CurrentRow);
                    this.dgvVehicles.EndEdit();
                    this.bindingSource.EndEdit();
                    this.adapter.Update(this.dataset, "VehicleStock");
                    this.mnuEditDelete.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
 

        }

        /// <summary>
        /// Handles the Click event of the File Save menu item.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvVehicles.EndEdit();
                this.bindingSource.EndEdit();
                this.adapter.Update(this.dataset, "VehicleStock");
                this.Text = "Vehicle Data";
            }
            catch
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Handles the FormClosing event of this form.
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (this.dataset.HasChanges())
            {
                DialogResult dialogResult = MessageBox.Show("Do you wish to save changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        this.dgvVehicles.EndEdit();
                        this.bindingSource.EndEdit();
                        this.adapter.Update(this.dataset, "VehicleStock");
                        this.Text = "Vehicle Data";
                    }
                    catch
                    {
                        DialogResult dialogResult2 = MessageBox.Show("An error occurred while saving. Do you still wish to close?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dialogResult2 == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                        else
                        {
                            if (this.connection != null && this.connection.State == ConnectionState.Open)
                            {
                                this.connection.Close();
                                this.connection.Dispose();
                            }
                        }
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    if (this.connection != null && this.connection.State == ConnectionState.Open)
                    {
                        this.connection.Close();
                        this.connection.Dispose();
                    }
                }
            }
            
        }

        /// <summary>
        /// Handles the Load event of this form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            RetrieveDataFromDatabase();
            BindControls();
            this.adapter.RowUpdated += Adapter_RowUpdated;
            this.dgvVehicles.DataError += DgvVehicles_DataError;
            this.dgvVehicles.RowsAdded += DgvVehicles_RowsAdded;

            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;
            
        }

        /// <summary>
        /// Handles the RowsAdded event of the dgvVehicles Data Grid View.
        /// </summary>
        private void DgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvVehicles["SoldBy", this.dgvVehicles.Rows.Count - 2].Value = 0;
        }

        /// <summary>
        /// Handles the DataError event of the dgvVehicles Data Grid View.
        /// </summary>
        private void DgvVehicles_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dgvVehicles.CancelEdit();
        }

        /// <summary>
        /// Handles the RowUpdated event of the DataAdapter.
        /// </summary>
        private void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand command = new OleDbCommand("SELECT @@IDENTITY", this.connection);

                e.Row["ID"] = (int)command.ExecuteScalar();
            }
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
            selectCommand.CommandText = "SELECT * FROM VehicleStock";
            selectCommand.Connection = this.connection;

            this.adapter = new OleDbDataAdapter();
            this.adapter.SelectCommand = selectCommand;

            OleDbCommandBuilder builder = new OleDbCommandBuilder();
            builder.DataAdapter = this.adapter;
            builder.ConflictOption = ConflictOption.OverwriteChanges;

            this.adapter.UpdateCommand = builder.GetUpdateCommand();
            this.adapter.InsertCommand = builder.GetInsertCommand();
            this.adapter.DeleteCommand = builder.GetDeleteCommand();

            this.dataset = new DataSet();

            this.adapter.Fill(this.dataset, "VehicleStock");



        }

        /// <summary>
        /// Binds the controls on the form.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = this.dataset.Tables["VehicleStock"];
            this.dgvVehicles.DataSource = this.bindingSource;
        }
    }
}
