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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btndelete = new Button();
            btn_goto_page_edit = new Button();
            btn_goto_page_addmenu = new Button();
            tabPage3 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            dataGridViewReport = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 446);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ขายสินค้า";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btndelete);
            tabPage2.Controls.Add(btn_goto_page_edit);
            tabPage2.Controls.Add(btn_goto_page_addmenu);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "เพิ่ม/ลบ/แก้ไขข้อมูลเมน";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(226, 6);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(102, 51);
            btndelete.TabIndex = 2;
            btndelete.Text = "ลบข้อมูลเมนู";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btn_goto_page_edit
            // 
            btn_goto_page_edit.Location = new Point(118, 6);
            btn_goto_page_edit.Name = "btn_goto_page_edit";
            btn_goto_page_edit.Size = new Size(102, 51);
            btn_goto_page_edit.TabIndex = 1;
            btn_goto_page_edit.Text = "แก้ไขข้อมูลเมนู";
            btn_goto_page_edit.UseVisualStyleBackColor = true;
            btn_goto_page_edit.Click += btn_goto_page_edit_Click;
            // 
            // btn_goto_page_addmenu
            // 
            btn_goto_page_addmenu.Location = new Point(6, 6);
            btn_goto_page_addmenu.Name = "btn_goto_page_addmenu";
            btn_goto_page_addmenu.Size = new Size(106, 51);
            btn_goto_page_addmenu.TabIndex = 0;
            btn_goto_page_addmenu.Text = "เพิ่มข้อมูลเมนู";
            btn_goto_page_addmenu.UseVisualStyleBackColor = true;
            btn_goto_page_addmenu.Click += btn_goto_page_addmenu_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewReport);
            tabPage3.Controls.Add(dateTimePicker1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "รายงานสรุปการขาย";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(259, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(2, 66);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(782, 277);
            dataGridViewReport.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
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
    }
}
