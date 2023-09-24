namespace Windows_Forms_App.OptionForms
{
    partial class OperationHistoryForm
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
            operationsHistoryDataGridView = new DataGridView();
            label1 = new Label();
            dropFilterButton = new Button();
            todayButton = new Button();
            label2 = new Label();
            weekButton = new Button();
            monthButton = new Button();
            ((System.ComponentModel.ISupportInitialize)operationsHistoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // operationsHistoryDataGridView
            // 
            operationsHistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operationsHistoryDataGridView.Location = new Point(12, 43);
            operationsHistoryDataGridView.Name = "operationsHistoryDataGridView";
            operationsHistoryDataGridView.RowTemplate.Height = 25;
            operationsHistoryDataGridView.Size = new Size(437, 406);
            operationsHistoryDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 2;
            label1.Text = "Operations history";
            // 
            // dropFilterButton
            // 
            dropFilterButton.BackColor = SystemColors.ButtonShadow;
            dropFilterButton.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dropFilterButton.Location = new Point(517, 404);
            dropFilterButton.Name = "dropFilterButton";
            dropFilterButton.Size = new Size(209, 45);
            dropFilterButton.TabIndex = 7;
            dropFilterButton.Text = "DROP FILTER";
            dropFilterButton.UseVisualStyleBackColor = false;
            dropFilterButton.Click += button1_Click;
            // 
            // todayButton
            // 
            todayButton.BackColor = Color.Chartreuse;
            todayButton.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            todayButton.Location = new Point(455, 71);
            todayButton.Name = "todayButton";
            todayButton.Size = new Size(317, 79);
            todayButton.TabIndex = 8;
            todayButton.Text = "TODAY";
            todayButton.UseVisualStyleBackColor = false;
            todayButton.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(550, 43);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 9;
            label2.Text = "Filter by:";
            // 
            // weekButton
            // 
            weekButton.BackColor = Color.Chartreuse;
            weekButton.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            weekButton.Location = new Point(455, 156);
            weekButton.Name = "weekButton";
            weekButton.Size = new Size(317, 79);
            weekButton.TabIndex = 10;
            weekButton.Text = "THIS WEEK";
            weekButton.UseVisualStyleBackColor = false;
            weekButton.Click += weekButton_Click;
            // 
            // monthButton
            // 
            monthButton.BackColor = Color.Chartreuse;
            monthButton.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            monthButton.Location = new Point(455, 241);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(317, 79);
            monthButton.TabIndex = 11;
            monthButton.Text = "THIS MONTH";
            monthButton.UseVisualStyleBackColor = false;
            monthButton.Click += monthButton_Click;
            // 
            // OperationHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(monthButton);
            Controls.Add(weekButton);
            Controls.Add(label2);
            Controls.Add(todayButton);
            Controls.Add(dropFilterButton);
            Controls.Add(label1);
            Controls.Add(operationsHistoryDataGridView);
            Name = "OperationHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OperationHistoryForm";
            Load += OperationHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)operationsHistoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView operationsHistoryDataGridView;
        private Label label1;
        private Button dropFilterButton;
        private Button todayButton;
        private Label label2;
        private Button weekButton;
        private Button monthButton;
    }
}