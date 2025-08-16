using Microsoft.EntityFrameworkCore;
using Midterm.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Midterm
{
    public partial class EditMenu : Form
    {
        private DbCoffeeShopContext context = new DbCoffeeShopContext();
        private byte[] oldImageBytes;

        public EditMenu()
        {
            InitializeComponent();

        }


        private void EditMenu_Load(object sender, EventArgs e)
        {
            LoadMenus();
            ShowNames();
        }

        private void LoadMenus()
        {
            var menus = from m in context.Menus
                        join t in context.TypeCoffees on m.Idtype equals t.Idtype
                        select new
                        {
                            Idmenu = m.Idmenu,
                            Name = m.Name,
                            Price = m.Price,
                            Category = t.Name,
                            Type = t.Type,
                            Image = m.Image
                        };

            bindingSource1.DataSource = menus.ToList();
            dataGridView1.DataSource = bindingSource1.DataSource;

            // ซ่อนคอลัมน์ Image ถ้าไม่ต้องการแสดงเป็น binary
            if (dataGridView1.Columns["Image"] != null)
                dataGridView1.Columns["Image"].Visible = false;
        }

        // โหลด ComboBox Name (ประเภทหลัก)
        private void ShowNames()
        {
            comboBox_select_name.Items.Clear();

            var names = context.TypeCoffees
                               .Select(t => t.Name)
                               .Distinct()
                               .OrderBy(n => n)
                               .ToList();

            foreach (var name in names)
            {
                comboBox_select_name.Items.Add(new ComboBoxItem
                {
                    Value = 0,  // Name ไม่มี Id จริง ใช้ 0
                    Text = name
                });
            }

            comboBox_select_name.SelectedIndex = -1;
            comboBox_select_type.Items.Clear();
            bindingSource1.DataSource = null;
        }

        // เมื่อเลือก Name
        private void comboBox_select_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_select_name.SelectedItem is not ComboBoxItem selectedName) return;

            ShowTypes(selectedName.Text);
            bindingSource1.DataSource = null;
        }

        // โหลด ComboBox Type ตาม Name
        private void ShowTypes(string name)
        {
            comboBox_select_type.Items.Clear();

            var types = context.TypeCoffees
                               .Where(t => t.Name == name)
                               .Select(t => new { t.Idtype, t.Type })
                               .Distinct()
                               .OrderBy(t => t.Type)
                               .ToList();

            foreach (var t in types)
            {
                comboBox_select_type.Items.Add(new ComboBoxItem
                {
                    Value = t.Idtype,  // Idtype ใช้ query
                    Text = t.Type      // ข้อความ Hot/Ice
                });
            }

            comboBox_select_type.SelectedIndex = -1;
        }

        // เมื่อเลือก Type
        private void comboBox_select_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_select_name.SelectedItem is not ComboBoxItem selectedName) return;
            if (comboBox_select_type.SelectedItem is not ComboBoxItem selectedType) return;

            LoadMenuList(selectedName.Text, selectedType.Value);
        }

        // โหลดเมนูตาม Name + Idtype
        private void LoadMenuList(string name, int idtype)
        {
            var menus = context.Menus
                               .Where(m => m.Idtype == idtype)
                               .Select(m => new
                               {
                                   m.Idmenu,
                                   m.Name,
                                   m.Price
                               })
                               .ToList();

            bindingSource1.DataSource = menus;
        }

        private void btn_select_image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            txtid.Text = dataGridView1.CurrentRow.Cells["Idmenu"].Value?.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString();

            if (decimal.TryParse(dataGridView1.CurrentRow.Cells["Price"].Value?.ToString(), out decimal price))
                numericUpDown1.Value = price;

            // โหลดรูป
            if (dataGridView1.CurrentRow.Cells["Image"].Value is byte[] imgBytes && imgBytes.Length > 0)
            {
                using var ms = new MemoryStream(imgBytes);
                pictureBox1.Image = Image.FromStream(ms);
                oldImageBytes = imgBytes;
            }
            else
            {
                pictureBox1.Image = null;
                oldImageBytes = null;
            }

            // โหลด Category และ Type
            string category = dataGridView1.CurrentRow.Cells["Category"]?.Value?.ToString();
            string type = dataGridView1.CurrentRow.Cells["Type"]?.Value?.ToString();

            if (!string.IsNullOrEmpty(category))
            {
                var categoryItem = comboBox_select_name.Items
                    .Cast<ComboBoxItem>()
                    .FirstOrDefault(i => i.Text.Equals(category, StringComparison.OrdinalIgnoreCase));

                if (categoryItem != null)
                {
                    comboBox_select_name.SelectedIndexChanged -= comboBox_select_name_SelectedIndexChanged; // ป้องกัน loop
                    comboBox_select_name.SelectedItem = categoryItem;

                    // รีโหลด Type ของ Category
                    ShowTypes(categoryItem.Text);

                    var typeItem = comboBox_select_type.Items
                        .Cast<ComboBoxItem>()
                        .FirstOrDefault(i => i.Text.Equals(type, StringComparison.OrdinalIgnoreCase));

                    if (typeItem != null)
                        comboBox_select_type.SelectedItem = typeItem;
                    else if (comboBox_select_type.Items.Count > 0)
                        comboBox_select_type.SelectedIndex = 0;

                    comboBox_select_name.SelectedIndexChanged += comboBox_select_name_SelectedIndexChanged;
                }
            }
        }

        private void btn_select_image_Click_1(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "เลือกไฟล์รูปภาพ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ป้องกันล็อกไฟล์
                    using var temp = Image.FromFile(ofd.FileName);
                    pictureBox1.Image = new Bitmap(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถโหลดรูปได้: " + ex.Message);
                }

            }

        }

        private void btn_editmenu_Click_1(object sender, EventArgs e)
        {
            try
            {
                // ตรวจสอบ Idmenu
                if (!int.TryParse(txtid.Text, out int menuId))
                {
                    MessageBox.Show("ไม่พบรหัสเมนูที่เลือก");
                    return;
                }

                var menu = context.Menus.Find(menuId);
                if (menu == null)
                {
                    MessageBox.Show("ไม่พบเมนูที่ต้องการแก้ไข");
                    return;
                }

                // ตรวจสอบชื่อและประเภท
                if (string.IsNullOrWhiteSpace(txtname.Text))
                {
                    MessageBox.Show("กรุณากรอกชื่อเมนู");
                    return;
                }

                if (comboBox_select_type.SelectedItem is not ComboBoxItem selectedType)
                {
                    MessageBox.Show("กรุณาเลือกประเภทเมนู");
                    return;
                }

                // ยืนยันการแก้ไข
                var confirm = MessageBox.Show("คุณต้องการแก้ไขเมนูนี้หรือไม่?",
                                              "ยืนยันการแก้ไข",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                // อัปเดตข้อมูล
                menu.Name = txtname.Text.Trim();
                menu.Price = (int)numericUpDown1.Value;
                menu.Idtype = selectedType.Value;

                // อัปเดตรูปภาพถ้ามี
                if (pictureBox1.Image != null)
                {
                    using var ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    menu.Image = ms.ToArray();
                }
                else
                {
                    menu.Image = oldImageBytes; // เก็บรูปเดิมถ้าไม่เปลี่ยน
                }

                context.SaveChanges();
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");

                // รีโหลด DataGridView ข้อมูลล่าสุด
                LoadMenus();

                // รีเซ็ตฟิลด์
                txtid.Clear();
                txtname.Clear();
                numericUpDown1.Value = numericUpDown1.Minimum;
                pictureBox1.Image = null;
                comboBox_select_name.SelectedIndex = -1;
                comboBox_select_type.SelectedIndex = -1;
                oldImageBytes = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 winsert = new Form1();
            this.Hide();             // ซ่อนฟอร์มปัจจุบัน
            winsert.ShowDialog();    // เปิดฟอร์มใหม่แบบ Modal
            this.Close();            // ปิดฟอร์มปัจจุบันหลังจากฟอร์มใหม่ปิด
        }
    }

}
