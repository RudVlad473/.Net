using Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App.OptionForms
{
    public partial class NearestAtmsForm : Form
    {
        private readonly AppState _appState;

        public NearestAtmsForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;
        }

        private void NearestAtmsForm_Load(object sender, EventArgs e)
        {
            var nearestAtms = _appState.GetNearestAtms();

            if (nearestAtms == null || nearestAtms.Count == 0)
            {
                label.Text = "No ATMs found";

                return;
            }

            atmDataGridView.DataSource = nearestAtms;
        }
    }
}
