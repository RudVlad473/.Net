namespace Windows_Forms_App
{
    partial class EnterCredentialsForm
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
            CardNumberTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            PinTextBox = new TextBox();
            label2 = new Label();
            SubmitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            CardNumberTextBox.TextChanged += CardNumberTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 1;
            label1.Text = "Card number";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CardNumberTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Card number input";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PinTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(14, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 115);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pin input";
            // 
            // PinTextBox
            // 
            PinTextBox.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            PinTextBox.ForeColor = Color.Gray;
            PinTextBox.Location = new Point(6, 57);
            PinTextBox.MaxLength = 4;
            PinTextBox.Name = "PinTextBox";
            PinTextBox.PasswordChar = '*';
            PinTextBox.PlaceholderText = "1234";
            PinTextBox.Size = new Size(461, 39);
            PinTextBox.TabIndex = 0;
            PinTextBox.KeyPress += PinTextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 1;
            label2.Text = "Pin (numbers only)";
            label2.Click += label2_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(159, 313);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(196, 79);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // EnterCredentialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(SubmitButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EnterCredentialsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterCredentialsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox CardNumberTextBox;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox PinTextBox;
        private Label label2;
        private Button SubmitButton;
    }
}