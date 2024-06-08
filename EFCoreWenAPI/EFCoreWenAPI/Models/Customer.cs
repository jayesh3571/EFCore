using System;
using System.Collections.Generic;

namespace EFCoreWenAPI.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }
}
