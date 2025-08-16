using Midterm.Models;

namespace Midterm
{
    public partial class Form1 : Form
    {
        DbCoffeeShopContext context = new DbCoffeeShopContext();
        public Form1()
        {
            InitializeComponent();
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
                             MenuId = o.Idmenu,
                             MenuName = m.Name,
                             NumberSold = o.Number,
                             UnitPrice = m.Price,
                             Amount = o.Number * m.Price
                         };

            dataGridViewReport.DataSource = result.ToList();
            CalculateSum();
        }


        private void CalculateSum()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridViewReport.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                    sum += Convert.ToDecimal(row.Cells["Amount"].Value);
            }
            //txtsum.Text = sum.ToString("0.00");
        }



    }
}
