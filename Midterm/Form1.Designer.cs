namespace Midterm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtSearch = new TextBox();
            label8 = new Label();
            btnSaveOrder = new Button();
            numericUpDownNumber = new NumericUpDown();
            comboBoxTrans = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewBuy = new DataGridView();
            tabPage2 = new TabPage();
            btndelete = new Button();
            btn_goto_page_edit = new Button();
            btn_goto_page_addmenu = new Button();
            tabPage3 = new TabPage();
            labelTotalQuantity = new Label();
            labelTotalAmount = new Label();
            dataGridViewReport = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 522);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnSaveOrder);
            tabPage1.Controls.Add(numericUpDownNumber);
            tabPage1.Controls.Add(comboBoxTrans);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridViewBuy);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ขายสินค้า";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(109, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(673, 34);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 31);
            label8.Name = "label8";
            label8.Size = new Size(79, 28);
            label8.TabIndex = 11;
            label8.Text = "ชื่อสินค้า";
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveOrder.ForeColor = Color.Green;
            btnSaveOrder.Location = new Point(627, 360);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(155, 54);
            btnSaveOrder.TabIndex = 10;
            btnSaveOrder.Text = "บันทึกการสั่งซื้อ";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // numericUpDownNumber
            // 
            numericUpDownNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownNumber.Location = new Point(390, 318);
            numericUpDownNumber.Name = "numericUpDownNumber";
            numericUpDownNumber.Size = new Size(150, 34);
            numericUpDownNumber.TabIndex = 9;
            // 
            // comboBoxTrans
            // 
            comboBoxTrans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTrans.FormattingEnabled = true;
            comboBoxTrans.Location = new Point(389, 426);
            comboBoxTrans.Name = "comboBoxTrans";
            comboBoxTrans.Size = new Size(151, 36);
            comboBoxTrans.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(277, 426);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 7;
            label7.Text = "การจ่ายเงิน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(264, 373);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 6;
            label6.Text = "จำเงินรวม";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 318);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 5;
            label5.Text = "จำนวนสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 444);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 4;
            label4.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 405);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 3;
            label3.Text = "ประเภท";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 360);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "ประเภทเมนู";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 318);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 1;
            label1.Text = "ชื่อเมนู";
            // 
            // dataGridViewBuy
            // 
            dataGridViewBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuy.Location = new Point(6, 76);
            dataGridViewBuy.Name = "dataGridViewBuy";
            dataGridViewBuy.RowHeadersWidth = 51;
            dataGridViewBuy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuy.Size = new Size(776, 224);
            dataGridViewBuy.TabIndex = 0;
            dataGridViewBuy.SelectionChanged += DataGridViewBuy_SelectionChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btndelete);
            tabPage2.Controls.Add(btn_goto_page_edit);
            tabPage2.Controls.Add(btn_goto_page_addmenu);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "เพิ่ม/ลบ/แก้ไขข้อมูลเมน";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonFace;
            btndelete.Location = new Point(528, 6);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(254, 475);
            btndelete.TabIndex = 2;
            btndelete.Text = "ลบข้อมูลเมนู";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btn_goto_page_edit
            // 
            btn_goto_page_edit.BackColor = Color.Gold;
            btn_goto_page_edit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_goto_page_edit.ForeColor = SystemColors.ButtonHighlight;
            btn_goto_page_edit.Location = new Point(263, 5);
            btn_goto_page_edit.Name = "btn_goto_page_edit";
            btn_goto_page_edit.Size = new Size(259, 476);
            btn_goto_page_edit.TabIndex = 1;
            btn_goto_page_edit.Text = "แก้ไขข้อมูลเมนู";
            btn_goto_page_edit.UseVisualStyleBackColor = false;
            btn_goto_page_edit.Click += btn_goto_page_edit_Click;
            // 
            // btn_goto_page_addmenu
            // 
            btn_goto_page_addmenu.BackColor = Color.ForestGreen;
            btn_goto_page_addmenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_goto_page_addmenu.ForeColor = SystemColors.ButtonFace;
            btn_goto_page_addmenu.Location = new Point(3, 6);
            btn_goto_page_addmenu.Name = "btn_goto_page_addmenu";
            btn_goto_page_addmenu.Size = new Size(254, 475);
            btn_goto_page_addmenu.TabIndex = 0;
            btn_goto_page_addmenu.Text = "เพิ่มข้อมูลเมนู";
            btn_goto_page_addmenu.UseVisualStyleBackColor = false;
            btn_goto_page_addmenu.Click += btn_goto_page_addmenu_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(labelTotalQuantity);
            tabPage3.Controls.Add(labelTotalAmount);
            tabPage3.Controls.Add(dataGridViewReport);
            tabPage3.Controls.Add(dateTimePicker1);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 481);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "รายงานสรุปการขาย";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Location = new Point(346, 19);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(0, 28);
            labelTotalQuantity.TabIndex = 4;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new Point(551, 19);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(0, 28);
            labelTotalAmount.TabIndex = 3;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(2, 66);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(782, 412);
            dataGridViewReport.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(70, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btn_goto_page_addmenu;
        private Button btn_goto_page_edit;
        private Button btndelete;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewReport;
        private DataGridView dataGridViewBuy;
        private BindingSource bindingSource1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownNumber;
        private ComboBox comboBoxTrans;
        private Label label7;
        private Button btnSaveOrder;
        private TextBox txtSearch;
        private Label label8;
        private Label labelTotalAmount;
        private Label labelTotalQuantity;
    }
}
