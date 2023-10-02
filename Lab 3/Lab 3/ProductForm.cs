using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class ProductForm: BaseCrudForm
    {
        public ProductForm(StoreContext context)
            : base(context)
        {
            InitializeComponent();

            createButton.Click += RefreshDataGridView;
            updateButton.Click += RefreshDataGridView;
            deleteButton.Click += RefreshDataGridView;

            dataGridView.CellClick += UpdateProductDataInputs;
        }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(sender, e);
        }

        private int? GetSelectedSupplierId()
        {
            if (suppliersDataGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedRow = suppliersDataGridView.SelectedRows[0];

            return int.Parse(selectedRow.Cells["SupplierId"].Value.ToString());
        }

        private void SelectSupplierById(int id)
        {
            foreach (DataGridViewRow row in suppliersDataGridView.Rows)
            {
                // Check if the "Id" column cell value matches the target ID
                if (
                    row.Cells["SupplierId"].Value != null
                    && Convert.ToInt32(row.Cells["SupplierId"].Value) == id
                )
                {
                    // Select the row
                    row.Selected = true;
                    // Optionally, you can scroll to the selected row
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    break; // Exit the loop once a match is found
                }
            }
        }

        protected override void ClearInputs()
        {
            this.descriptionTextBox.Text = "";
            this.nameTextBox.Text = "";
            this.priceNumericUpDown.ResetText();

            suppliersDataGridView.ClearSelection();
            dataGridView.ClearSelection();
        }

        private void UpdateProductDataInputs(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = dataGridView.SelectedRows[0];

            var cells = selectedRow.Cells;

            nameTextBox.Text = cells["Name"].Value.ToString();
            descriptionTextBox.Text = cells["Description"].Value.ToString();
            priceNumericUpDown.Value = decimal.Parse(cells["Price"].Value.ToString());

            var supplierId = int.Parse(cells["SupplierId"].Value.ToString());
            SelectSupplierById(supplierId);
        }

        private Product GetProductData()
        {
            var selectedSupplierId = GetSelectedSupplierId();

            if (selectedSupplierId == null)
            {
                throw new Exception("Please select a supplier");
            }

            Product product = new Product
            {
                Description = descriptionTextBox.Text,
                Name = nameTextBox.Text,
                Price = priceNumericUpDown.Value,
                SupplierId = (int)selectedSupplierId
            };

            return product;
        }

        protected override void RefreshDataGridView(object sender, EventArgs e)
        {
            SaveChanges(sender, e);

            var products = _dbContext.Products.ToList();
            dataGridView.DataSource = products;

            var suppliers = _dbContext.Suppliers.ToList();
            suppliersDataGridView.DataSource = suppliers;
        }

        private int? GetSelectedProductId()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                throw new Exception("Please select a product");
            }

            var selectedRow = dataGridView.SelectedRows[0];

            return int.Parse(selectedRow.Cells["ProductId"].Value.ToString());
        }

        private void groupBox3_Enter(object sender, EventArgs e) { }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Product product;

            int productId;

            try
            {
                product = GetProductData();

                productId = (int)GetSelectedProductId();

                product.ProductId = productId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                var selectedProduct = _dbContext.Products.Find(productId);

                if (selectedProduct == null)
                {
                    throw new Exception("Product not found");
                }

                selectedProduct.Name = product.Name;
                selectedProduct.Description = product.Description;
                selectedProduct.Price = product.Price;
                selectedProduct.SupplierId = product.SupplierId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Product updated successfully");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Product product;

            try
            {
                product = GetProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                _dbContext.Products.Add(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Product created successfully");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int productId;

            try
            {
                productId = (int)GetSelectedProductId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                _dbContext.Products.Remove(_dbContext.Products.First(
                    (product) => product.ProductId == productId)
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                ClearInputs();
            }

            MessageBox.Show("Product deleted successfully");
        }
    }
}
