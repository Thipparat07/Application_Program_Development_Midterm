using System;
using System.Collections.Generic;

namespace Midterm.Models;

public partial class TypeCoffee
{
    public int Idtype { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
}
