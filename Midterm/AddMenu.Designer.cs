namespace Midterm
{
    partial class AddMenu
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtname = new TextBox();
            numericUpDown1 = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            comboBox_select_name = new ComboBox();
            label5 = new Label();
            btn_select_image = new Button();
            btn_addmenu = new Button();
            bindingSource1 = new BindingSource(components);
            comboBox_select_type = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(513, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 1;
            label1.Text = "เพิ่มข้อมูลเมนู";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 134);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 208);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 3;
            label3.Text = "ราคา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 279);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 4;
            label4.Text = "ประเภท";
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtname.Location = new Point(224, 128);
            txtname.Name = "txtname";
            txtname.Size = new Size(149, 31);
            txtname.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(224, 206);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox_select_name
            // 
            comboBox_select_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_select_name.FormattingEnabled = true;
            comboBox_select_name.Location = new Point(224, 279);
            comboBox_select_name.Name = "comboBox_select_name";
            comboBox_select_name.Size = new Size(151, 33);
            comboBox_select_name.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(536, 76);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 8;
            label5.Text = "ตัวอย่างภาพ";
            // 
            // btn_select_image
            // 
            btn_select_image.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_select_image.Location = new Point(536, 295);
            btn_select_image.Name = "btn_select_image";
            btn_select_image.Size = new Size(127, 36);
            btn_select_image.TabIndex = 9;
            btn_select_image.Text = "เลือกไฟล์ภาพ";
            btn_select_image.UseVisualStyleBackColor = true;
            btn_select_image.Click += btn_select_image_Click;
            // 
            // btn_addmenu
            // 
            btn_addmenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addmenu.Location = new Point(282, 385);
            btn_addmenu.Name = "btn_addmenu";
            btn_addmenu.Size = new Size(136, 51);
            btn_addmenu.TabIndex = 10;
            btn_addmenu.Text = "เพิ่มข้อมูล";
            btn_addmenu.UseVisualStyleBackColor = true;
            btn_addmenu.Click += btn_addmenu_Click;
            // 
            // comboBox_select_type
            // 
            comboBox_select_type.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_select_type.FormattingEnabled = true;
            comboBox_select_type.Location = new Point(224, 335);
            comboBox_select_type.Name = "comboBox_select_type";
            comboBox_select_type.Size = new Size(151, 33);
            comboBox_select_type.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 335);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 11;
            label6.Text = "ประเภท";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(456, 385);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 13;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(button1);
            Controls.Add(comboBox_select_type);
            Controls.Add(label6);
            Controls.Add(btn_addmenu);
            Controls.Add(btn_select_image);
            Controls.Add(label5);
            Controls.Add(comboBox_select_name);
            Controls.Add(numericUpDown1);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AddMenu";
            Text = "AddMenu";
            Load += AddMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private NumericUpDown numericUpDown1;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox_select_name;
        private Label label5;
        private Button btn_select_image;
        private Button btn_addmenu;
        private BindingSource bindingSource1;
        private ComboBox comboBox_select_type;
        private Label label6;
        private Button button1;
    }
}