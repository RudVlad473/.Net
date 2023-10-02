namespace Lab_3
{
    partial class BaseCrudForm
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
            dataGridView = new DataGridView();
            createButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            groupBox1 = new GroupBox();
            refreshViewButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(405, 487);
            dataGridView.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.BackColor = Color.GreenYellow;
            createButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(246, 22);
            createButton.Name = "createButton";
            createButton.Size = new Size(113, 72);
            createButton.TabIndex = 1;
            createButton.Text = "CREATE";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(127, 22);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(113, 72);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 255);
            updateButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(8, 22);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(113, 72);
            updateButton.TabIndex = 3;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(refreshViewButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(createButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Location = new Point(423, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 168);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // refreshViewButton
            // 
            refreshViewButton.BackColor = Color.FromArgb(224, 224, 224);
            refreshViewButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshViewButton.Location = new Point(8, 96);
            refreshViewButton.Name = "refreshViewButton";
            refreshViewButton.Size = new Size(351, 66);
            refreshViewButton.TabIndex = 5;
            refreshViewButton.Text = "REFRESH TABLE";
            refreshViewButton.UseVisualStyleBackColor = false;
            refreshViewButton.Click += refreshViewButton_Click;
            // 
            // BaseCrudForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            MinimizeBox = false;
            Name = "BaseCrudForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseCrudForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView;
        public Button createButton;
        public Button deleteButton;
        public Button updateButton;
        public GroupBox groupBox1;
        public Button refreshViewButton;
    }
}