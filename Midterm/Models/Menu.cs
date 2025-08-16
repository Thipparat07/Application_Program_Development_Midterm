using System;
using System.Collections.Generic;

namespace Midterm.Models;

public partial class Menu
{
    public int Idmenu { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int Idtype { get; set; }

    public byte[]? Image { get; set; }

    public virtual TypeCoffee IdtypeNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
