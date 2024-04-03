using System;
using System.Collections.Generic;

namespace MVC_Inventory.Models;

public partial class Sale
{
    public int Id { get; set; }

    public string IdProduct { get; set; } = null!;

    public int IdClient { get; set; }

    public DateOnly Date { get; set; }

    public int Amount { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
