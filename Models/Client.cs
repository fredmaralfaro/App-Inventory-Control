using System;
using System.Collections.Generic;

namespace MVC_Inventory.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Names { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
