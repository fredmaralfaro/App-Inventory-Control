using System;
using System.Collections.Generic;

namespace MVC_Inventory.Models;

public partial class Product
{
    public string Code { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Stock { get; set; }

    public string Unit { get; set; } = null!;

    public decimal Cost { get; set; }

    public decimal SalePrice { get; set; }

    public byte[]? Photo { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
