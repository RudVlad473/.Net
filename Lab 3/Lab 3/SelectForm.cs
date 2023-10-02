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
    public partial class SelectForm : Form
    {
        private StoreContext _dbContext;

        public SelectForm()
        {
            InitializeComponent();
        }

        public SelectForm(StoreContext context)
        {
            InitializeComponent();

            _dbContext = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var anySuppliers = _dbContext.Suppliers.Any();

            if (!anySuppliers)
            {
                MessageBox.Show("No suppliers found. Please add a supplier first.");

                return;
            }

            var productForm = new ProductForm(_dbContext);

            productForm.Show();
        }

        private void supplierFormButton_Click(object sender, EventArgs e)
        {
            var supplyForm = new SupplierForm(_dbContext);

            supplyForm.Show();
        }
    }
}
