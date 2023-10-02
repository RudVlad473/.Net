namespace Lab_3
{
    partial class SupplierForm
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
            phoneTextBox = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            addressTextBox = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(phoneTextBox);
            groupBox5.Controls.Add(label3);
            groupBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(8, 198);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(353, 82);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(6, 43);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "123 123 123 123";
            phoneTextBox.Size = new Size(312, 29);
            phoneTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 8;
            label3.Text = "Supplier phone";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(addressTextBox);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(8, 110);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(353, 82);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(6, 43);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PlaceholderText = "Kyiv, Ukraine";
            addressTextBox.Size = new Size(312, 29);
            addressTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 8;
            label1.Text = "Supplier address";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nameTextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(8, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 82);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(6, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Sony";
            nameTextBox.Size = new Size(312, 29);
            nameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 8;
            label2.Text = "Supplier name";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(groupBox2);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox nameTextBox;
        private Label label2;
        private GroupBox groupBox5;
        private TextBox phoneTextBox;
        private Label label3;
        private GroupBox groupBox4;
        private TextBox addressTextBox;
        private Label label1;
    }
}