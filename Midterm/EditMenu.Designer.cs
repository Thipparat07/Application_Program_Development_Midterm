namespace Midterm
{
    partial class EditMenu
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
            button1 = new Button();
            comboBox_select_type = new ComboBox();
            label6 = new Label();
            btn_editmenu = new Button();
            btn_select_image = new Button();
            label5 = new Label();
            comboBox_select_name = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtid = new TextBox();
            label7 = new Label();
            bindingSource1 = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(451, 540);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(767, 447);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 26;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox_select_type
            // 
            comboBox_select_type.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_select_type.FormattingEnabled = true;
            comboBox_select_type.Location = new Point(566, 329);
            comboBox_select_type.Name = "comboBox_select_type";
            comboBox_select_type.Size = new Size(151, 33);
            comboBox_select_type.TabIndex = 25;
            comboBox_select_type.SelectedIndexChanged += comboBox_select_type_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(487, 329);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 24;
            label6.Text = "ประเภท";
            // 
            // btn_editmenu
            // 
            btn_editmenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editmenu.Location = new Point(564, 447);
            btn_editmenu.Name = "btn_editmenu";
            btn_editmenu.Size = new Size(136, 51);
            btn_editmenu.TabIndex = 23;
            btn_editmenu.Text = "แก้ไขข้อมูล";
            btn_editmenu.UseVisualStyleBackColor = true;
            btn_editmenu.Click += btn_editmenu_Click_1;
            // 
            // btn_select_image
            // 
            btn_select_image.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_select_image.Location = new Point(794, 326);
            btn_select_image.Name = "btn_select_image";
            btn_select_image.Size = new Size(127, 36);
            btn_select_image.TabIndex = 22;
            btn_select_image.Text = "เลือกไฟล์ภาพ";
            btn_select_image.UseVisualStyleBackColor = true;
            btn_select_image.Click += btn_select_image_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(794, 101);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 21;
            label5.Text = "ตัวอย่างภาพ";
            // 
            // comboBox_select_name
            // 
            comboBox_select_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_select_name.FormattingEnabled = true;
            comboBox_select_name.Location = new Point(566, 267);
            comboBox_select_name.Name = "comboBox_select_name";
            comboBox_select_name.Size = new Size(151, 33);
            comboBox_select_name.TabIndex = 20;
            comboBox_select_name.SelectedIndexChanged += comboBox_select_name_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(566, 210);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 19;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtname.Location = new Point(566, 152);
            txtname.Name = "txtname";
            txtname.Size = new Size(149, 31);
            txtname.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 270);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 17;
            label4.Text = "ชื่อประเภท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(500, 212);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 16;
            label3.Text = "ราคา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 158);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 15;
            label2.Text = "ชื่อ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(771, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(630, 22);
            label1.Name = "label1";
            label1.Size = new Size(202, 38);
            label1.TabIndex = 27;
            label1.Text = "แก้ไขข้อมูลเมนู";
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtid.Location = new Point(566, 101);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(149, 31);
            txtid.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(500, 107);
            label7.Name = "label7";
            label7.Size = new Size(31, 25);
            label7.TabIndex = 28;
            label7.Text = "ID";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 546);
            Controls.Add(txtid);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox_select_type);
            Controls.Add(label6);
            Controls.Add(btn_editmenu);
            Controls.Add(btn_select_image);
            Controls.Add(label5);
            Controls.Add(comboBox_select_name);
            Controls.Add(numericUpDown1);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "EditMenu";
            Text = "EditMenu";
            Load += EditMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox_select_type;
        private Label label6;
        private Button btn_editmenu;
        private Button btn_select_image;
        private Label label5;
        private ComboBox comboBox_select_name;
        private NumericUpDown numericUpDown1;
        private TextBox txtname;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtid;
        private Label label7;
        private BindingSource bindingSource1;
        private OpenFileDialog openFileDialog1;
    }
}