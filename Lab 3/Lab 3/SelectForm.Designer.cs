namespace Lab_3
{
    partial class SelectForm
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
            productFormButton = new Button();
            groupBox1 = new GroupBox();
            supplierFormButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // productFormButton
            // 
            productFormButton.BackColor = Color.FromArgb(128, 255, 128);
            productFormButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            productFormButton.Location = new Point(6, 224);
            productFormButton.Name = "productFormButton";
            productFormButton.Size = new Size(348, 107);
            productFormButton.TabIndex = 0;
            productFormButton.Text = "Product form";
            productFormButton.UseVisualStyleBackColor = false;
            productFormButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(supplierFormButton);
            groupBox1.Controls.Add(productFormButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 337);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select form to work with";
            // 
            // supplierFormButton
            // 
            supplierFormButton.BackColor = Color.FromArgb(255, 128, 128);
            supplierFormButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            supplierFormButton.Location = new Point(6, 22);
            supplierFormButton.Name = "supplierFormButton";
            supplierFormButton.Size = new Size(348, 107);
            supplierFormButton.TabIndex = 1;
            supplierFormButton.Text = "Supplier form";
            supplierFormButton.UseVisualStyleBackColor = false;
            supplierFormButton.Click += supplierFormButton_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(groupBox1);
            Name = "SelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button productFormButton;
        private GroupBox groupBox1;
        private Button supplierFormButton;
    }
}