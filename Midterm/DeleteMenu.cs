using Microsoft.EntityFrameworkCore;
using Midterm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Midterm
{
    public partial class DeleteMenu : Form
    {
        private DbCoffeeShopContext context = new DbCoffeeShopContext();
        private int selectedMenuId = 0; // เก็บ Id ที่เลือก

        public DeleteMenu()
        {
            InitializeComponent();
        }

        private void DeleteMenu_Load_1(object sender, EventArgs e)
        {
            LoadMenus();
        }

        private void LoadMenus()
        {
            var menus = from m in context.Menus
                        join t in context.TypeCoffees on m.Idtype equals t.Idtype
                        select new
                        {
                            m.Idmenu,
                            m.Name,
                            m.Price,
                            Category = t.Name,
                            Type = t.Type
                        };

            dataGridView1.DataSource = menus.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            selectedMenuId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Idmenu"].Value);
            string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string category = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();

            // แสดงข้อมูลที่จะแสดงในกล่องข้อความ/Label
            lblConfirmInfo.Text = $"ชื่อเมนู: {name}\nประเภท: {category} - {type}\nราคา: {price} บาท";
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedMenuId == 0)
            {
                MessageBox.Show("กรุณาเลือกเมนูที่จะลบ");
                return;
            }

            // ยืนยันก่อนลบ
            var confirm = MessageBox.Show("คุณต้องการลบเมนูนี้หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var menu = context.Menus.Find(selectedMenuId);
            if (menu == null)
            {
                MessageBox.Show("ไม่พบเมนูนี้");
                return;
            }

            context.Menus.Remove(menu);
            context.SaveChanges();

            MessageBox.Show("ลบเมนูเรียบร้อยแล้ว");

            // รีโหลด DataGridView
            LoadMenus();

            // รีเซ็ตค่า
            selectedMenuId = 0;
            lblConfirmInfo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 winsert = new Form1();
            this.Hide();             // ซ่อนฟอร์มปัจจุบัน
            winsert.ShowDialog();    // เปิดฟอร์มใหม่แบบ Modal
            this.Close();            // ปิดฟอร์มปัจจุบันหลังจากฟอร์มใหม่ปิด
        }
    }

}
