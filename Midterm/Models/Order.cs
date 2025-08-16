using System;
using System.Collections.Generic;

namespace Midterm.Models;

public partial class Order
{
    public int Oid { get; set; }

    public int Idmenu { get; set; }

    public int Number { get; set; }

    public int Priceamount { get; set; }

    public DateOnly Date { get; set; }

    public int Trans { get; set; }

    public virtual Menu IdmenuNavigation { get; set; } = null!;
}
