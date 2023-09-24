namespace Windows_Forms_App.BaseForms
{
    partial class SingleNumericInputForm
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
            submitButton = new Button();
            groupBox1 = new GroupBox();
            numericUpDown = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.Location = new Point(83, 201);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(196, 79);
            submitButton.TabIndex = 7;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown);
            groupBox1.Location = new Point(83, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input amount";
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Cascadia Code", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown.Location = new Point(6, 44);
            numericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(188, 39);
            numericUpDown.TabIndex = 0;
            // 
            // SingleNumericInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(submitButton);
            Controls.Add(groupBox1);
            Name = "SingleNumericInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SingleNumericInputForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Button submitButton;
        protected GroupBox groupBox1;
        protected NumericUpDown numericUpDown;
    }
}