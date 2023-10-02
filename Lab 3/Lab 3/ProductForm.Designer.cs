namespace Lab_3
{
    partial class ProductForm
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
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            priceNumericUpDown = new NumericUpDown();
            label3 = new Label();
            groupBox4 = new GroupBox();
            descriptionTextBox = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            suppliersDataGridView = new DataGridView();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersDataGridView).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Click += updateButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(423, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 313);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(priceNumericUpDown);
            groupBox5.Controls.Add(label3);
            groupBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(6, 240);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(353, 73);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceNumericUpDown.Location = new Point(148, 26);
            priceNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            priceNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(199, 35);
            priceNumericUpDown.TabIndex = 9;
            priceNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 8;
            label3.Text = "Product price";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(descriptionTextBox);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(6, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(353, 101);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(6, 52);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "A great television";
            descriptionTextBox.Size = new Size(341, 35);
            descriptionTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 8;
            label1.Text = "Product description";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nameTextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 105);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(6, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Television";
            nameTextBox.Size = new Size(341, 35);
            nameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 8;
            label2.Text = "Product name";
            // 
            // suppliersDataGridView
            // 
            suppliersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersDataGridView.Location = new Point(6, 22);
            suppliersDataGridView.MultiSelect = false;
            suppliersDataGridView.Name = "suppliersDataGridView";
            suppliersDataGridView.ReadOnly = true;
            suppliersDataGridView.RowTemplate.Height = 25;
            suppliersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            suppliersDataGridView.Size = new Size(300, 459);
            suppliersDataGridView.TabIndex = 9;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(suppliersDataGridView);
            groupBox6.Location = new Point(794, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(312, 487);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Select supplier";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 511);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            Controls.SetChildIndex(groupBox6, 0);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersDataGridView).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label label3;
        private GroupBox groupBox4;
        private TextBox descriptionTextBox;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox nameTextBox;
        private Label label2;
        private DataGridView suppliersDataGridView;
        private GroupBox groupBox6;
        private NumericUpDown priceNumericUpDown;
    }
}