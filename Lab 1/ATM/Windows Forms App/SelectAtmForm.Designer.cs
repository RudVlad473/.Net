namespace Windows_Forms_App
{
    partial class SelectAtmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            atmDataGridView = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)atmDataGridView).BeginInit();
            SuspendLayout();
            // 
            // atmDataGridView
            // 
            atmDataGridView.AllowUserToAddRows = false;
            atmDataGridView.AllowUserToDeleteRows = false;
            atmDataGridView.AllowUserToResizeColumns = false;
            atmDataGridView.AllowUserToResizeRows = false;
            atmDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            atmDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            atmDataGridView.Location = new Point(12, 37);
            atmDataGridView.MultiSelect = false;
            atmDataGridView.Name = "atmDataGridView";
            atmDataGridView.ReadOnly = true;
            atmDataGridView.RowTemplate.Height = 25;
            atmDataGridView.Size = new Size(560, 312);
            atmDataGridView.TabIndex = 0;
            atmDataGridView.CellClick += AtmDataGridView_CellClick;
            atmDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 1;
            label1.Text = "Select ATM from the list";
            // 
            // button1
            // 
            button1.Location = new Point(497, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SelectAtmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(atmDataGridView);
            Name = "SelectAtmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select ATM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)atmDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView atmDataGridView;
        private Label label1;
        private Button button1;
    }
}