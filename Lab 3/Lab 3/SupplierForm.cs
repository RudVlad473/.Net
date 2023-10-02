using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class SupplierForm: BaseCrudForm
    {
        public SupplierForm(StoreContext context)
            : base(context)
        {
            InitializeComponent();

            createButton.Click += RefreshDataGridView;
            updateButton.Click += RefreshDataGridView;
            deleteButton.Click += RefreshDataGridView;

            dataGridView.CellClick += UpdateSupplierDataInputs;
        }

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void UpdateSupplierDataInputs(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = dataGridView.SelectedRows[0];

            var cells = selectedRow.Cells;

            addressTextBox.Text = cells["Address"].Value.ToString();
            nameTextBox.Text = cells["Name"].Value.ToString();
            phoneTextBox.Text = cells["Phone"].Value.ToString();
        }

        void ClearInputs()
        {
            addressTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        protected override void RefreshDataGridView(object sender, EventArgs e)
        {
            SaveChanges(sender, e);

            var suppliers = _dbContext.Suppliers.ToList();

            dataGridView.DataSource = suppliers;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(sender, e);
        }

        private Supplier GetSupplierData()
        {
            Supplier supplier = new Supplier
            {
                Address = addressTextBox.Text,
                Name = nameTextBox.Text,
                Phone = phoneTextBox.Text
            };

            var validationContext = new ValidationContext(supplier);

            Validator.ValidateObject(supplier, validationContext);

            return supplier;
        }

        private int? GetSelectedSupplierId()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedRow = dataGridView.SelectedRows[0];

            return int.Parse(selectedRow.Cells["SupplierId"].Value.ToString());
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Supplier supplier;

            try
            {
                supplier = GetSupplierData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                return;
            }

            if (supplier == null)
            {
                return;
            }

            try
            {
                var createdSupplier = _dbContext.Suppliers.Add(supplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Supplier created successfully", "Success");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedSupplierId = GetSelectedSupplierId();

            if (selectedSupplierId == null)
            {
                MessageBox.Show("Please select a supplier to delete", "Error");

                return;
            }

            try
            {
                var selectedSupplier = _dbContext.Suppliers.First((supplier) => supplier.SupplierId == selectedSupplierId);

                var productsCount = selectedSupplier?.Products?.Count;

                if (productsCount > 0)
                {
                    throw new Exception($"Supplier has products ({productsCount}). Delete them first.");
                }

                _dbContext.Suppliers.Remove(selectedSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Supplier deleted successfully", "Success");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var selectedSupplierId = GetSelectedSupplierId();

            Supplier updatedSupplier;

            try
            {
                updatedSupplier = GetSupplierData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                return;
            }

            if (updatedSupplier == null)
            {
                return;
            }

            if (selectedSupplierId == null)
            {
                MessageBox.Show("Please select a supplier to update", "Error");

                return;
            }

            updatedSupplier.SupplierId = (int)selectedSupplierId;

            try
            {
                var selectedSupplier = _dbContext.Suppliers.Find(selectedSupplierId);

                selectedSupplier.Address = updatedSupplier.Address;
                selectedSupplier.Name = updatedSupplier.Name;
                selectedSupplier.Phone = updatedSupplier.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Supplier updated successfully", "Success");
        }
    }
}
