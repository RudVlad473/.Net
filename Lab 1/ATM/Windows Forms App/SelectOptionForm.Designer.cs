namespace Windows_Forms_App
{
    partial class SelectOptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            OptionComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptionComboBox);
            groupBox1.Location = new Point(94, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select option";
            // 
            // OptionComboBox
            // 
            OptionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OptionComboBox.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            OptionComboBox.FormattingEnabled = true;
            OptionComboBox.Location = new Point(6, 31);
            OptionComboBox.Name = "OptionComboBox";
            OptionComboBox.Size = new Size(327, 44);
            OptionComboBox.TabIndex = 0;
            OptionComboBox.SelectedIndexChanged += OperationComboBox_SelectedIndexChanged;
            OptionComboBox.SelectionChangeCommitted += OperationComboBox_SelectionChangeCommitted;
            // 
            // SelectOptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 237);
            Controls.Add(groupBox1);
            Name = "SelectOptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select operation";
            Load += SelectOperationForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox OptionComboBox;
    }
}