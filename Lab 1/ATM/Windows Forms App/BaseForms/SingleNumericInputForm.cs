using Class_Library;

namespace Windows_Forms_App.BaseForms
{
    public partial class SingleNumericInputForm : Form
    {
        protected readonly AppState _appState;

        public SingleNumericInputForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;
        }

        private void SubmitButton_Click(object sender, EventArgs e) { }
    }
}
