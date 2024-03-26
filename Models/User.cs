using System;
using System.Collections.Generic;

namespace MVC_Inventory.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public string? Password { get; set; }
}
