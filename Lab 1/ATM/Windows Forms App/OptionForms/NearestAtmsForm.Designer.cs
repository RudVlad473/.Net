namespace Windows_Forms_App.OptionForms
{
    partial class NearestAtmsForm
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
            label = new Label();
            atmDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)atmDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(617, 25);
            label.TabIndex = 3;
            // 
            // atmDataGridView
            // 
            atmDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            atmDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            atmDataGridView.Location = new Point(6, 47);
            atmDataGridView.Name = "atmDataGridView";
            atmDataGridView.RowTemplate.Height = 25;
            atmDataGridView.Size = new Size(605, 373);
            atmDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(atmDataGridView);
            groupBox1.Controls.Add(label);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nearest ATMs";
            // 
            // NearestAtmsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(groupBox1);
            Name = "NearestAtmsForm";
            Text = "NearestAtmsForm";
            Load += NearestAtmsForm_Load;
            ((System.ComponentModel.ISupportInitialize)atmDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private DataGridView atmDataGridView;
        private GroupBox groupBox1;
    }
}