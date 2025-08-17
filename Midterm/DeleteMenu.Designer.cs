namespace Midterm
{
    partial class DeleteMenu
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            lblConfirmInfo = new Label();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(794, 303);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 1);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 28;
            label1.Text = "ลบข้อมูลเมนู";
            // 
            // lblConfirmInfo
            // 
            lblConfirmInfo.AutoSize = true;
            lblConfirmInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmInfo.ForeColor = Color.Black;
            lblConfirmInfo.Location = new Point(3, 371);
            lblConfirmInfo.Name = "lblConfirmInfo";
            lblConfirmInfo.Size = new Size(108, 28);
            lblConfirmInfo.TabIndex = 29;
            lblConfirmInfo.Text = "ข้อมูลที่จะลบ";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(494, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 51);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "ลบข้อมูล";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(652, 462);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 31;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(lblConfirmInfo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DeleteMenu";
            Text = "DeleteMenu";
            Load += DeleteMenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Label label1;
        private Label lblConfirmInfo;
        private Button btnDelete;
        private Button button1;
    }
}