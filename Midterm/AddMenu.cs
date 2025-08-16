using Midterm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Midterm
{
    public partial class AddMenu : Form
    {
        private readonly DbCoffeeShopContext context = new DbCoffeeShopContext();

        public AddMenu()
        {
            InitializeComponent();
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {
            ShowNames();

            comboBox_select_name.SelectedIndexChanged += comboBox_select_name_SelectedIndexChanged;
            comboBox_select_type.SelectedIndexChanged += comboBox_select_type_SelectedIndexChanged;
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

        private byte[]? ImageToByteArray(Image? image)
        {
            if (image == null) return null;
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }


        private void btn_select_image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_addmenu_Click(object sender, EventArgs e)
        {
            try
            {
                // ตรวจสอบข้อมูลก่อน
                if (txtname.Text.Trim() == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อเมนู");
                    return;
                }

                if (comboBox_select_type.SelectedItem is not ComboBoxItem selectedType)
                {
                    MessageBox.Show("กรุณาเลือกประเภทเมนู");
                    return;
                }

                // สร้าง Menu ใหม่
                Menu obmenu = new Menu
                {
                    Name = txtname.Text.Trim(),
                    Price = (int)numericUpDown1.Value,
                    Idtype = selectedType.Value,
                    Image = ImageToByteArray(pictureBox1.Image)
                };

                // เพิ่มลง DB
                context.Menus.Add(obmenu);
                int change = context.SaveChanges();

                if (change >= 1)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");

                    // รีเฟรช List
                    if (comboBox_select_name.SelectedItem is ComboBoxItem selectedNameItem)
                    {
                        LoadMenuList(selectedNameItem.Text, selectedType.Value);
                    }

                    // รีเซ็ตฟิลด์เพื่อกรอกใหม่
                    txtname.Clear();
                    numericUpDown1.Value = numericUpDown1.Minimum; // หรือ 0
                    pictureBox1.Image = null;
                    comboBox_select_type.SelectedIndex = -1;
                    comboBox_select_name.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("ค่าที่กรอกไม่ถูกต้อง: " + fex.Message);
            }
            catch (InvalidOperationException ioex)
            {
                MessageBox.Show("เกิดปัญหาในการดึงข้อมูล: " + ioex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
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
