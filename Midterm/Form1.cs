using Midterm.Models;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        DbCoffeeShopContext context = new DbCoffeeShopContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuData();


            // ตั้งค่า NumericUpDown
            numericUpDownNumber.Minimum = 1;   // จำนวนสินค้าต่ำสุด 1
            numericUpDownNumber.Maximum = 1000; // ตามต้องการ
            numericUpDownNumber.Value = 1;      // ค่าเริ่มต้น

            // ตั้งค่า ComboBox วิธีจ่ายเงิน
            comboBoxTrans.Items.Clear();
            comboBoxTrans.Items.Add("เงินสด");
            comboBoxTrans.Items.Add("เงินโอน");
            comboBoxTrans.SelectedIndex = 0;

            // ค่าเริ่มต้น Label จำนวนเงินรวม
            label6.Text = "จำนวนเงินรวม: 0.00";

            // ต่อ Event ValueChanged
            numericUpDownNumber.ValueChanged += numericUpDownNumber_ValueChanged;

            // กำหนดค่าเริ่มต้น Label ยอดรวม
            labelTotalAmount.Text = "ยอดรวมทั้งหมด:";
            labelTotalQuantity.Text = "จำนวนสินค้ารวม:";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadMenuData(searchText);
        }

        private void LoadMenuData(string searchText = "")
        {
            var data = context.Menus
                              .Join(context.TypeCoffees,
                                    m => m.Idtype,
                                    t => t.Idtype,
                                    (m, t) => new
                                    {
                                        m.Idmenu,
                                        ชื่อเมนู = m.Name,
                                        ประเภทเมนู = t.Name,
                                        ประเภท = t.Type,
                                        ราคา = m.Price
                                    });

            if (!string.IsNullOrWhiteSpace(searchText))
                data = data.Where(m => m.ชื่อเมนู.ToLower().Contains(searchText.ToLower()));

            dataGridViewBuy.DataSource = data.ToList();
            dataGridViewBuy.Columns["Idmenu"].Visible = false;
        }


        // ฟังก์ชันคำนวณราคารวม
        private void UpdateTotalPrice()
        {
            if (dataGridViewBuy.SelectedRows.Count == 0)
            {
                label6.Text = "จำนวนเงินรวม: 0.00";
                return;
            }

            var row = dataGridViewBuy.SelectedRows[0];
            decimal price = Convert.ToDecimal(row.Cells["ราคา"].Value);
            decimal totalPrice = price * numericUpDownNumber.Value;

            label6.Text = "จำนวนเงินรวม: " + totalPrice.ToString("0.00");
        }

        // เรียกตอนเปลี่ยนแถว
        private void DataGridViewBuy_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBuy.SelectedRows.Count == 0) return;

            var row = dataGridViewBuy.SelectedRows[0];

            label1.Text = "ชื่อเมนู: " + (row.Cells["ชื่อเมนู"].Value?.ToString() ?? "");
            label2.Text = "ประเภทเมนู: " + (row.Cells["ประเภทเมนู"].Value?.ToString() ?? "");
            label3.Text = "ประเภท: " + (row.Cells["ประเภท"].Value?.ToString() ?? "");
            label4.Text = "ราคา: " + (row.Cells["ราคา"].Value?.ToString() ?? "");

            // ตั้งค่า NumericUpDown
            numericUpDownNumber.Minimum = 1;
            numericUpDownNumber.Maximum = 1000;
            numericUpDownNumber.Value = 1;

            // ตั้งค่า ComboBox
            if (comboBoxTrans.Items.Count > 0)
                comboBoxTrans.SelectedIndex = 0;

            // **อัปเดตราคารวมทันที**
            UpdateTotalPrice();
        }

        // เรียกตอนเปลี่ยนจำนวนสินค้า
        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuy.SelectedRows.Count == 0) return;

            var row = dataGridViewBuy.SelectedRows[0];
            int menuId = (int)row.Cells["Idmenu"].Value;
            int quantity = (int)numericUpDownNumber.Value;
            int trans = comboBoxTrans.SelectedItem.ToString() == "เงินโอน" ? 1 : 0;

            var menu = context.Menus.FirstOrDefault(m => m.Idmenu == menuId);
            if (menu == null) return;

            // คำนวณราคารวม
            int totalPrice = menu.Price * quantity;
            label6.Text = "จำนวนเงินรวม: " + totalPrice.ToString("0.00");

            var order = new Order
            {
                Idmenu = menuId,
                Number = quantity,
                Priceamount = totalPrice,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Trans = trans
            };

            context.Orders.Add(order);
            context.SaveChanges();

            MessageBox.Show("บันทึกคำสั่งซื้อเรียบร้อย");

            // รีเซ็ตค่าและช่องค้นหา
            ResetSelection();

            // โหลดเมนูทั้งหมดใหม่
            LoadMenuData();
        }

        private void ResetSelection()
        {
            // ยกเลิกการเลือกแถวใน DataGridView
            dataGridViewBuy.ClearSelection();

            // รีเซ็ต NumericUpDown
            numericUpDownNumber.Value = numericUpDownNumber.Minimum;

            // รีเซ็ต ComboBox
            if (comboBoxTrans.Items.Count > 0)
                comboBoxTrans.SelectedIndex = 0;

            // รีเซ็ต Label จำนวนเงินรวม
            label6.Text = "จำนวนเงินรวม: 0.00";

            // รีเซ็ต Label ข้อมูลเมนู
            label1.Text = "ชื่อเมนู:";
            label2.Text = "ประเภทเมนู:";
            label3.Text = "ประเภท:";
            label4.Text = "ราคา:";

            //รีเซ็ตช่องค้นหา**
            txtSearch.Text = "";
        }

        private void btn_goto_page_addmenu_Click(object sender, EventArgs e)
        {
            AddMenu winsert = new AddMenu();
            this.Hide();             // ซ่อนฟอร์มปัจจุบัน
            winsert.ShowDialog();    // เปิดฟอร์มใหม่แบบ Modal
            this.Close();            // ปิดฟอร์มปัจจุบันหลังจากฟอร์มใหม่ปิด
        }

        private void btn_goto_page_edit_Click(object sender, EventArgs e)
        {
            EditMenu winsert = new EditMenu();
            this.Hide();             // ซ่อนฟอร์มปัจจุบัน
            winsert.ShowDialog();    // เปิดฟอร์มใหม่แบบ Modal
            this.Close();            // ปิดฟอร์มปัจจุบันหลังจากฟอร์มใหม่ปิด
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteMenu winsert = new DeleteMenu();
            this.Hide();             // ซ่อนฟอร์มปัจจุบัน
            winsert.ShowDialog();    // เปิดฟอร์มใหม่แบบ Modal
            this.Close();            // ปิดฟอร์มปัจจุบันหลังจากฟอร์มใหม่ปิด
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;
            DateOnly selectedDate = DateOnly.FromDateTime(selectedDateTime);

            var result = from o in context.Orders
                         join m in context.Menus on o.Idmenu equals m.Idmenu
                         where o.Date == selectedDate
                         select new
                         {
                             ProductID = o.Idmenu,
                             ProductName = m.Name,
                             QuantitySold = o.Number,
                             UnitPrice = m.Price,
                             TotalAmount = o.Number * m.Price
                         };

            var list = result.ToList();

            dataGridViewReport.DataSource = list;

            // คำนวณยอดรวมเงิน
            decimal totalAmount = list.Sum(x => x.TotalAmount);

            // คำนวณจำนวนรวม
            int totalQuantity = list.Sum(x => x.QuantitySold);

            // แสดงผล
            labelTotalAmount.Text = $"ยอดรวมทั้งหมด: {totalAmount:0.00} บาท";
            labelTotalQuantity.Text = $"จำนวนสินค้ารวม: {totalQuantity} ชิ้น";
        }



    }
}
