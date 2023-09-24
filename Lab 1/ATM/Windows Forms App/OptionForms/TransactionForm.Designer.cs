namespace Windows_Forms_App.OptionForms
{
    partial class TransactionForm
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
            CardNumberTextBox = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CardNumberTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(295, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 115);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Target card number input";
            // 
            // CardNumberTextBox
            // 
            CardNumberTextBox.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CardNumberTextBox.ForeColor = Color.Gray;
            CardNumberTextBox.Location = new Point(6, 57);
            CardNumberTextBox.MaxLength = 19;
            CardNumberTextBox.Name = "CardNumberTextBox";
            CardNumberTextBox.PlaceholderText = "1111 1111 1111 1111";
            CardNumberTextBox.Size = new Size(461, 39);
            CardNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 1;
            label1.Text = "Target card number";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 361);
            Controls.Add(groupBox2);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox CardNumberTextBox;
        private Label label1;
    }
}