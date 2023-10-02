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
    public partial class BaseCrudForm : Form
    {
        protected StoreContext _dbContext;

        public BaseCrudForm()
        {
            InitializeComponent();
        }

        public BaseCrudForm(StoreContext context)
        {
            InitializeComponent();

            _dbContext = context;
        }

        private void createButton_Click(object sender, EventArgs e) { }

        protected void SaveChanges(object sender, EventArgs e)
        {
            _dbContext.SaveChanges();
        }

        protected virtual void ClearInputs() { }

        protected virtual void RefreshDataGridView(object sender, EventArgs e) { }

        private void refreshViewButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(sender, e);
        }
    }
}
