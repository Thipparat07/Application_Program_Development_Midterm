public class ComboBoxItem
{
    public int Value { get; set; }       // เก็บ Id
    public string Text { get; set; }     // ข้อความที่จะแสดงใน ComboBox

    public override string ToString()
    {
        return Text; // ComboBox จะเรียก ToString() เพื่อแสดง
    }
}